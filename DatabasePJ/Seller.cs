using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace DatabasePJ
{
    public partial class Seller : Form
    {
        SshClient client;
        MySqlConnection conn;
        string defaultCmd;
        int auz;
        public Seller(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();
            client = argClient;
            conn = argConn;
            auz = argAuz;
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            if (auz == 3)
            {
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
            }

            ShowAllRecords();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //float defaultCredit = 0;
            //if ()
            string cmd = "insert into seller (ssn, name, tel, address, credit) values ('" + ssnInput.Text + "','" + nameInput.Text + "', '" + telInput.Text + "', '" + addressInput.Text + "', '" + creditInput.Text + "')";
            MySqlCommand mysqlCmd = new MySqlCommand(cmd, conn);

            try
            {
                mysqlCmd.ExecuteNonQuery();
                FillDataGridView();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedRows = sellerGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from seller where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int sid = int.Parse(sellerGridView.SelectedRows[i].Cells["sid"].Value.ToString());
                    cmd += "sid = " + sid;
                    if (i < selectedRows - 1)
                        cmd += " or ";
                }

                MySqlCommand mysqlCmd = new MySqlCommand(cmd, conn);

                try
                {
                    mysqlCmd.ExecuteNonQuery();
                    FillDataGridView();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
                MessageBox.Show("Please select whole rows for delete.", "Update failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void searchButton_Click (object sender, EventArgs e)
        {
            List<string> conditions = new List<string>();

            if (ssnInput.Text != "") conditions.Add("ssn = '" + ssnInput.Text + "'");
            if (nameInput.Text != "") conditions.Add("name = '" + nameInput.Text + "'");
            if (telInput.Text != "") conditions.Add("tel = '" + telInput.Text + "'");
            if (addressInput.Text != "") conditions.Add("address = '" + addressInput.Text + "'");
            if (creditInput.Text != "") conditions.Add("credit = " + creditInput.Text);

            if (conditions.Count == 0)
            {
                ShowAllRecords();
            }
            else
            {
                string tmpConditionsInfo = "";
                for (int i = 0; i < conditions.Count; i++)
                {
                    tmpConditionsInfo += conditions[i];
                    if (i < conditions.Count - 1)
                        tmpConditionsInfo += ", ";
                }
                conditionsInfo.Text = tmpConditionsInfo;

                defaultCmd = "select * from seller where ";
                for (int i = 0; i < conditions.Count; i++)
                {
                    defaultCmd += conditions[i];
                    if (i < conditions.Count - 1)
                        defaultCmd += " and ";
                }
            }
            FillDataGridView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedRows = sellerGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = sellerGridView.CurrentRow.Index;
                int sid = int.Parse(sellerGridView.Rows[row].Cells["sid"].Value.ToString());
                string cmd = "update seller set ssn = '" + ssnInput.Text + "', name = '" + nameInput.Text + "', tel = '" + telInput.Text + "', address = '" + addressInput.Text + "', credit = " + creditInput.Text + "where sid = " + sid;
                MySqlCommand mysqlCmd = new MySqlCommand(cmd, conn);

                try
                {
                    mysqlCmd.ExecuteNonQuery();
                    FillDataGridView();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else if (selectedRows == 0)
                MessageBox.Show("Please select a whole row for update.", "Update failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (selectedRows > 1)
                MessageBox.Show("Please select only one row for update.", "Update failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void showAllBbutton_Click(object sender, EventArgs e)
        {
            ShowAllRecords();
        }
        private void sellerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int row = sellerGridView.CurrentRow.Index;          
           ssnInput.Text = sellerGridView.Rows[row].Cells["ssn"].Value.ToString();
           nameInput.Text = sellerGridView.Rows[row].Cells["name"].Value.ToString();
           telInput.Text = sellerGridView.Rows[row].Cells["tel"].Value.ToString();
           addressInput.Text = sellerGridView.Rows[row].Cells["address"].Value.ToString();
           creditInput.Text = sellerGridView.Rows[row].Cells["credit"].Value.ToString();
        }
        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                sellerGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from seller";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }
    }
}
