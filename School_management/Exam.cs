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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=mob100;Initial Catalog=School_management;Integrated Security=True;TrustServerCertificate=True");
        SqlDataReader datr;
       
        string ids, idsub;

        private void Exam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.school_managementDataSet2.Subject_);
            // TODO: This line of code loads data into the 'school_managementDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.school_managementDataSet2.Student);
            // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                combobox_student.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // 
                combobox_sub.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();  //
                datetimepicker.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();  //
                textbox_grade.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                // id for delete
                ids = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                idsub = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


            }
            catch (Exception ex)
            { }
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textbox_grade.Text == "" || datetimepicker.Text == "" ||
            combobox_student.ValueMember == null || combobox_sub.ValueMember == null)
            {
                MessageBox.Show("there is a blank data");
            }
            else
            {

                try
                {
                    SqlCommand cmd5 = new SqlCommand();
                    con.Open();
                    cmd5.CommandText = "Update Exam set id_student=@ids,id_subject=@idsub,Date_=@date,Grade=@grade where id_student=@ids";

                    cmd5.Parameters.AddWithValue("date", datetimepicker.Value.Date);
                    cmd5.Parameters.AddWithValue("ids", combobox_student.SelectedValue);
                    cmd5.Parameters.AddWithValue("idsub", combobox_sub.SelectedValue);
                    cmd5.Parameters.AddWithValue("grade", textbox_grade.Text);



                    cmd5.Connection = con;
                    cmd5.ExecuteNonQuery();
                    con.Close();

                    // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
                    this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);
                }

                catch (Exception ex) { MessageBox.Show("Enter a correct values "); }
            }

            }

        #region empty textboxes
        void empty()
        {
            textbox_grade.Text = "";
            datetimepicker.Text = "";
            combobox_student.SelectedValue = 1;
            combobox_sub.SelectedValue = 1;
        }
        #endregion
        private void button_new_Click(object sender, EventArgs e)
        {
            empty();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textbox_grade.Text == "" || datetimepicker.Text == "" ||
            combobox_student.ValueMember == null || combobox_sub.ValueMember == null)
            {
                MessageBox.Show("there is a blank data");
            }
            else
            {

                try
                {
                    SqlCommand cmd2 = new SqlCommand();
                        con.Open();
                        cmd2.CommandText = "insert into Exam values (@ids,@idsub,@date,@grade)";

                        cmd2.Parameters.AddWithValue("ids", combobox_student.SelectedValue);
                        cmd2.Parameters.AddWithValue("idsub", combobox_sub.SelectedValue);
                        cmd2.Parameters.AddWithValue("date", datetimepicker.Value.Date);
                        cmd2.Parameters.AddWithValue("grade", textbox_grade.Text);

                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        empty();
                        // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
                        this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);
                }

                catch (Exception ex) { MessageBox.Show("Enter a correct values "); }
            }



        }

        private void button__Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
                cmd6.CommandText = "Delete from Exam";

                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
            
            con.Close();
            empty();

            // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);
        }

  
        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand();
            con.Open();
            if (ids != null)
            {
                cmd6.CommandText = "Delete from Exam  where id_student=@ids";

                cmd6.Parameters.AddWithValue("ids", ids);
                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
            }
            con.Close();
            empty();

            // TODO: This line of code loads data into the 'school_managementDataSet2.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.school_managementDataSet2.Exam);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
        guna2DataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, guna2DataGridView1.Width, guna2DataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

    }
}
