using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasePJ
{
    public partial class SQLResultForm : Form
    {
        public SQLResultForm(string cmd, DataSet ds)
        {
            InitializeComponent();

            sqlInfo.Text = cmd;
            selectGridView.DataSource = ds.Tables[0];
        }
    }
}
