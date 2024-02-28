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

namespace School_management
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;

        //email   :Teacher1@gmail.com
        //pass    :Teacher1
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textbox_email.Text = "";
            textbox_pass.Text = "";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (textbox_email.Text == "" || textbox_pass.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "select Teacher_id,Email,Password_ from Teacher";
                cmd.Connection = con;
                DataTable dt = new DataTable();
                datr = cmd.ExecuteReader();
                dt.Load(datr);
                cmd.Parameters.Clear();
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (textbox_email.Text == dt.Rows[i][1].ToString() && textbox_pass.Text == dt.Rows[i][2].ToString())
                        {
                            Program.id_teacher = dt.Rows[i][0].ToString();

                            Home h = new Home();
                            this.Hide();
                            
                            h.Show();

                        }
                      


                    }

                }
                else
                {

                    MessageBox.Show("database is empty");
                }





            }

        }
    }
}
