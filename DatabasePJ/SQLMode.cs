using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace DatabasePJ
{
    public partial class SQLMode : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        int successNum;

        public SQLMode(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            successNum = 0;
            string cmdInput = commands.Text;
            if (cmdInput == "") return;
            string[] cmds;
            cmdInput = cmdInput.Replace("\r\n", " ");
            cmdInput = cmdInput.Replace("\n", " ");
            cmds = cmdInput.Split(';');
            foreach (string singleCmd in cmds)
            {
                int spaceCnt = 0;
                while (spaceCnt < singleCmd.Length && singleCmd[spaceCnt] == ' ') spaceCnt++;
                string handledCmd = singleCmd.Remove(0, spaceCnt);
                if (handledCmd == "") continue;
                if (handledCmd.Substring(0, 6) == "select")
                {
                    Thread newQuerry = new Thread(new ParameterizedThreadStart(NewSelectWindow));
                    newQuerry.IsBackground = true;
                    newQuerry.Start(handledCmd);
                    Thread.Sleep(100);
                }
                else
                {
                    if (handledCmd.Contains(" account "))
                    {
                        if (auz == 2)
                        {
                            MessageBox.Show("Insufficient permission to edit the table \"account\"!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            continue;
                        }
                    }

                    MySqlCommand mysqlCmd = new MySqlCommand(handledCmd, conn);

                    try
                    {
                        mysqlCmd.ExecuteNonQuery();
                        successNum++;
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            Thread.Sleep(1000);
            string singleOrNot = " command";
            if (successNum != 1) singleOrNot += 's';
            MessageBox.Show(successNum + singleOrNot +" have been executed.", "SQL Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void NewSelectWindow(object data)
        {
            string cmd = data as string;
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(cmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                successNum++;
                SQLResultForm SQLResultFormForm = new SQLResultForm(cmd, ds);
                SQLResultFormForm.ShowDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
