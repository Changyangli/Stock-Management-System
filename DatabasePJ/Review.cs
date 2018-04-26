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
    public partial class Review : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public Review(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void Review_Load(object sender, EventArgs e)
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
            string cmd = "insert into review (content, date, sell_id) values ('" + contentInput.Text + "', '" + dateInput.Text + "'," + sellidInput.Text + ")";
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
            int selectedRows = ReviewGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from review where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int rid = int.Parse(ReviewGridView.SelectedRows[i].Cells["rid"].Value.ToString());
                    cmd += "rid = " + rid;
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

            if (contentInput.Text != "") conditions.Add("content like '%" + contentInput.Text + "%'");
            if (dateInput.Text != "") conditions.Add("date = '" + dateInput.Text + "'");
            if (sellidInput.Text != "") conditions.Add("sell_id = " + sellidInput.Text);

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

                defaultCmd = "select * from review where ";
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
            int selectedRows = ReviewGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = ReviewGridView.CurrentRow.Index;
                int rid = int.Parse(ReviewGridView.Rows[row].Cells["rid"].Value.ToString());
                string cmd = "update review set content = '" + contentInput.Text + "', date = '" + dateInput.Text + "', sell_id = " + sellidInput.Text + " where rid = " + rid;
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

        private void reviewGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ReviewGridView.CurrentRow.Index;
            contentInput.Text = ReviewGridView.Rows[row].Cells["content"].Value.ToString();
            dateInput.Text = ReviewGridView.Rows[row].Cells["date"].Value.ToString();
            sellidInput.Text = ReviewGridView.Rows[row].Cells["sell_id"].Value.ToString();
        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                ReviewGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        private void ShowAllRecords()
        {
            defaultCmd = "select * from review";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }
    }
}