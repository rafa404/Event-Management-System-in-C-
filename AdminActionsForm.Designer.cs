
namespace Event_Management_System
{
    partial class AdminActionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminActionsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datasearchtextBox = new System.Windows.Forms.TextBox();
            this.updateinfobutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.loginpagebackbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datasearchtextBox
            // 
            this.datasearchtextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.datasearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasearchtextBox.Location = new System.Drawing.Point(12, 15);
            this.datasearchtextBox.Name = "datasearchtextBox";
            this.datasearchtextBox.Size = new System.Drawing.Size(234, 41);
            this.datasearchtextBox.TabIndex = 1;
            this.datasearchtextBox.TextChanged += new System.EventHandler(this.datasearchtextBox_TextChanged);
            // 
            // updateinfobutton
            // 
            this.updateinfobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfobutton.ForeColor = System.Drawing.Color.Black;
            this.updateinfobutton.Location = new System.Drawing.Point(441, 8);
            this.updateinfobutton.Name = "updateinfobutton";
            this.updateinfobutton.Size = new System.Drawing.Size(154, 48);
            this.updateinfobutton.TabIndex = 18;
            this.updateinfobutton.Text = "Update";
            this.updateinfobutton.UseVisualStyleBackColor = true;
            this.updateinfobutton.Click += new System.EventHandler(this.updateinfobutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.Black;
            this.searchbutton.Location = new System.Drawing.Point(267, 8);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(154, 48);
            this.searchbutton.TabIndex = 20;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Black;
            this.deletebutton.Location = new System.Drawing.Point(613, 8);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(154, 48);
            this.deletebutton.TabIndex = 21;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // loginpagebackbutton
            // 
            this.loginpagebackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpagebackbutton.ForeColor = System.Drawing.Color.Black;
            this.loginpagebackbutton.Location = new System.Drawing.Point(320, 435);
            this.loginpagebackbutton.Name = "loginpagebackbutton";
            this.loginpagebackbutton.Size = new System.Drawing.Size(148, 44);
            this.loginpagebackbutton.TabIndex = 22;
            this.loginpagebackbutton.Text = "Return";
            this.loginpagebackbutton.UseVisualStyleBackColor = true;
            this.loginpagebackbutton.Click += new System.EventHandler(this.loginpagebackbutton_Click);
            // 
            // AdminActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.loginpagebackbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.updateinfobutton);
            this.Controls.Add(this.datasearchtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminActionsForm";
            this.Text = "AdminActionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox datasearchtextBox;
        private System.Windows.Forms.Button updateinfobutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button loginpagebackbutton;
    }
}