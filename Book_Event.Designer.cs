
namespace Event_Management_System
{
    partial class Book_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Event));
            this.label1 = new System.Windows.Forms.Label();
            this.eventdetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.refreshgridbutton = new System.Windows.Forms.Button();
            this.choicepagebutton = new System.Windows.Forms.Button();
            this.bookeventbutton = new System.Windows.Forms.Button();
            this.gotologinbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventdetailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book  Event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eventdetailsdataGridView
            // 
            this.eventdetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdetailsdataGridView.Location = new System.Drawing.Point(12, 72);
            this.eventdetailsdataGridView.Name = "eventdetailsdataGridView";
            this.eventdetailsdataGridView.RowHeadersWidth = 51;
            this.eventdetailsdataGridView.RowTemplate.Height = 24;
            this.eventdetailsdataGridView.Size = new System.Drawing.Size(554, 371);
            this.eventdetailsdataGridView.TabIndex = 34;
            this.eventdetailsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventdetailsdataGridView_CellContentClick);
            // 
            // refreshgridbutton
            // 
            this.refreshgridbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.refreshgridbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshgridbutton.ForeColor = System.Drawing.Color.Black;
            this.refreshgridbutton.Location = new System.Drawing.Point(607, 72);
            this.refreshgridbutton.Name = "refreshgridbutton";
            this.refreshgridbutton.Size = new System.Drawing.Size(154, 48);
            this.refreshgridbutton.TabIndex = 42;
            this.refreshgridbutton.Text = "Refresh";
            this.refreshgridbutton.UseVisualStyleBackColor = false;
            this.refreshgridbutton.Click += new System.EventHandler(this.refreshgridbutton_Click);
            // 
            // choicepagebutton
            // 
            this.choicepagebutton.BackColor = System.Drawing.Color.Cornsilk;
            this.choicepagebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicepagebutton.ForeColor = System.Drawing.Color.Black;
            this.choicepagebutton.Location = new System.Drawing.Point(607, 395);
            this.choicepagebutton.Name = "choicepagebutton";
            this.choicepagebutton.Size = new System.Drawing.Size(154, 48);
            this.choicepagebutton.TabIndex = 43;
            this.choicepagebutton.Text = "Choice Page";
            this.choicepagebutton.UseVisualStyleBackColor = false;
            this.choicepagebutton.Click += new System.EventHandler(this.choicepagebutton_Click);
            // 
            // bookeventbutton
            // 
            this.bookeventbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.bookeventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookeventbutton.ForeColor = System.Drawing.Color.Black;
            this.bookeventbutton.Location = new System.Drawing.Point(607, 182);
            this.bookeventbutton.Name = "bookeventbutton";
            this.bookeventbutton.Size = new System.Drawing.Size(154, 48);
            this.bookeventbutton.TabIndex = 44;
            this.bookeventbutton.Text = "Book";
            this.bookeventbutton.UseVisualStyleBackColor = false;
            this.bookeventbutton.Click += new System.EventHandler(this.bookeventbutton_Click);
            // 
            // gotologinbutton
            // 
            this.gotologinbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.gotologinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotologinbutton.ForeColor = System.Drawing.Color.Black;
            this.gotologinbutton.Location = new System.Drawing.Point(607, 298);
            this.gotologinbutton.Name = "gotologinbutton";
            this.gotologinbutton.Size = new System.Drawing.Size(154, 48);
            this.gotologinbutton.TabIndex = 45;
            this.gotologinbutton.Text = "LogIn";
            this.gotologinbutton.UseVisualStyleBackColor = false;
            this.gotologinbutton.Click += new System.EventHandler(this.gotologinbutton_Click);
            // 
            // Book_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.gotologinbutton);
            this.Controls.Add(this.bookeventbutton);
            this.Controls.Add(this.choicepagebutton);
            this.Controls.Add(this.refreshgridbutton);
            this.Controls.Add(this.eventdetailsdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Book_Event";
            this.Text = "Book_Event";
            ((System.ComponentModel.ISupportInitialize)(this.eventdetailsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView eventdetailsdataGridView;
        private System.Windows.Forms.Button refreshgridbutton;
        private System.Windows.Forms.Button choicepagebutton;
        private System.Windows.Forms.Button bookeventbutton;
        private System.Windows.Forms.Button gotologinbutton;
    }
}