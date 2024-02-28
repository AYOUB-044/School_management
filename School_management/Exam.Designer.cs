namespace School_management
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.combobox_student = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_managementDataSet2 = new School_management.School_managementDataSet2();
            this.datetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.combobox_sub = new Guna.UI2.WinForms.Guna2ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_new = new Guna.UI2.WinForms.Guna2Button();
            this.button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_remove = new Guna.UI2.WinForms.Guna2Button();
            this.button_all = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.examTableAdapter = new School_management.School_managementDataSet2TableAdapters.ExamTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textbox_grade = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentTableAdapter = new School_management.School_managementDataSet2TableAdapters.StudentTableAdapter();
            this.subject_TableAdapter = new School_management.School_managementDataSet2TableAdapters.Subject_TableAdapter();
            this.fkstudentexamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_ = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkstudentexamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_student
            // 
            this.combobox_student.AutoRoundedCorners = true;
            this.combobox_student.BackColor = System.Drawing.Color.Transparent;
            this.combobox_student.BorderRadius = 17;
            this.combobox_student.DataSource = this.studentBindingSource;
            this.combobox_student.DisplayMember = "Student_lname";
            this.combobox_student.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_student.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_student.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_student.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_student.ItemHeight = 30;
            this.combobox_student.Location = new System.Drawing.Point(344, 473);
            this.combobox_student.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combobox_student.Name = "combobox_student";
            this.combobox_student.Size = new System.Drawing.Size(233, 36);
            this.combobox_student.TabIndex = 69;
            this.combobox_student.ValueMember = "Studen_id";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.school_managementDataSet2;
            // 
            // school_managementDataSet2
            // 
            this.school_managementDataSet2.DataSetName = "School_managementDataSet2";
            this.school_managementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datetimepicker
            // 
            this.datetimepicker.AutoRoundedCorners = true;
            this.datetimepicker.BorderColor = System.Drawing.Color.White;
            this.datetimepicker.BorderRadius = 20;
            this.datetimepicker.Checked = true;
            this.datetimepicker.FillColor = System.Drawing.Color.White;
            this.datetimepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker.Location = new System.Drawing.Point(344, 569);
            this.datetimepicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(233, 42);
            this.datetimepicker.TabIndex = 68;
            this.datetimepicker.Value = new System.DateTime(2024, 2, 18, 19, 31, 28, 446);
            // 
            // combobox_sub
            // 
            this.combobox_sub.AutoRoundedCorners = true;
            this.combobox_sub.BackColor = System.Drawing.Color.Transparent;
            this.combobox_sub.BorderRadius = 17;
            this.combobox_sub.DataSource = this.subjectBindingSource;
            this.combobox_sub.DisplayMember = "Subject_name";
            this.combobox_sub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_sub.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_sub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_sub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox_sub.ItemHeight = 30;
            this.combobox_sub.Location = new System.Drawing.Point(344, 518);
            this.combobox_sub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combobox_sub.Name = "combobox_sub";
            this.combobox_sub.Size = new System.Drawing.Size(233, 36);
            this.combobox_sub.TabIndex = 70;
            this.combobox_sub.ValueMember = "Subject_id";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.school_managementDataSet2;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(272, 582);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel7.TabIndex = 77;
            this.guna2HtmlLabel7.Text = "Date";
            // 
            // button_new
            // 
            this.button_new.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_new.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_new.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_new.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_new.FillColor = System.Drawing.Color.IndianRed;
            this.button_new.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_new.ForeColor = System.Drawing.Color.White;
            this.button_new.Location = new System.Drawing.Point(434, 688);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(51, 33);
            this.button_new.TabIndex = 80;
            this.button_new.Text = "New";
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_edit
            // 
            this.button_edit.AutoRoundedCorners = true;
            this.button_edit.BorderRadius = 15;
            this.button_edit.CustomizableEdges.BottomLeft = false;
            this.button_edit.CustomizableEdges.TopLeft = false;
            this.button_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_edit.FillColor = System.Drawing.Color.IndianRed;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(493, 688);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(82, 33);
            this.button_edit.TabIndex = 61;
            this.button_edit.Text = "Edit";
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 28;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.idsubjectDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.examBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(11, 134);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(876, 323);
            this.guna2DataGridView1.TabIndex = 55;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.school_managementDataSet2;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject_";
            this.subjectBindingSource1.DataSource = this.school_managementDataSet2;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.school_managementDataSet2;
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_remove.AutoRoundedCorners = true;
            this.button_remove.BorderRadius = 15;
            this.button_remove.CustomizableEdges.BottomLeft = false;
            this.button_remove.CustomizableEdges.TopLeft = false;
            this.button_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_remove.FillColor = System.Drawing.Color.IndianRed;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.Location = new System.Drawing.Point(805, 79);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(82, 33);
            this.button_remove.TabIndex = 54;
            this.button_remove.Text = "Remove";
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_all
            // 
            this.button_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_all.AutoRoundedCorners = true;
            this.button_all.BorderRadius = 15;
            this.button_all.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.button_all.CustomizableEdges.BottomRight = false;
            this.button_all.CustomizableEdges.TopRight = false;
            this.button_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_all.FillColor = System.Drawing.Color.IndianRed;
            this.button_all.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_all.ForeColor = System.Drawing.Color.White;
            this.button_all.Location = new System.Drawing.Point(618, 79);
            this.button_all.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(82, 33);
            this.button_all.TabIndex = 53;
            this.button_all.Text = "All";
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.AutoRoundedCorners = true;
            this.textbox_search.BorderRadius = 20;
            this.textbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_search.DefaultText = "";
            this.textbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_search.Location = new System.Drawing.Point(11, 72);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.PasswordChar = '\0';
            this.textbox_search.PlaceholderText = "Search by last name";
            this.textbox_search.SelectedText = "";
            this.textbox_search.Size = new System.Drawing.Size(233, 42);
            this.textbox_search.TabIndex = 50;
            // 
            // button_add
            // 
            this.button_add.AutoRoundedCorners = true;
            this.button_add.BorderRadius = 15;
            this.button_add.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.button_add.CustomizableEdges.BottomRight = false;
            this.button_add.CustomizableEdges.TopRight = false;
            this.button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add.FillColor = System.Drawing.Color.IndianRed;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(344, 688);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 33);
            this.button_add.TabIndex = 60;
            this.button_add.Text = "Add";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.guna2CircleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Image = global::School_management.Properties.Resources.paper;
            this.guna2CircleButton4.Location = new System.Drawing.Point(572, 72);
            this.guna2CircleButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton4.TabIndex = 58;
            this.guna2CircleButton4.Click += new System.EventHandler(this.guna2CircleButton4_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.guna2CircleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(845, 18);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton2.TabIndex = 56;
            this.guna2CircleButton2.Text = "X";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::School_management.Properties.Resources.search;
            this.guna2CircleButton1.Location = new System.Drawing.Point(251, 72);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton1.TabIndex = 51;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(272, 482);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(40, 15);
            this.guna2HtmlLabel3.TabIndex = 81;
            this.guna2HtmlLabel3.Text = "Student";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(272, 527);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel4.TabIndex = 82;
            this.guna2HtmlLabel4.Text = "Subject";
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(272, 634);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 15);
            this.guna2HtmlLabel1.TabIndex = 83;
            this.guna2HtmlLabel1.Text = "Grade ./20";
            // 
            // textbox_grade
            // 
            this.textbox_grade.AutoRoundedCorners = true;
            this.textbox_grade.BorderRadius = 20;
            this.textbox_grade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_grade.DefaultText = "";
            this.textbox_grade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_grade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_grade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_grade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_grade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_grade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_grade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_grade.Location = new System.Drawing.Point(344, 623);
            this.textbox_grade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_grade.Name = "textbox_grade";
            this.textbox_grade.PasswordChar = '\0';
            this.textbox_grade.PlaceholderText = "";
            this.textbox_grade.SelectedText = "";
            this.textbox_grade.Size = new System.Drawing.Size(233, 42);
            this.textbox_grade.TabIndex = 84;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // fkstudentexamBindingSource
            // 
            this.fkstudentexamBindingSource.DataMember = "fk_student_exam";
            this.fkstudentexamBindingSource.DataSource = this.studentBindingSource;
            // 
            // button_
            // 
            this.button_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_.FillColor = System.Drawing.Color.IndianRed;
            this.button_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_.ForeColor = System.Drawing.Color.White;
            this.button_.Location = new System.Drawing.Point(708, 79);
            this.button_.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(89, 33);
            this.button_.TabIndex = 86;
            this.button_.Text = "Remove all";
            this.button_.Click += new System.EventHandler(this.button__Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(310, 40);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(243, 18);
            this.guna2HtmlLabel10.TabIndex = 87;
            this.guna2HtmlLabel10.Text = "Add Students whit subject and note";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.DataSource = this.studentBindingSource1;
            this.idstudentDataGridViewTextBoxColumn.DisplayMember = "Student_lname";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "Id student";
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstudentDataGridViewTextBoxColumn.ValueMember = "Studen_id";
            // 
            // idsubjectDataGridViewTextBoxColumn
            // 
            this.idsubjectDataGridViewTextBoxColumn.DataPropertyName = "id_subject";
            this.idsubjectDataGridViewTextBoxColumn.DataSource = this.subjectBindingSource1;
            this.idsubjectDataGridViewTextBoxColumn.DisplayMember = "Subject_name";
            this.idsubjectDataGridViewTextBoxColumn.HeaderText = "Id subject";
            this.idsubjectDataGridViewTextBoxColumn.Name = "idsubjectDataGridViewTextBoxColumn";
            this.idsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsubjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsubjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsubjectDataGridViewTextBoxColumn.ValueMember = "Subject_id";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date_";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 733);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.button_);
            this.Controls.Add(this.textbox_grade);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.combobox_student);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.combobox_sub);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Exam";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkstudentexamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox combobox_student;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_sub;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button button_new;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button button_remove;
        private Guna.UI2.WinForms.Guna2Button button_all;
        private Guna.UI2.WinForms.Guna2TextBox textbox_search;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private School_managementDataSet2 school_managementDataSet2;
        private System.Windows.Forms.BindingSource examBindingSource;
        private School_managementDataSet2TableAdapters.ExamTableAdapter examTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_grade;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private School_managementDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private School_managementDataSet2TableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource fkstudentexamBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private Guna.UI2.WinForms.Guna2Button button_;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}