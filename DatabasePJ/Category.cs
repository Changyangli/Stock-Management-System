﻿using System;
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
    public partial class Category : Form
    {
        SshClient client;
        MySqlConnection conn;
        int auz;
        string defaultCmd;

        public Category(SshClient argClient, MySqlConnection argConn, int argAuz)
        {
            InitializeComponent();

            client = argClient;
            conn = argConn;
            auz = argAuz;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            if (auz == 3 )
            {
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
            }

            ShowAllRecords();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string cmd = "insert into category (name, description) values ('" + categoryNameInput.Text + "', '" + descriptionInput.Text + "')";
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
            int selectedRows = categoryGridView.SelectedRows.Count;

            if (selectedRows > 0)
            {
                string cmd = "delete from category where ";

                for (int i = 0; i < selectedRows; i++)
                {
                    int cid = int.Parse(categoryGridView.SelectedRows[i].Cells["cid"].Value.ToString());
                    cmd += "cid= " + cid;
                    if (i < selectedRows - 1)
                        cmd += "or";
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

            if (categoryNameInput.Text != "") conditions.Add("name like '%" + categoryNameInput.Text + "%'");
            if (descriptionInput.Text != "") conditions.Add("description like '%" + descriptionInput.Text + "%'");

            if (conditions.Count == 0)
            {
                ShowAllRecords();
            }
            else
            {
                string tmpConditionInfo = "";
                for (int i = 0; i < conditions.Count; i++)
                {
                    tmpConditionInfo += conditions[i];
                    if (i < conditions.Count - 1)
                        tmpConditionInfo += ", ";
                }
                conditionsInfo.Text = tmpConditionInfo;

                defaultCmd = "select * from category where ";
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
            int selectedRows = categoryGridView.SelectedRows.Count;
            if (selectedRows == 1)
            {
                int row = categoryGridView.CurrentRow.Index;
                int cid = int.Parse(categoryGridView.Rows[row].Cells["cid"].Value.ToString());
                string cmd = "update category set name = '" + categoryNameInput.Text + "', description = '" + descriptionInput.Text + "' where cid = " + cid;
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

        private void CategoryGridView_CellClic(object sender, DataGridViewCellEventArgs e)
        {
            int row = categoryGridView.CurrentRow.Index;

            categoryNameInput.Text = categoryGridView.Rows[row].Cells["name"].Value.ToString();
            descriptionInput.Text = categoryGridView.Rows[row].Cells["description"].Value.ToString();
        }

        private void FillDataGridView()
        {
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand(defaultCmd, conn);

            try
            {
                DataSet ds = new DataSet();
                myDataAdapter.Fill(ds);
                categoryGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void ShowAllRecords()
        {
            defaultCmd = "select * from category";
            conditionsInfo.Text = "All records";
            FillDataGridView();
        }
        
    }
}
