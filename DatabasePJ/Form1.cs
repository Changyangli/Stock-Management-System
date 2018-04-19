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
    public partial class Form1 : Form
    {
        SshClient client;
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameinput.AutoSize = false;
            usernameinput.Height = 20;
            passwdinput.AutoSize = false;
            passwdinput.Height = 20;

            SSHConnectMySql();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            if (client.IsConnected) client.Disconnect();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.button1_Click(sender, e);
            }
        }

        public void SSHConnectMySql()
        {
            string SSHHost = "plato.cs.virginia.edu";        // SSH address
            int SSHPort = 22;              // SSH port
            string SSHUser = "(yourinput)";           // SSH username
            string SSHPassword = "(yourinput)";           // SSH password

            string sqlIPA = "127.0.0.1";// 
            string sqlHost = "127.0.0.1"; // 
            uint sqlport = 3306;        // 
            string sqlConn = "Database=(yourinput);Data Source=" + sqlIPA + ";Port=" + sqlport + ";User Id=(yourinput);Password=(yourinput);CharSet=utf8";

            PasswordConnectionInfo connectionInfo = new PasswordConnectionInfo(SSHHost, SSHPort, SSHUser, SSHPassword);
            connectionInfo.Timeout = TimeSpan.FromSeconds(30);
            client = new SshClient(connectionInfo);
            try
            {
                client.Connect();

                if (!client.IsConnected)
                {
                    MessageBox.Show("SSH connect failed");
                }

                var portFwdL = new ForwardedPortLocal(sqlIPA, sqlport, sqlHost, sqlport); //映射到本地端口
                client.AddForwardedPort(portFwdL);
                portFwdL.Start();
                if (!client.IsConnected)
                {
                    MessageBox.Show("port forwarding failed");
                }

                conn = new MySqlConnection(sqlConn);

                try
                {
                    conn.Open();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login()
        {
            string sqlCmd = "select * from account where username = '" + usernameinput.Text + "' and passwd = '" + passwdinput.Text + "'";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(sqlCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                int n = myDataAdapter.Fill(ds);

                if (n > 0)
                {
                    //MessageBox.Show("Welcome!", usernameinput.Text + ", welcome to stock management system", MessageBoxButtons.OKCancel);
                    Func FunctionForm = new Func(client, conn, usernameinput.Text);
                    this.Hide();
                    FunctionForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Incorrect username or password!", "Log in failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
