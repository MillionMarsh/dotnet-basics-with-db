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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=database1;Integrated Security=True");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into databas values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')", con);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("FAILURE");
            }
            con.Close();
            con.Open();
            da = new SqlDataAdapter("select * from databas", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update databas set name='"+textBox2.Text.ToString()+"' where id='"+textBox1.Text+"'", con);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("update");
            }
            else
            {
                MessageBox.Show("FAILURE");
            }
            con.Close();
            con.Open();
            da = new SqlDataAdapter("select * from databas", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from databas where id='"+textBox1.Text.ToString()+"'", con);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("deleted");
            }
            else
            {
                MessageBox.Show("FAILURE");
            }
            con.Close();
            con.Open();
            da = new SqlDataAdapter("select * from databas", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from databas where id='"+textBox1.Text.ToString()+"'", con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                textBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                MessageBox.Show("Not found");
            }
            con.Close();
        }
    }
}
