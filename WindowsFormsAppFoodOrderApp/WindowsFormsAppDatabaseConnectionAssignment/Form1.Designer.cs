namespace WindowsFormsAppDatabaseConnectionAssignment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbcontact_number = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.check_connection = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(298, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(116, 106);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(87, 15);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "First Name";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(116, 164);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(79, 15);
            this.lbaddress.TabIndex = 3;
            this.lbaddress.Text = "Last Name";
            // 
            // lbcontact_number
            // 
            this.lbcontact_number.AutoSize = true;
            this.lbcontact_number.Location = new System.Drawing.Point(108, 217);
            this.lbcontact_number.Name = "lbcontact_number";
            this.lbcontact_number.Size = new System.Drawing.Size(111, 15);
            this.lbcontact_number.TabIndex = 4;
            this.lbcontact_number.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(322, 106);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(100, 25);
            this.first_name.TabIndex = 8;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(322, 161);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(100, 25);
            this.last_name.TabIndex = 9;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(322, 301);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 25);
            this.phone.TabIndex = 11;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(322, 356);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 25);
            this.password.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(478, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(50, 457);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add New";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(201, 457);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(361, 457);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // check_connection
            // 
            this.check_connection.Location = new System.Drawing.Point(625, 488);
            this.check_connection.Name = "check_connection";
            this.check_connection.Size = new System.Drawing.Size(205, 23);
            this.check_connection.TabIndex = 16;
            this.check_connection.Text = "Check Connection";
            this.check_connection.UseVisualStyleBackColor = true;
            this.check_connection.Click += new System.EventHandler(this.Check_connection_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(322, 214);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 25);
            this.email.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Email Address";
            // 
            // confirm_email
            // 
            this.confirm_email.Location = new System.Drawing.Point(322, 260);
            this.confirm_email.Name = "confirm_email";
            this.confirm_email.Size = new System.Drawing.Size(100, 25);
            this.confirm_email.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Confirm Password";
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(322, 406);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(100, 25);
            this.confirm_password.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 538);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirm_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.check_connection);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbcontact_number);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbcontact_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button check_connection;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirm_password;
    }
}

