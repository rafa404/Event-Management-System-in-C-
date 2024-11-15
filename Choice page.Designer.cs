
namespace Event_Management_System
{
    partial class Choice_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_page));
            this.label1 = new System.Windows.Forms.Label();
            this.volunteerbutton = new System.Windows.Forms.Button();
            this.bookeventbutton = new System.Windows.Forms.Button();
            this.editprofilebutton = new System.Windows.Forms.Button();
            this.closeprogrambutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Your Personal Hub";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // volunteerbutton
            // 
            this.volunteerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volunteerbutton.ForeColor = System.Drawing.Color.Black;
            this.volunteerbutton.Location = new System.Drawing.Point(214, 228);
            this.volunteerbutton.Name = "volunteerbutton";
            this.volunteerbutton.Size = new System.Drawing.Size(332, 48);
            this.volunteerbutton.TabIndex = 19;
            this.volunteerbutton.Text = "Be A Volunteer";
            this.volunteerbutton.UseVisualStyleBackColor = true;
            this.volunteerbutton.Click += new System.EventHandler(this.volunteerbutton_Click);
            // 
            // bookeventbutton
            // 
            this.bookeventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookeventbutton.ForeColor = System.Drawing.Color.Black;
            this.bookeventbutton.Location = new System.Drawing.Point(214, 153);
            this.bookeventbutton.Name = "bookeventbutton";
            this.bookeventbutton.Size = new System.Drawing.Size(332, 48);
            this.bookeventbutton.TabIndex = 18;
            this.bookeventbutton.Text = "Book Events";
            this.bookeventbutton.UseVisualStyleBackColor = true;
            this.bookeventbutton.Click += new System.EventHandler(this.bookeventbutton_Click);
            // 
            // editprofilebutton
            // 
            this.editprofilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprofilebutton.ForeColor = System.Drawing.Color.Black;
            this.editprofilebutton.Location = new System.Drawing.Point(214, 301);
            this.editprofilebutton.Name = "editprofilebutton";
            this.editprofilebutton.Size = new System.Drawing.Size(332, 48);
            this.editprofilebutton.TabIndex = 20;
            this.editprofilebutton.Text = "Edit Your Profile";
            this.editprofilebutton.UseVisualStyleBackColor = true;
            this.editprofilebutton.Click += new System.EventHandler(this.editprofilebutton_Click);
            // 
            // closeprogrambutton
            // 
            this.closeprogrambutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeprogrambutton.ForeColor = System.Drawing.Color.Black;
            this.closeprogrambutton.Location = new System.Drawing.Point(552, 409);
            this.closeprogrambutton.Name = "closeprogrambutton";
            this.closeprogrambutton.Size = new System.Drawing.Size(154, 48);
            this.closeprogrambutton.TabIndex = 21;
            this.closeprogrambutton.Text = "Close";
            this.closeprogrambutton.UseVisualStyleBackColor = true;
            this.closeprogrambutton.Click += new System.EventHandler(this.closeprogrambutton_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 38);
            this.label9.TabIndex = 22;
            this.label9.Text = "Close App?";
            // 
            // Choice_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.closeprogrambutton);
            this.Controls.Add(this.editprofilebutton);
            this.Controls.Add(this.volunteerbutton);
            this.Controls.Add(this.bookeventbutton);
            this.Controls.Add(this.label1);
            this.Name = "Choice_page";
            this.Text = "Choice_page";
            this.Load += new System.EventHandler(this.Choice_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volunteerbutton;
        private System.Windows.Forms.Button bookeventbutton;
        private System.Windows.Forms.Button editprofilebutton;
        private System.Windows.Forms.Button closeprogrambutton;
        private System.Windows.Forms.Label label9;
    }
}