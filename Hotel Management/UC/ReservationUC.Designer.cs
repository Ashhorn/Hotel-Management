namespace Hotel_Management.UC
{
    partial class ReservationUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClientIdSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageUpdateCancel = new System.Windows.Forms.TabPage();
            this.buttonCancelR = new System.Windows.Forms.Button();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomNo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxClientId1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateR = new System.Windows.Forms.Button();
            this.gridview1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            this.tabPageUpdateCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateCancel);
            this.tabControlReservation.Location = new System.Drawing.Point(77, 69);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(954, 410);
            this.tabControlReservation.TabIndex = 1;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.label6);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomNo);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomType);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientId);
            this.tabPageAddReservation.Controls.Add(this.buttonAddUser);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(946, 384);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(522, 240);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerOut.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Out:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(162, 240);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerIn.TabIndex = 40;
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Items.AddRange(new object[] {
            "Please Select..."});
            this.comboBoxRoomNo.Location = new System.Drawing.Point(522, 86);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(260, 21);
            this.comboBoxRoomNo.TabIndex = 39;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Please Select....",
            "Single",
            "Double",
            "Triple",
            "VIP"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(162, 86);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(260, 21);
            this.comboBoxRoomType.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Room No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add Reservation:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(162, 158);
            this.textBoxClientId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(260, 20);
            this.textBoxClientId.TabIndex = 36;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(162, 292);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(103, 33);
            this.buttonAddUser.TabIndex = 34;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.gridview1);
            this.tabPageSearchReservation.Controls.Add(this.label9);
            this.tabPageSearchReservation.Controls.Add(this.textBoxClientIdSearch);
            this.tabPageSearchReservation.Controls.Add(this.label7);
            this.tabPageSearchReservation.Controls.Add(this.label8);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(946, 384);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Search Reservation";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(34, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Refresh / Show All";
            // 
            // textBoxClientIdSearch
            // 
            this.textBoxClientIdSearch.Location = new System.Drawing.Point(204, 60);
            this.textBoxClientIdSearch.Name = "textBoxClientIdSearch";
            this.textBoxClientIdSearch.Size = new System.Drawing.Size(240, 20);
            this.textBoxClientIdSearch.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Client ID:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Search Reservation:";
            // 
            // tabPageUpdateCancel
            // 
            this.tabPageUpdateCancel.Controls.Add(this.buttonCancelR);
            this.tabPageUpdateCancel.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateCancel.Controls.Add(this.label10);
            this.tabPageUpdateCancel.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateCancel.Controls.Add(this.comboBoxRoomNo1);
            this.tabPageUpdateCancel.Controls.Add(this.comboBoxRoomType1);
            this.tabPageUpdateCancel.Controls.Add(this.label11);
            this.tabPageUpdateCancel.Controls.Add(this.label12);
            this.tabPageUpdateCancel.Controls.Add(this.label13);
            this.tabPageUpdateCancel.Controls.Add(this.label14);
            this.tabPageUpdateCancel.Controls.Add(this.label15);
            this.tabPageUpdateCancel.Controls.Add(this.textBoxClientId1);
            this.tabPageUpdateCancel.Controls.Add(this.buttonUpdateR);
            this.tabPageUpdateCancel.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateCancel.Name = "tabPageUpdateCancel";
            this.tabPageUpdateCancel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateCancel.Size = new System.Drawing.Size(946, 384);
            this.tabPageUpdateCancel.TabIndex = 2;
            this.tabPageUpdateCancel.Text = "Update and Cancel Reservation";
            this.tabPageUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCancelR
            // 
            this.buttonCancelR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonCancelR.FlatAppearance.BorderSize = 0;
            this.buttonCancelR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelR.ForeColor = System.Drawing.Color.White;
            this.buttonCancelR.Location = new System.Drawing.Point(311, 292);
            this.buttonCancelR.Name = "buttonCancelR";
            this.buttonCancelR.Size = new System.Drawing.Size(111, 39);
            this.buttonCancelR.TabIndex = 55;
            this.buttonCancelR.Text = "Cancel";
            this.buttonCancelR.UseVisualStyleBackColor = false;
            this.buttonCancelR.Click += new System.EventHandler(this.buttonCancelR_Click);
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Location = new System.Drawing.Point(522, 240);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerOut1.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Out:";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Location = new System.Drawing.Point(162, 240);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerIn1.TabIndex = 52;
            // 
            // comboBoxRoomNo1
            // 
            this.comboBoxRoomNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomNo1.FormattingEnabled = true;
            this.comboBoxRoomNo1.Items.AddRange(new object[] {
            "Please Select...."});
            this.comboBoxRoomNo1.Location = new System.Drawing.Point(522, 86);
            this.comboBoxRoomNo1.Name = "comboBoxRoomNo1";
            this.comboBoxRoomNo1.Size = new System.Drawing.Size(260, 21);
            this.comboBoxRoomNo1.TabIndex = 51;
            // 
            // comboBoxRoomType1
            // 
            this.comboBoxRoomType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType1.FormattingEnabled = true;
            this.comboBoxRoomType1.Items.AddRange(new object[] {
            "Please Select....",
            "Single",
            "Double",
            "Triple",
            "VIP"});
            this.comboBoxRoomType1.Location = new System.Drawing.Point(162, 86);
            this.comboBoxRoomType1.Name = "comboBoxRoomType1";
            this.comboBoxRoomType1.Size = new System.Drawing.Size(260, 21);
            this.comboBoxRoomType1.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "In:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(159, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Client ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(519, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Room No.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(159, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Room Type:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label15.Location = new System.Drawing.Point(15, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "Update and Cancel Reservation:";
            // 
            // textBoxClientId1
            // 
            this.textBoxClientId1.Location = new System.Drawing.Point(162, 158);
            this.textBoxClientId1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxClientId1.Name = "textBoxClientId1";
            this.textBoxClientId1.Size = new System.Drawing.Size(260, 20);
            this.textBoxClientId1.TabIndex = 48;
            // 
            // buttonUpdateR
            // 
            this.buttonUpdateR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdateR.FlatAppearance.BorderSize = 0;
            this.buttonUpdateR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateR.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateR.Location = new System.Drawing.Point(162, 292);
            this.buttonUpdateR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdateR.Name = "buttonUpdateR";
            this.buttonUpdateR.Size = new System.Drawing.Size(103, 39);
            this.buttonUpdateR.TabIndex = 46;
            this.buttonUpdateR.Text = "Update";
            this.buttonUpdateR.UseVisualStyleBackColor = false;
            this.buttonUpdateR.Click += new System.EventHandler(this.buttonUpdateR_Click);
            // 
            // gridview1
            // 
            this.gridview1.AllowUserToAddRows = false;
            this.gridview1.AllowUserToDeleteRows = false;
            this.gridview1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview1.Location = new System.Drawing.Point(37, 106);
            this.gridview1.Name = "gridview1";
            this.gridview1.ReadOnly = true;
            this.gridview1.RowHeadersVisible = false;
            this.gridview1.Size = new System.Drawing.Size(840, 212);
            this.gridview1.TabIndex = 31;
            this.gridview1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview1.ThemeStyle.HeaderStyle.Height = 4;
            this.gridview1.ThemeStyle.ReadOnly = true;
            this.gridview1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview1.ThemeStyle.RowsStyle.Height = 22;
            this.gridview1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ReservationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlReservation);
            this.Name = "ReservationUC";
            this.Size = new System.Drawing.Size(1159, 608);
            this.Load += new System.EventHandler(this.ReservationUC_Load);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            this.tabPageUpdateCancel.ResumeLayout(false);
            this.tabPageUpdateCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClientIdSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageUpdateCancel;
        private System.Windows.Forms.Button buttonCancelR;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxRoomNo1;
        private System.Windows.Forms.ComboBox comboBoxRoomType1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxClientId1;
        private System.Windows.Forms.Button buttonUpdateR;
        private Guna.UI2.WinForms.Guna2DataGridView gridview1;
    }
}
