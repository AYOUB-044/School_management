using Guna.UI2.WinForms;
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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;
        int id;
        private void Subject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button_all_Click(object sender, EventArgs e)
        {  // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                id = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);

                textbox_id.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textbox_name.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            { }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textbox_id.Text == "" || textbox_name.Text == "")
            {

                MessageBox.Show("there is a blank data");
            }
            else
            {
                try
                {
                    SqlCommand cmd5 = new SqlCommand();
            con.Open();
            cmd5.CommandText = "Update Subject_ set Subject_id=@id,Subject_name=@name where Subject_id=@id";
            cmd5.Parameters.AddWithValue("id", textbox_id.Text);
            cmd5.Parameters.AddWithValue("name", textbox_name.Text);
            cmd5.Connection = con;
            cmd5.ExecuteNonQuery();
            con.Close();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);
                }
                catch (Exception ex) { MessageBox.Show("Enter  a correct values "); }

            }
        }

        #region empty textboxes
        void empty()
        {
            textbox_id.Text = "";
            textbox_name.Text = "";

        }
        #endregion

        private void button_new_Click(object sender, EventArgs e)
        {
            empty();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();

            if (textbox_id.Text == "" || textbox_name.Text == "")
            {

                MessageBox.Show("there is a blank data");
            }
            else
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.CommandText = "insert into Subject_ values (@id,@name)";
            cmd2.Parameters.AddWithValue("id", textbox_id.Text);
            cmd2.Parameters.AddWithValue("name", textbox_name.Text);

            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();

            empty();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);

        }
                catch (Exception ex) { MessageBox.Show("Enter  a correct values "); }

}
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
            if (id != 0)
            {
                cmd6.CommandText = "Delete from Subject_  where Subject_id=@id";

                cmd6.Parameters.AddWithValue("id", id);
                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
            }
            con.Close();

            empty();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand();
                DataTable dt1 = new DataTable();
                con.Open();

                cmd3.CommandText = "Select * from Subject_ where Subject_name like @name";
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
