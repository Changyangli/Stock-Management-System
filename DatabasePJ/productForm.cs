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
    public partial class productForm : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public productForm(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void productForm_Load(object sender, EventArgs e)
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
            string cmd = "insert into product (name, cid, brand) values ('" + nameInput.Text + "', " + cidInput.Text + ", '" + brandInput.Text + "')";
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
            int selectedRows = productGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from product where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int pid = int.Parse(productGridView.SelectedRows[i].Cells["pid"].Value.ToString());
                    cmd += "pid = " + pid;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<string> conditions = new List<string>();

            if (nameInput.Text != "") conditions.Add("name = '" + nameInput.Text + "'");
            if (cidInput.Text != "") conditions.Add("cid = '" + cidInput.Text + "'");
            if (brandInput.Text != "") conditions.Add("brand = '" + brandInput.Text + "'");

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

                defaultCmd = "select * from product where ";
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
            int selectedRows = productGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = productGridView.CurrentRow.Index;
                int pid = int.Parse(productGridView.Rows[row].Cells["pid"].Value.ToString());
                string cmd = "update product set name = '" + nameInput.Text + "', cid = " + cidInput.Text + ", brand = '" + brandInput.Text + "' where pid = " + pid;
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

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = productGridView.CurrentRow.Index;

            nameInput.Text = productGridView.Rows[row].Cells["name"].Value.ToString();
            cidInput.Text = productGridView.Rows[row].Cells["cid"].Value.ToString();
            brandInput.Text = productGridView.Rows[row].Cells["brand"].Value.ToString();

        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                productGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from product";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }

    }
}
