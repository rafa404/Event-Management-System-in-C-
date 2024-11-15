
namespace Event_Management_System
{
    partial class Thank_You_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thank_You_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.closeprogrambuttonbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(195, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thank You";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeprogrambuttonbutton
            // 
            this.closeprogrambuttonbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.closeprogrambuttonbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeprogrambuttonbutton.ForeColor = System.Drawing.Color.Black;
            this.closeprogrambuttonbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeprogrambuttonbutton.Location = new System.Drawing.Point(252, 312);
            this.closeprogrambuttonbutton.Name = "closeprogrambuttonbutton";
            this.closeprogrambuttonbutton.Size = new System.Drawing.Size(265, 94);
            this.closeprogrambuttonbutton.TabIndex = 43;
            this.closeprogrambuttonbutton.Text = "Close Program";
            this.closeprogrambuttonbutton.UseVisualStyleBackColor = false;
            this.closeprogrambuttonbutton.Click += new System.EventHandler(this.closeprogrambuttonbutton_Click);
            // 
            // Thank_You_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.closeprogrambuttonbutton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Thank_You_Page";
            this.Text = "Thank_You_Page";
            this.Load += new System.EventHandler(this.Thank_You_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeprogrambuttonbutton;
    }
}