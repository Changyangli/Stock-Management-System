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
    public partial class itemForm : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public itemForm(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void itemForm_Load(object sender, EventArgs e)
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
            string cmd = "insert into item (sid, pid, price, stock_num, sold_num, description, pic_url) values (" + sidInput.Text + ", " + pidInput.Text + ", " + priceInput.Text + ", " + stock_numInput.Text + ", " + sold_numInput.Text + ", '" + descriptionInput.Text + "', '" + pic_urlInput.Text + "')";
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
            int selectedRows = itemGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from item where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int iid = int.Parse(itemGridView.SelectedRows[i].Cells["iid"].Value.ToString());
                    cmd += "iid = " + iid;
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

            if (sidInput.Text != "") conditions.Add("sid = '" + sidInput.Text + "'");
            if (pidInput.Text != "") conditions.Add("pid = '" + pidInput.Text + "'");
            if (priceInput.Text != "") conditions.Add("price = '" + priceInput.Text + "'");
            if (stock_numInput.Text != "") conditions.Add("stock_num = '" + stock_numInput.Text + "'");
            if (sold_numInput.Text != "") conditions.Add("sold_num = '" + sold_numInput.Text + "'");
            if (descriptionInput.Text != "") conditions.Add("description like '%" + descriptionInput.Text + "%'");
            if (pic_urlInput.Text != "") conditions.Add("pic_url = '" + pic_urlInput.Text + "'");

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

                defaultCmd = "select * from item where ";
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
            int selectedRows = itemGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = itemGridView.CurrentRow.Index;
                int iid = int.Parse(itemGridView.Rows[row].Cells["iid"].Value.ToString());
                string cmd = "update item set sid = " + sidInput.Text + ", pid = " + pidInput.Text + ", price = " + priceInput.Text + ", stock_num = " + stock_numInput.Text + ", sold_num = " + sold_numInput.Text + ", description = '" + descriptionInput.Text + "', pic_url = '" + pic_urlInput.Text + "' where iid = " + iid;
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


        private void itemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = itemGridView.CurrentRow.Index;

            sidInput.Text = itemGridView.Rows[row].Cells["sid"].Value.ToString();
            pidInput.Text = itemGridView.Rows[row].Cells["pid"].Value.ToString();
            priceInput.Text = itemGridView.Rows[row].Cells["price"].Value.ToString();
            stock_numInput.Text = itemGridView.Rows[row].Cells["stock_num"].Value.ToString();
            sold_numInput.Text = itemGridView.Rows[row].Cells["sold_num"].Value.ToString();
            descriptionInput.Text = itemGridView.Rows[row].Cells["description"].Value.ToString();
            pic_urlInput.Text = itemGridView.Rows[row].Cells["pic_url"].Value.ToString();
        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                itemGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from item";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }

    }
}
