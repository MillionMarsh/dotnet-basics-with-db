using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.MDi' table. You can move, or remove it, as needed.
            this.mDiTableAdapter1.Fill(this.dataSet4.MDi);
            // TODO: This line of code loads data into the 'dataSet3.MDi' table. You can move, or remove it, as needed.
            this.mDiTableAdapter.Fill(this.dataSet3.MDi);

        }
    }
}
