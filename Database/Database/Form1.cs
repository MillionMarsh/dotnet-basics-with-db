using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;



namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Db' table. You can move, or remove it, as needed.
            this.dbTableAdapter.Fill(this.dBDataSet.Db);
            // TODO: This line of code loads data into the 'dataSet2.MDi' table. You can move, or remove it, as needed.
            this.mDiTableAdapter.Fill(this.dataSet2.MDi);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
