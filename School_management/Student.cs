using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace School_management
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;
        string id;

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);
            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);


        }



        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_all_Click_1(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                guna2CirclePictureBox1.Image = new Bitmap(ms);

                id = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                textbox_id.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_fname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textbox_lname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string gender = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();// radio button
                if (gender == "Male")
                    radiobutton_male.Checked = true;
                else if (gender =="Female")
                    radiobutton_female.Checked= true;

                datetimepicker_dateb.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); 
                textbox_mobile.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textbox_email.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();  
                datetimepicker_joindate.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(); //
                textbox_adress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                combobox_class.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(); // 

              

            }
            catch (Exception ex)
            { }
        }

        System.Drawing.Image teacher_pic; // global 
        private void button_addpic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    guna2CirclePictureBox1.Image = System.Drawing.Image.FromFile(openf.FileName);
                    // teacher_pic = Image.FromFile(openf.FileName);

                }
                catch (Exception ex) { MessageBox.Show("Enter a correct image"); }
            }


            // error
        }

        private void button_edit_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand();
            con.Open();
            cmd5.CommandText = "Update Student set Studen_id=@id,Student_fname=@fname,Student_lname=@lname,Student_pic=@pic," +
                "Gender=@gender,Date_birth=@dateb,Mobile=@mobile,Email=@email,join_date=@joindate,Adress=@adress,"+
                "num_class=@numclass where Studen_id=@id";
            cmd5.Parameters.AddWithValue("id", textbox_id.Text);
            cmd5.Parameters.AddWithValue("fname", textbox_fname.Text);
            cmd5.Parameters.AddWithValue("lname", textbox_lname.Text);
            if(radiobutton_female.Checked)
                cmd5.Parameters.AddWithValue("gender","Female");
            else if (radiobutton_male.Checked)
                cmd5.Parameters.AddWithValue("gender","Male");
            // radiobutton
            cmd5.Parameters.AddWithValue("dateb", datetimepicker_dateb.Value.Date);
            cmd5.Parameters.AddWithValue("mobile", textbox_mobile.Text);
            cmd5.Parameters.AddWithValue("email", textbox_email.Text);
            cmd5.Parameters.AddWithValue("joindate", datetimepicker_joindate.Value.Date);
            cmd5.Parameters.AddWithValue("adress", textbox_adress.Text);
            cmd5.Parameters.AddWithValue("numclass", combobox_class.SelectedValue);


            // image
            teacher_pic = guna2CirclePictureBox1.Image;

            ImageConverter converter = new ImageConverter();
            byte[] imagebyte = (byte[])converter.ConvertTo(teacher_pic, typeof(byte[]));
            cmd5.Parameters.AddWithValue("pic", imagebyte);  // cmd


            cmd5.Connection = con;
            cmd5.ExecuteNonQuery();
            con.Close();

            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);

        }
        #region empty textboxes
        void empty()
        {
            textbox_id.Text = "";
            textbox_fname.Text = "";
            textbox_lname.Text = "";
            guna2CirclePictureBox1.Image = null;
            radiobutton_male.Checked = false;
            datetimepicker_dateb.Text = "";
            textbox_mobile.Text = "";
            textbox_email.Text = "";
            datetimepicker_joindate.Text = "";
            combobox_class.SelectedValue = 1;
            textbox_adress.Text = "";
        }
        #endregion
        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.CommandText = "insert into Student values (@id,@fname,@lname,@pic," +
                 "@gender,@dateb,@mobile,@email,@jdate,@adress,@numclass)";
            cmd2.Parameters.AddWithValue("id", textbox_id.Text);
            cmd2.Parameters.AddWithValue("fname", textbox_fname.Text);
            cmd2.Parameters.AddWithValue("lname", textbox_lname.Text);
            // radiobutton 
            if (radiobutton_female.Checked)
                cmd2.Parameters.AddWithValue("gender", "Female");
            else if (radiobutton_male.Checked)
                cmd2.Parameters.AddWithValue("gender", "Male");

            cmd2.Parameters.AddWithValue("dateb", datetimepicker_dateb.Value.Date);
            cmd2.Parameters.AddWithValue("mobile", textbox_mobile.Text);
            cmd2.Parameters.AddWithValue("email", textbox_email.Text);
            cmd2.Parameters.AddWithValue("jdate", datetimepicker_joindate.Value.Date);
            cmd2.Parameters.AddWithValue("adress", textbox_adress.Text);
            cmd2.Parameters.AddWithValue("numclass", combobox_class.SelectedValue);


            // image
            teacher_pic = guna2CirclePictureBox1.Image;

            ImageConverter converter = new ImageConverter();
            byte[] imagebyte = (byte[])converter.ConvertTo(teacher_pic, typeof(byte[]));
            cmd2.Parameters.AddWithValue("pic", imagebyte);  // cmd


            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();


            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);
            empty();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
            if (id != null)
            {
                cmd6.CommandText = "Delete from Student  where Studen_id=@id";

                cmd6.Parameters.AddWithValue("id", id);
                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
            }

            con.Close();
            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);
            empty();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            empty();
        }

        //Search
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand();
                DataTable dt1 = new DataTable();
                con.Open();

                cmd3.CommandText = "Select * from Student where Student_lname like @lname";
                cmd3.Connection = con;
                cmd3.Parameters.AddWithValue("lname", textbox_search.Text);
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
