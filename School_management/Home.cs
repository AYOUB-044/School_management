using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        #region openchildform
        private Form activeform = null;
        void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();  // close any form when open
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_childforms.Controls.Add(childform);
            panel_childforms.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        #endregion
        #region Menu 
        private void button_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Visible == false)
            {
                panel_menu.Visible = true;
            }
            else if (panel_menu.Visible == true)
            {
                panel_menu.Visible = false;
            }

        }

        #endregion
        private void Home_Load(object sender, EventArgs e)
        {
          
                panel_menu.Visible = false;


           
        }

        private void button_teacher_Click(object sender, EventArgs e)
        {
            
            openchildform(new Teacher());
           // panel_menu.Visible = false;

        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            openchildform(new Student());
        }

        private void button_Exam_Click(object sender, EventArgs e)
        {
            openchildform(new Exam());
        }

        private void button_class_Click(object sender, EventArgs e)
        {
            openchildform(new Class());
        }

        private void button_subject_Click(object sender, EventArgs e)
        {
            openchildform(new Subject());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
       
           
        }

        private void panel_childforms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}