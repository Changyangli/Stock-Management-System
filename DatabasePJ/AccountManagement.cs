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
    public partial class AccountManagement : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public AccountManagement(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            auzList.SelectedIndex = 3;
            if (auz == 2)
            {
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
            }

            ShowAllRecords();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string cmd = "insert into account (username, passwd, authorization, name) values ('" + usernameInput.Text + "', '" + passwdInput.Text + "'," + GetAuz() + ", '" + nameInput.Text + "')";
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
            int selectedRows = accountGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from account where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int id = int.Parse(accountGridView.SelectedRows[i].Cells["id"].Value.ToString());
                    cmd += "id = " + id;
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

            if (usernameInput.Text != "") conditions.Add("username = '" + usernameInput.Text + "'");
            if (passwdInput.Text != "") conditions.Add("passwd = '" + passwdInput.Text + "'");
            if (nameInput.Text != "") conditions.Add("name = '" + nameInput.Text + "'");
            if (auzList.SelectedIndex < 3) conditions.Add("authorization = " + GetAuz());

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

                defaultCmd = "select * from account where ";
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
            int selectedRows = accountGridView.SelectedRows.Count;

            if (selectedRows == 1)
            {
                int row = accountGridView.CurrentRow.Index;
                int id = int.Parse(accountGridView.Rows[row].Cells["id"].Value.ToString());
                string cmd = "update account set username = '" + usernameInput.Text + "', passwd = '" + passwdInput.Text + "', authorization = " + GetAuz() + " where id = " + id;
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

        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = accountGridView.CurrentRow.Index;

            usernameInput.Text = accountGridView.Rows[row].Cells["username"].Value.ToString();
            passwdInput.Text = accountGridView.Rows[row].Cells["passwd"].Value.ToString();
            nameInput.Text = accountGridView.Rows[row].Cells["name"].Value.ToString();
            int thisAuz = int.Parse(accountGridView.Rows[row].Cells["authorization"].Value.ToString());
            auzList.SelectedIndex = thisAuz - 1;
        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                accountGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private int GetAuz()
        {
            return auzList.SelectedIndex + 1;
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from account";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }
    }
}
