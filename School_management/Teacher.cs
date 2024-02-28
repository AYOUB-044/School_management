using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;


        #region empty textboxes
        void empty()
        {
            textbox_id.Text = "";
            textbox_fname.Text = "";
            textbox_lname.Text = "";
            guna2CirclePictureBox1.Image = null;
            textbox_monile.Text = "";
            textbox_email.Text = "";
            textbox_pass.Text = "";
            datetimepicker.Text = "";
            combobox_class.SelectedValue = 1;
            combobox_sub.SelectedValue = 1;
        }
        #endregion
        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_managementDataSet2.Class);

            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);

            // TODO: This line of code loads data into the 'school_managementDataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.school_managementDataSet1.Teacher);


            // teatcher login
            if (Program.id_teacher != null)
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "select Teacher_id,Teacher_fname,Teacher_lname from Teacher where Teacher_id=@id";
                cmd.Parameters.AddWithValue("id", Program.id_teacher);
                cmd.Connection = con;
                DataTable dt = new DataTable();
                datr = cmd.ExecuteReader();
                dt.Load(datr);
                con.Close();
                string fname = dt.Rows[0][1].ToString();
                string lname = dt.Rows[0][2].ToString();
                label_teacher.Text = fname + " " + lname;
            }



        }

        private void button_all_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.school_managementDataSet1.Teacher);

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        // id for delete
        String id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                guna2CirclePictureBox1.Image = new Bitmap(ms);

                textbox_id.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textbox_fname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textbox_lname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textbox_monile.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textbox_email.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textbox_pass.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                datetimepicker.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();  //

                combobox_class.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(); // 
                combobox_sub.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();  //

                // id for delete
                id = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            }
            catch (Exception ex)
            { }
        }

        Image teacher_pic; // global 
        private void button_addpic_Click(object sender, EventArgs e)
        {

            OpenFileDialog openf = new OpenFileDialog();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    guna2CirclePictureBox1.Image = Image.FromFile(openf.FileName);
                    // teacher_pic = Image.FromFile(openf.FileName);

                }
                catch (Exception ex) { MessageBox.Show("Enter a correct image"); }

            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textbox_id.Text == "" || textbox_fname.Text == "" || textbox_lname.Text == "" || guna2CirclePictureBox1.Image == null ||
            textbox_monile.Text == "" || textbox_email.Text == "" || textbox_pass.Text == "" || datetimepicker.Text == "" ||
            combobox_class.ValueMember == null || combobox_sub.ValueMember == null)
            {
                MessageBox.Show("there is a blank data");
            }
            else
            {

                try
                {

                    SqlCommand cmd5 = new SqlCommand();
                    con.Open();
                    cmd5.CommandText = "Update Teacher set Teacher_id=@id,Teacher_fname=@fname,Teacher_lname=@lname,Teacher_pic=@pic," +
                        "Mobile=@mobile,Email=@email,Password_=@pass,Join_dat=@jdate,num_class=@numclass,id_subject=@idsub where Teacher_id=@id";
                    cmd5.Parameters.AddWithValue("id", textbox_id.Text);
                    cmd5.Parameters.AddWithValue("fname", textbox_fname.Text);
                    cmd5.Parameters.AddWithValue("lname", textbox_lname.Text);
                    cmd5.Parameters.AddWithValue("mobile", textbox_monile.Text);
                    cmd5.Parameters.AddWithValue("email", textbox_email.Text);
                    cmd5.Parameters.AddWithValue("pass", textbox_pass.Text);
                    cmd5.Parameters.AddWithValue("jdate", datetimepicker.Value.Date);
                    cmd5.Parameters.AddWithValue("numclass", combobox_class.SelectedValue);
                    cmd5.Parameters.AddWithValue("idsub", combobox_sub.SelectedValue);


                    // image
                    teacher_pic = guna2CirclePictureBox1.Image;

                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(teacher_pic, typeof(byte[]));
                    cmd5.Parameters.AddWithValue("pic", imagebyte);  // cmd


                    cmd5.Connection = con;
                    cmd5.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'school_managementDataSet1.Teacher' table. You can move, or remove it, as needed.
                    this.teacherTableAdapter.Fill(this.school_managementDataSet1.Teacher);
                }

                catch (Exception ex) { MessageBox.Show("Enter a correct values "); }

            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textbox_id.Text == "" || textbox_fname.Text == "" || textbox_lname.Text == "" || guna2CirclePictureBox1.Image == null ||
            textbox_monile.Text == "" || textbox_email.Text == "" || textbox_pass.Text == "" || datetimepicker.Text == "" ||
            combobox_class.ValueMember == null || combobox_sub.ValueMember == null)
            {

                MessageBox.Show("there is a blank data");
            }
            else
            {
                try
                {

                
                SqlCommand cmd2 = new SqlCommand();
                con.Open();
                cmd2.CommandText = "insert into Teacher values (@id,@fname,@lname,@pic," +
                     "@mobile,@email,@pass,@jdate,@numclass,@idsub)";
                cmd2.Parameters.AddWithValue("id", textbox_id.Text);
                cmd2.Parameters.AddWithValue("fname", textbox_fname.Text);
                cmd2.Parameters.AddWithValue("lname", textbox_lname.Text);
                cmd2.Parameters.AddWithValue("mobile", textbox_monile.Text);
                cmd2.Parameters.AddWithValue("email", textbox_email.Text);
                cmd2.Parameters.AddWithValue("pass", textbox_pass.Text);
                cmd2.Parameters.AddWithValue("jdate", datetimepicker.Value.Date);
                cmd2.Parameters.AddWithValue("numclass", combobox_class.SelectedValue);
                cmd2.Parameters.AddWithValue("idsub", combobox_sub.SelectedValue);


                // image
                teacher_pic = guna2CirclePictureBox1.Image;

                ImageConverter converter = new ImageConverter();
                byte[] imagebyte = (byte[])converter.ConvertTo(teacher_pic, typeof(byte[]));
                cmd2.Parameters.AddWithValue("pic", imagebyte);  // cmd


                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();
                con.Close();
                // TODO: This line of code loads data into the 'school_managementDataSet1.Teacher' table. You can move, or remove it, as needed.
                this.teacherTableAdapter.Fill(this.school_managementDataSet1.Teacher);

                empty();
                }
                catch (Exception ex) { MessageBox.Show("Enter  a correct values "); }

            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            empty();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
            if (id != null)
            {
                
                cmd6.CommandText = "select * from Teacher";
                cmd6.Connection = con;
                DataTable dt = new DataTable();
                datr = cmd6.ExecuteReader();
                dt.Load(datr);
                cmd6.Parameters.Clear();

                if (dt.Rows.Count > 1)
                {

                    cmd6.CommandText = "Delete from Teacher  where Teacher_id=@id";

                    cmd6.Parameters.AddWithValue("id", id);
                    cmd6.Connection = con;
                    cmd6.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("You cannot delete the last admin");
                }


            }

            con.Close();
            // TODO: This line of code loads data into the 'school_managementDataSet1.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.school_managementDataSet1.Teacher);
            empty();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand();
                DataTable dt1 = new DataTable();
                con.Open();

                cmd3.CommandText = "Select * from Teacher where Teacher_lname like @lname";
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
