
namespace Event_Management_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.adresstextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmpasstextBox = new System.Windows.Forms.TextBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.signinlinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(90, 155);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(240, 35);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(276, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(90, 240);
            this.emailtextBox.Multiline = true;
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(240, 35);
            this.emailtextBox.TabIndex = 5;
            this.emailtextBox.TextChanged += new System.EventHandler(this.emailtextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 324);
            this.dateTimePicker1.MaxDate = new System.DateTime(2006, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 30);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2006, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Location = new System.Drawing.Point(89, 393);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(241, 28);
            this.comboBoxgender.TabIndex = 9;
            this.comboBoxgender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // adresstextBox
            // 
            this.adresstextBox.Location = new System.Drawing.Point(493, 155);
            this.adresstextBox.Multiline = true;
            this.adresstextBox.Name = "adresstextBox";
            this.adresstextBox.Size = new System.Drawing.Size(240, 35);
            this.adresstextBox.TabIndex = 10;
            this.adresstextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adress";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(488, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Passoword";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(493, 240);
            this.passtextBox.Multiline = true;
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(240, 35);
            this.passtextBox.TabIndex = 13;
            this.passtextBox.TextChanged += new System.EventHandler(this.passtextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confirm Password";
            // 
            // confirmpasstextBox
            // 
            this.confirmpasstextBox.Location = new System.Drawing.Point(493, 324);
            this.confirmpasstextBox.Multiline = true;
            this.confirmpasstextBox.Name = "confirmpasstextBox";
            this.confirmpasstextBox.Size = new System.Drawing.Size(240, 35);
            this.confirmpasstextBox.TabIndex = 15;
            this.confirmpasstextBox.TextChanged += new System.EventHandler(this.confirmpasstextBox_TextChanged);
            // 
            // signupbutton
            // 
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.Black;
            this.signupbutton.Location = new System.Drawing.Point(566, 431);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(154, 48);
            this.signupbutton.TabIndex = 16;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // signinlinkLabel
            // 
            this.signinlinkLabel.AutoSize = true;
            this.signinlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.signinlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlinkLabel.LinkColor = System.Drawing.Color.Black;
            this.signinlinkLabel.Location = new System.Drawing.Point(464, 450);
            this.signinlinkLabel.Name = "signinlinkLabel";
            this.signinlinkLabel.Size = new System.Drawing.Size(87, 29);
            this.signinlinkLabel.TabIndex = 17;
            this.signinlinkLabel.TabStop = true;
            this.signinlinkLabel.Text = "Sign In";
            this.signinlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 535);
            this.Controls.Add(this.signinlinkLabel);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.confirmpasstextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresstextBox);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NametextBox);
            this.Name = "Registration";
            this.Text = "Event Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.TextBox adresstextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmpasstextBox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.LinkLabel signinlinkLabel;
    }
}

