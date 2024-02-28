namespace School_management
{
    partial class Class
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
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_new = new Guna.UI2.WinForms.Guna2Button();
            this.button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.classnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_managementDataSet2 = new School_management.School_managementDataSet2();
            this.button_remove = new Guna.UI2.WinForms.Guna2Button();
            this.button_all = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.textbox_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_room = new Guna.UI2.WinForms.Guna2TextBox();
            this.classTableAdapter = new School_management.School_managementDataSet2TableAdapters.ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(238, 551);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel4.TabIndex = 99;
            this.guna2HtmlLabel4.Text = "Class name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(238, 506);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(66, 15);
            this.guna2HtmlLabel3.TabIndex = 98;
            this.guna2HtmlLabel3.Text = "Class number";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(238, 606);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(54, 15);
            this.guna2HtmlLabel7.TabIndex = 96;
            this.guna2HtmlLabel7.Text = "Class room";
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
            this.button_new.Location = new System.Drawing.Point(419, 655);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(51, 33);
            this.button_new.TabIndex = 97;
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
            this.button_edit.Location = new System.Drawing.Point(478, 655);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(82, 33);
            this.button_edit.TabIndex = 92;
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
            this.classnumDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn,
            this.classRoomDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.classBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(13, 151);
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
            this.guna2DataGridView1.TabIndex = 88;
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
            // classnumDataGridViewTextBoxColumn
            // 
            this.classnumDataGridViewTextBoxColumn.DataPropertyName = "Class_num";
            this.classnumDataGridViewTextBoxColumn.HeaderText = "Class num";
            this.classnumDataGridViewTextBoxColumn.Name = "classnumDataGridViewTextBoxColumn";
            this.classnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "Class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "Class name";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classRoomDataGridViewTextBoxColumn
            // 
            this.classRoomDataGridViewTextBoxColumn.DataPropertyName = "Class_Room";
            this.classRoomDataGridViewTextBoxColumn.HeaderText = "Class Room";
            this.classRoomDataGridViewTextBoxColumn.Name = "classRoomDataGridViewTextBoxColumn";
            this.classRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.school_managementDataSet2;
            // 
            // school_managementDataSet2
            // 
            this.school_managementDataSet2.DataSetName = "School_managementDataSet2";
            this.school_managementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button_remove.Location = new System.Drawing.Point(807, 96);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(82, 33);
            this.button_remove.TabIndex = 87;
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
            this.button_all.Location = new System.Drawing.Point(717, 96);
            this.button_all.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(82, 33);
            this.button_all.TabIndex = 86;
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
            this.textbox_search.Location = new System.Drawing.Point(13, 89);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.PasswordChar = '\0';
            this.textbox_search.PlaceholderText = "Search by name";
            this.textbox_search.SelectedText = "";
            this.textbox_search.Size = new System.Drawing.Size(233, 42);
            this.textbox_search.TabIndex = 83;
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
            this.button_add.Location = new System.Drawing.Point(329, 655);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 33);
            this.button_add.TabIndex = 91;
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
            this.guna2CircleButton2.Location = new System.Drawing.Point(847, 35);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton2.TabIndex = 89;
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(253, 89);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 40);
            this.guna2CircleButton1.TabIndex = 84;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // textbox_number
            // 
            this.textbox_number.AutoRoundedCorners = true;
            this.textbox_number.BorderRadius = 20;
            this.textbox_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_number.DefaultText = "";
            this.textbox_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_number.Location = new System.Drawing.Point(329, 496);
            this.textbox_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_number.Name = "textbox_number";
            this.textbox_number.PasswordChar = '\0';
            this.textbox_number.PlaceholderText = "";
            this.textbox_number.SelectedText = "";
            this.textbox_number.Size = new System.Drawing.Size(233, 42);
            this.textbox_number.TabIndex = 100;
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
            this.textbox_name.Location = new System.Drawing.Point(329, 544);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.PlaceholderText = "";
            this.textbox_name.SelectedText = "";
            this.textbox_name.Size = new System.Drawing.Size(233, 42);
            this.textbox_name.TabIndex = 101;
            // 
            // textbox_room
            // 
            this.textbox_room.AutoRoundedCorners = true;
            this.textbox_room.BorderRadius = 20;
            this.textbox_room.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_room.DefaultText = "";
            this.textbox_room.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_room.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_room.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_room.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_room.Location = new System.Drawing.Point(329, 592);
            this.textbox_room.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_room.Name = "textbox_room";
            this.textbox_room.PasswordChar = '\0';
            this.textbox_room.PlaceholderText = "";
            this.textbox_room.SelectedText = "";
            this.textbox_room.Size = new System.Drawing.Size(233, 42);
            this.textbox_room.TabIndex = 102;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 733);
            this.Controls.Add(this.textbox_room);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.textbox_number);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_managementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button button_new;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button button_remove;
        private Guna.UI2.WinForms.Guna2Button button_all;
        private Guna.UI2.WinForms.Guna2TextBox textbox_search;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_number;
        private Guna.UI2.WinForms.Guna2TextBox textbox_name;
        private Guna.UI2.WinForms.Guna2TextBox textbox_room;
        private School_managementDataSet2 school_managementDataSet2;
        private System.Windows.Forms.BindingSource classBindingSource;
        private School_managementDataSet2TableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classRoomDataGridViewTextBoxColumn;
    }
}