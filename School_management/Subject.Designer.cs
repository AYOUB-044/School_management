namespace School_management
{
    partial class Subject
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
            this.textbox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_new = new Guna.UI2.WinForms.Guna2Button();
            this.button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_managementDataSet2 = new School_management.School_managementDataSet2();
            this.button_all = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button_remove = new Guna.UI2.WinForms.Guna2Button();
            this.subject_TableAdapter = new School_management.School_managementDataSet2TableAdapters.Subject_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_name
            // 
            this.textbox_name.AutoRoundedCorners = true;
            this.textbox_name.BorderRadius = 20;
            this.textbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_name.DefaultText = "";
            this.textbox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_name.Location = new System.Drawing.Point(329, 549);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.PlaceholderText = "Enter the subject name";
            this.textbox_name.SelectedText = "";
            this.textbox_name.Size = new System.Drawing.Size(233, 42);
            this.textbox_name.TabIndex = 118;
            // 
            // textbox_id
            // 
            this.textbox_id.AutoRoundedCorners = true;
            this.textbox_id.BorderRadius = 20;
            this.textbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_id.DefaultText = "";
            this.textbox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_id.Location = new System.Drawing.Point(329, 501);
            this.textbox_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.PasswordChar = '\0';
            this.textbox_id.PlaceholderText = "Enter the subject id";
            this.textbox_id.SelectedText = "";
            this.textbox_id.Size = new System.Drawing.Size(233, 42);
            this.textbox_id.TabIndex = 117;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(238, 561);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(68, 15);
            this.guna2HtmlLabel4.TabIndex = 116;
            this.guna2HtmlLabel4.Text = "Subject name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(238, 511);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel3.TabIndex = 115;
            this.guna2HtmlLabel3.Text = "subject id";
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
            this.button_new.Location = new System.Drawing.Point(419, 612);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(51, 33);
            this.button_new.TabIndex = 114;
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
            this.button_edit.Location = new System.Drawing.Point(478, 612);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(82, 33);
            this.button_edit.TabIndex = 112;
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
            this.subjectidDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.subjectBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(13, 156);
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
            this.guna2DataGridView1.TabIndex = 108;
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
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "Subject_id";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "Subject id";
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Subject name";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            this.subjectnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.school_managementDataSet2;
            // 
            // school_managementDataSet2
            // 
            this.school_managementDataSet2.DataSetName = "School_managementDataSet2";
            this.school_managementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button_all.Location = new System.Drawing.Point(717, 101);
            this.button_all.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(82, 33);
            this.button_all.TabIndex = 106;
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
            this.textbox_search.Location = new System.Drawing.Point(13, 94);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.PasswordChar = '\0';
            this.textbox_search.PlaceholderText = "Search by last name";
            this.textbox_search.SelectedText = "";
            this.textbox_search.Size = new System.Drawing.Size(233, 42);
            this.textbox_search.TabIndex = 103;
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
            this.button_add.Location = new System.Drawing.Point(329, 612);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 33);
            this.button_add.TabIndex = 111;
            this.button_add.Text = "Add";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.guna2CircleButton2.Location = new System.Drawing.Point(847, 40);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton2.TabIndex = 109;
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(253, 94);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton1.TabIndex = 104;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
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
            this.button_remove.Location = new System.Drawing.Point(807, 101);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(82, 33);
            this.button_remove.TabIndex = 107;
            this.button_remove.Text = "Remove";
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 733);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.button_remove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textbox_name;
        private Guna.UI2.WinForms.Guna2TextBox textbox_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button button_new;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button button_all;
        private Guna.UI2.WinForms.Guna2TextBox textbox_search;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button button_remove;
        private School_managementDataSet2 school_managementDataSet2;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private School_managementDataSet2TableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
    }
}