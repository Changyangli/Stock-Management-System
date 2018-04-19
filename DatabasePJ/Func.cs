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
                    if (auz > 1)
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
    }
}
