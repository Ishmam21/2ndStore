using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project_CS
{
    public partial class Form1 : Form
    {

       // SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "d/M/yyyy";
            BindData();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.TabStop = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            SqlCommand command = new SqlCommand("insert into ProductINFO (ProductID, Brand, Model, StorageGB, Colour, Date) values ('"+int.Parse(textBox1.Text)+"','"+ textBox2.Text+"','"+ textBox3.Text+"','" + comboBox1.Text+ "','"+ comboBox2.Text + "', '" + DateTime.Parse(dateTimePicker1.Text) + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Insertion Successful.");
            con.Close();
            BindData();

        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

               
                SqlCommand command = new SqlCommand("select * from ProductINFO", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
               

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            SqlCommand command = new SqlCommand("update ProductINFO set Brand = '" +textBox2.Text+"', Model = '" +textBox3.Text+"', StorageGB = '" +comboBox1.Text+"', Colour = '" +comboBox2.Text+ "',UpdateDate = '"+DateTime.Parse(dateTimePicker1.Text)+ "'where ProductID='"+int.Parse(textBox1.Text)+"'",con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully.");
            BindData();






            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;

            if (textBox1.Text != "")
            {
                


                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


                if (MessageBox.Show($"Are you sure you want to delete all records of {textBox1.Text}?", "Delete Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(" Delete ProductINFO where ProductID ='" + int.Parse(textBox1.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();
                }
            }
            else
            {

                MessageBox.Show("Please input Product ID.");
            }


            }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            SqlCommand command = new SqlCommand("select * from ProductINFO where ProductID = '"+int.Parse(textBox1.Text)+"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
