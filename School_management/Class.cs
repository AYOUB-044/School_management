using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;
        int number;

        private void Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                number =Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);

                textbox_number.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textbox_name.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_room.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               

            }
            catch (Exception ex)
            { }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textbox_number.Text == "" || textbox_name.Text == "" || textbox_room.Text == "")
            {
                MessageBox.Show("there is a blank data");
            }
            else
            {

                try
                {
                    SqlCommand cmd5 = new SqlCommand();
            con.Open();
            cmd5.CommandText = "Update Class set Class_num=@num,Class_name=@name,Class_Room=@room where Class_num=@num";
            cmd5.Parameters.AddWithValue("num", textbox_number.Text);
            cmd5.Parameters.AddWithValue("name", textbox_name.Text);
            cmd5.Parameters.AddWithValue("room", textbox_room.Text);
            cmd5.Connection = con;
            cmd5.ExecuteNonQuery();
            con.Close();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);

                }

                catch (Exception ex) { MessageBox.Show("Enter a correct values "); }

            }
        }
        #region empty textboxes
        void empty()
        {
            textbox_number.Text = "";
             textbox_name.Text = "";
            textbox_room.Text = "";
          
        }
        #endregion
        private void button_new_Click(object sender, EventArgs e)
        {
            empty();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textbox_number.Text == "" || textbox_name.Text == "" || textbox_room.Text == "")
            {
                MessageBox.Show("there is a blank data");
            }
            else
            {

                try
                {
                    SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.CommandText = "insert into Class values (@num,@name,@room)";
            cmd2.Parameters.AddWithValue("num", textbox_number.Text);
            cmd2.Parameters.AddWithValue("name", textbox_name.Text);
            cmd2.Parameters.AddWithValue("room", textbox_room.Text);

            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();

            empty();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);
        }

                catch (Exception ex) { MessageBox.Show("Enter a correct values "); }

}
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
            if (number != 0)
            {
                cmd6.CommandText = "Delete from Class  where Class_num=@num";

                cmd6.Parameters.AddWithValue("num", number);
                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
            }
            con.Close();

            empty();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand();
                DataTable dt1 = new DataTable();
                con.Open();

                cmd3.CommandText = "Select * from Class where Class_name like @name";
                cmd3.Connection = con;
                cmd3.Parameters.AddWithValue("name", textbox_search.Text);
                datr = cmd3.ExecuteReader();
                dt1.Load(datr);
                con.Close();
                datr.Close();

                guna2DataGridView1.DataSource = dt1;
                cmd3.Parameters.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a correct value");
            }
        }
    }
}
