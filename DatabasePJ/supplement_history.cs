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
    public partial class supplement_history : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public supplement_history(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void supplement_history_Load(object sender, EventArgs e)
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
            string cmd = "insert into supplement_history (iid, num, price, date) values (" + iidInput.Text + "," + numInput.Text + ", '" + priceInput.Text + "', '" + dateInput.Text + "')";
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
            int selectedRows = supplementHistoryGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from supplement_history where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int sup_id = int.Parse(supplementHistoryGridView.SelectedRows[i].Cells["sup_id"].Value.ToString());
                    cmd += "sup_id = " + sup_id;
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

            if (supIdInput.Text != "") conditions.Add("sup_id = " + supIdInput.Text);
            if (iidInput.Text != "") conditions.Add("iid = " + iidInput.Text);
            if (numInput.Text != "") conditions.Add("num = " + numInput.Text);
            if (priceInput.Text != "") conditions.Add("price = '" + priceInput.Text + "'");
            if (dateInput.Text != "") conditions.Add("date = '" + dateInput.Text + "'");

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

                defaultCmd = "select * from supplement_history where ";
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
            int selectedRows = supplementHistoryGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = supplementHistoryGridView.CurrentRow.Index;
                int sup_id = int.Parse(supplementHistoryGridView.Rows[row].Cells["iid"].Value.ToString());
                string cmd = "update supplement_history set num = " + numInput.Text + ", price = '" + priceInput.Text + "', date = '" + dateInput.Text + " 'where sup_id = " + sup_id;
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

        private void supplementHistoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = supplementHistoryGridView.CurrentRow.Index;

            iidInput.Text = supplementHistoryGridView.Rows[row].Cells["iid"].Value.ToString();
            numInput.Text = supplementHistoryGridView.Rows[row].Cells["num"].Value.ToString();
            priceInput.Text = supplementHistoryGridView.Rows[row].Cells["price"].Value.ToString();
            dateInput.Text = supplementHistoryGridView.Rows[row].Cells["date"].Value.ToString();
        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                supplementHistoryGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from supplement_history";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }
    }
}
