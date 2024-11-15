
namespace Event_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showpasscheckBox = new System.Windows.Forms.CheckBox();
            this.signinbutton = new System.Windows.Forms.Button();
            this.signuplinkLabel = new System.Windows.Forms.LinkLabel();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(310, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(247, 177);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nametextbox.Size = new System.Drawing.Size(260, 38);
            this.nametextbox.TabIndex = 5;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // showpasscheckBox
            // 
            this.showpasscheckBox.AutoSize = true;
            this.showpasscheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showpasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasscheckBox.Location = new System.Drawing.Point(523, 296);
            this.showpasscheckBox.Name = "showpasscheckBox";
            this.showpasscheckBox.Size = new System.Drawing.Size(109, 24);
            this.showpasscheckBox.TabIndex = 8;
            this.showpasscheckBox.Text = "Hide Pass";
            this.showpasscheckBox.UseVisualStyleBackColor = false;
            this.showpasscheckBox.CheckedChanged += new System.EventHandler(this.showpasscheckBox_CheckedChanged);
            // 
            // signinbutton
            // 
            this.signinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.Color.Black;
            this.signinbutton.Location = new System.Drawing.Point(353, 339);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(154, 48);
            this.signinbutton.TabIndex = 17;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.UseVisualStyleBackColor = true;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // signuplinkLabel
            // 
            this.signuplinkLabel.AutoSize = true;
            this.signuplinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.signuplinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplinkLabel.LinkColor = System.Drawing.Color.Black;
            this.signuplinkLabel.Location = new System.Drawing.Point(248, 358);
            this.signuplinkLabel.Name = "signuplinkLabel";
            this.signuplinkLabel.Size = new System.Drawing.Size(99, 29);
            this.signuplinkLabel.TabIndex = 18;
            this.signuplinkLabel.TabStop = true;
            this.signuplinkLabel.Text = "Sign Up";
            this.signuplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signuplinkLabel_LinkClicked);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(247, 283);
            this.passwordtextBox.Multiline = true;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(260, 37);
            this.passwordtextBox.TabIndex = 19;
            this.passwordtextBox.UseSystemPasswordChar = true;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.signuplinkLabel);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.showpasscheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showpasscheckBox;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.LinkLabel signuplinkLabel;
        private System.Windows.Forms.TextBox passwordtextBox;
    }
}