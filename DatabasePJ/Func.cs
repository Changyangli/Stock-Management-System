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
    public partial class Func : Form
    {
        SshClient client;
        MySqlConnection conn;
        string username;
        int auz;

        public Func(SshClient argClient, MySqlConnection argConn, string argUsername)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Func_FormClosing);

            client = argClient;
            conn = argConn;
            username = argUsername;
        }

        private void Func_Load(object sender, EventArgs e)
        {
            InitComponents();
        }

        private void Func_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            if (client.IsConnected) client.Disconnect();
        }

        private void InitComponents()
        {
            string cmd = "select * from account where username = '" + username + "'";
            MySqlCommand mysqlCmd = new MySqlCommand(cmd, conn);
            MySqlDataReader reader = mysqlCmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    auz = reader.GetInt32(reader.GetOrdinal("authorization"));
                    welcome.Text += reader.GetString(reader.GetOrdinal("name"));
                    if (auz == 1) role.Text = "Super administrator";
                    else if (auz == 2) role.Text = "Administrator";
                    else if (auz == 3) role.Text = "Reader";
                    if (auz == 3)
                    {
                        accountManage.Enabled = false;
                        sqlMode.Enabled = false;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void accountManage_Click(object sender, EventArgs e)
        {
            AccountManagement AccountManagementForm = new AccountManagement(client, conn, auz);
            AccountManagementForm.ShowDialog();
        }

        private void sqlMode_Click(object sender, EventArgs e)
        {
            SQLMode SQLModeForm = new SQLMode(client, conn, auz);
            SQLModeForm.ShowDialog();
        }

        private void categoryManage_Click(object sender, EventArgs e)
        {
            Category CategoryForm = new Category(client, conn, auz);
            CategoryForm.ShowDialog();
        }

        private void itemManage_Click(object sender, EventArgs e)
        {
            itemForm newItemForm = new itemForm(client, conn, auz);
            newItemForm.ShowDialog();
        }

        private void productManage_Click(object sender, EventArgs e)
        {
            productForm newProductForm = new productForm(client, conn, auz);
            newProductForm.ShowDialog();
        }

        private void sellerManage_Click(object sender, EventArgs e)
        {
            Seller sellerForm = new Seller(client, conn, auz);
            sellerForm.ShowDialog();
        }

        private void reviewManage_Click(object sender, EventArgs e)
        {
            Review reviewForm = new Review(client, conn, auz);
            reviewForm.ShowDialog();
        }

        private void sellingsManage_Click(object sender, EventArgs e)
        {
            selling_history sellingHistoryForm = new selling_history(client, conn, auz);
            sellingHistoryForm.ShowDialog();
        }

        private void suppsManage_Click(object sender, EventArgs e)
        {
            supplement_history supplementHistoryForm = new supplement_history(client, conn, auz);
            supplementHistoryForm.ShowDialog();
        }
    }
}
