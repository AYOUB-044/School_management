namespace School_management
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_subject = new System.Windows.Forms.Button();
            this.button_class = new System.Windows.Forms.Button();
            this.button_Exam = new System.Windows.Forms.Button();
            this.button_Student = new System.Windows.Forms.Button();
            this.button_teacher = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_childforms = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.AutoScroll = true;
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.panel_menu);
            this.panel_left.Controls.Add(this.button_menu);
            this.panel_left.Controls.Add(this.panel_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(234, 792);
            this.panel_left.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DimGray;
            this.panel_menu.Controls.Add(this.button_subject);
            this.panel_menu.Controls.Add(this.button_class);
            this.panel_menu.Controls.Add(this.button_Exam);
            this.panel_menu.Controls.Add(this.button_Student);
            this.panel_menu.Controls.Add(this.button_teacher);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 153);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(234, 194);
            this.panel_menu.TabIndex = 3;
            // 
            // button_subject
            // 
            this.button_subject.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_subject.FlatAppearance.BorderSize = 0;
            this.button_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subject.ForeColor = System.Drawing.Color.White;
            this.button_subject.Location = new System.Drawing.Point(0, 152);
            this.button_subject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_subject.Name = "button_subject";
            this.button_subject.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_subject.Size = new System.Drawing.Size(234, 38);
            this.button_subject.TabIndex = 4;
            this.button_subject.Text = "Subject";
            this.button_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_subject.UseVisualStyleBackColor = true;
            this.button_subject.Click += new System.EventHandler(this.button_subject_Click);
            // 
            // button_class
            // 
            this.button_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_class.FlatAppearance.BorderSize = 0;
            this.button_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_class.ForeColor = System.Drawing.Color.White;
            this.button_class.Location = new System.Drawing.Point(0, 114);
            this.button_class.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_class.Name = "button_class";
            this.button_class.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_class.Size = new System.Drawing.Size(234, 38);
            this.button_class.TabIndex = 3;
            this.button_class.Text = "Class";
            this.button_class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_class.UseVisualStyleBackColor = true;
            this.button_class.Click += new System.EventHandler(this.button_class_Click);
            // 
            // button_Exam
            // 
            this.button_Exam.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Exam.FlatAppearance.BorderSize = 0;
            this.button_Exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exam.ForeColor = System.Drawing.Color.White;
            this.button_Exam.Location = new System.Drawing.Point(0, 76);
            this.button_Exam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Exam.Name = "button_Exam";
            this.button_Exam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Exam.Size = new System.Drawing.Size(234, 38);
            this.button_Exam.TabIndex = 2;
            this.button_Exam.Text = "Exam";
            this.button_Exam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Exam.UseVisualStyleBackColor = true;
            this.button_Exam.Click += new System.EventHandler(this.button_Exam_Click);
            // 
            // button_Student
            // 
            this.button_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Student.FlatAppearance.BorderSize = 0;
            this.button_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Student.ForeColor = System.Drawing.Color.White;
            this.button_Student.Location = new System.Drawing.Point(0, 38);
            this.button_Student.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Student.Name = "button_Student";
            this.button_Student.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Student.Size = new System.Drawing.Size(234, 38);
            this.button_Student.TabIndex = 1;
            this.button_Student.Text = "Student";
            this.button_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Student.UseVisualStyleBackColor = true;
            this.button_Student.Click += new System.EventHandler(this.button_Student_Click);
            // 
            // button_teacher
            // 
            this.button_teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_teacher.FlatAppearance.BorderSize = 0;
            this.button_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_teacher.ForeColor = System.Drawing.Color.White;
            this.button_teacher.Location = new System.Drawing.Point(0, 0);
            this.button_teacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_teacher.Name = "button_teacher";
            this.button_teacher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_teacher.Size = new System.Drawing.Size(234, 38);
            this.button_teacher.TabIndex = 0;
            this.button_teacher.Text = "Teacher";
            this.button_teacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_teacher.UseVisualStyleBackColor = true;
            this.button_teacher.Click += new System.EventHandler(this.button_teacher_Click);
            // 
            // button_menu
            // 
            this.button_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.ForeColor = System.Drawing.Color.White;
            this.button_menu.Location = new System.Drawing.Point(0, 115);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(234, 38);
            this.button_menu.TabIndex = 2;
            this.button_menu.Text = "Menu";
            this.button_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(234, 115);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_management.Properties.Resources.education;
            this.pictureBox1.Location = new System.Drawing.Point(62, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(234, 734);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 58);
            this.panel1.TabIndex = 1;
            // 
            // panel_childforms
            // 
            this.panel_childforms.BackgroundImage = global::School_management.Properties.Resources.education;
            this.panel_childforms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_childforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childforms.Location = new System.Drawing.Point(234, 0);
            this.panel_childforms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_childforms.Name = "panel_childforms";
            this.panel_childforms.Size = new System.Drawing.Size(918, 734);
            this.panel_childforms.TabIndex = 2;
            this.panel_childforms.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_childforms_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1152, 792);
            this.Controls.Add(this.panel_childforms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(999, 700);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_teacher;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_Student;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_class;
        private System.Windows.Forms.Button button_Exam;
        private System.Windows.Forms.Button button_subject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_childforms;
        private System.Windows.Forms.Button button1;
    }
}