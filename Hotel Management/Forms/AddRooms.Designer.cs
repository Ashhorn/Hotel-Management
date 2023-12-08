namespace Hotel_Management.Forms
{
    partial class AddRooms
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
            this.Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtroomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtroomnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmedbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(84, 267);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(47, 21);
            this.Price.TabIndex = 19;
            this.Price.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room Number";
            // 
            // txtbed
            // 
            this.txtbed.BackColor = System.Drawing.Color.Transparent;
            this.txtbed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtbed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbed.ItemHeight = 30;
            this.txtbed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "VIP"});
            this.txtbed.Location = new System.Drawing.Point(88, 215);
            this.txtbed.Name = "txtbed";
            this.txtbed.Size = new System.Drawing.Size(281, 36);
            this.txtbed.TabIndex = 15;
            // 
            // txtroomtype
            // 
            this.txtroomtype.BackColor = System.Drawing.Color.Transparent;
            this.txtroomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtroomtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomtype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtroomtype.ItemHeight = 30;
            this.txtroomtype.Items.AddRange(new object[] {
            "AC",
            "Non-AC",
            "Donkey Kong"});
            this.txtroomtype.Location = new System.Drawing.Point(88, 142);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(281, 36);
            this.txtroomtype.TabIndex = 14;
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(88, 291);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(281, 36);
            this.txtprice.TabIndex = 13;
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomnumber.DefaultText = "";
            this.txtroomnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtroomnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtroomnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomnumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomnumber.Location = new System.Drawing.Point(88, 61);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.PasswordChar = '\0';
            this.txtroomnumber.PlaceholderText = "";
            this.txtroomnumber.SelectedText = "";
            this.txtroomnumber.Size = new System.Drawing.Size(281, 36);
            this.txtroomnumber.TabIndex = 12;
            // 
            // confirmedbtn
            // 
            this.confirmedbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmedbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmedbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmedbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmedbtn.FillColor = System.Drawing.Color.LightGray;
            this.confirmedbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.confirmedbtn.ForeColor = System.Drawing.Color.Black;
            this.confirmedbtn.Location = new System.Drawing.Point(136, 399);
            this.confirmedbtn.Name = "confirmedbtn";
            this.confirmedbtn.Size = new System.Drawing.Size(180, 45);
            this.confirmedbtn.TabIndex = 10;
            this.confirmedbtn.Text = "Confirm";
            this.confirmedbtn.Click += new System.EventHandler(this.confirmedbtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(394, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 46);
            this.guna2ControlBox1.TabIndex = 60;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(154, 363);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 62;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(154, 336);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 61;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Booked:";
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbed);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtroomnumber);
            this.Controls.Add(this.confirmedbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRooms";
            this.Text = "AddRooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtbed;
        private Guna.UI2.WinForms.Guna2ComboBox txtroomtype;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2TextBox txtroomnumber;
        private Guna.UI2.WinForms.Guna2Button confirmedbtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}