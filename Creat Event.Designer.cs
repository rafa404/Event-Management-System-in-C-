
namespace Event_Management_System
{
    partial class Creat_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creat_Event));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventtypecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventnametextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.eventvenuetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchgridbutton = new System.Windows.Forms.Button();
            this.searchgridtextBox = new System.Windows.Forms.TextBox();
            this.deletedatabutton = new System.Windows.Forms.Button();
            this.savedatabutton = new System.Windows.Forms.Button();
            this.backtologinbutton = new System.Windows.Forms.Button();
            this.adresstextBox = new System.Windows.Forms.TextBox();
            this.refreshgridbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create  Event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Type";
            // 
            // eventtypecomboBox
            // 
            this.eventtypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventtypecomboBox.FormattingEnabled = true;
            this.eventtypecomboBox.Location = new System.Drawing.Point(211, 82);
            this.eventtypecomboBox.Name = "eventtypecomboBox";
            this.eventtypecomboBox.Size = new System.Drawing.Size(180, 33);
            this.eventtypecomboBox.TabIndex = 24;
            this.eventtypecomboBox.Text = "Choose Event";
            this.eventtypecomboBox.SelectedIndexChanged += new System.EventHandler(this.eventtypecomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Event Name";
            // 
            // eventnametextbox
            // 
            this.eventnametextbox.BackColor = System.Drawing.SystemColors.Window;
            this.eventnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventnametextbox.Location = new System.Drawing.Point(211, 131);
            this.eventnametextbox.Multiline = true;
            this.eventnametextbox.Name = "eventnametextbox";
            this.eventnametextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventnametextbox.Size = new System.Drawing.Size(180, 38);
            this.eventnametextbox.TabIndex = 26;
            this.eventnametextbox.TextChanged += new System.EventHandler(this.eventnametextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "Event Date";
            // 
            // eventdateTimePicker
            // 
            this.eventdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventdateTimePicker.Checked = false;
            this.eventdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventdateTimePicker.Location = new System.Drawing.Point(211, 191);
            this.eventdateTimePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.eventdateTimePicker.MinDate = new System.DateTime(2024, 5, 15, 0, 0, 0, 0);
            this.eventdateTimePicker.Name = "eventdateTimePicker";
            this.eventdateTimePicker.Size = new System.Drawing.Size(180, 30);
            this.eventdateTimePicker.TabIndex = 28;
            this.eventdateTimePicker.Value = new System.DateTime(2024, 5, 15, 0, 0, 0, 0);
            this.eventdateTimePicker.ValueChanged += new System.EventHandler(this.eventdateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "Venue";
            // 
            // eventvenuetextBox
            // 
            this.eventvenuetextBox.BackColor = System.Drawing.SystemColors.Window;
            this.eventvenuetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventvenuetextBox.Location = new System.Drawing.Point(213, 246);
            this.eventvenuetextBox.Multiline = true;
            this.eventvenuetextBox.Name = "eventvenuetextBox";
            this.eventvenuetextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventvenuetextBox.Size = new System.Drawing.Size(178, 38);
            this.eventvenuetextBox.TabIndex = 30;
            this.eventvenuetextBox.TextChanged += new System.EventHandler(this.eventvenuetextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 38);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adress";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 333);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchgridbutton
            // 
            this.searchgridbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.searchgridbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgridbutton.ForeColor = System.Drawing.Color.Black;
            this.searchgridbutton.Location = new System.Drawing.Point(627, 82);
            this.searchgridbutton.Name = "searchgridbutton";
            this.searchgridbutton.Size = new System.Drawing.Size(154, 48);
            this.searchgridbutton.TabIndex = 35;
            this.searchgridbutton.Text = "Search";
            this.searchgridbutton.UseVisualStyleBackColor = false;
            this.searchgridbutton.Click += new System.EventHandler(this.searchgridbutton_Click);
            // 
            // searchgridtextBox
            // 
            this.searchgridtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchgridtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgridtextBox.Location = new System.Drawing.Point(428, 82);
            this.searchgridtextBox.Multiline = true;
            this.searchgridtextBox.Name = "searchgridtextBox";
            this.searchgridtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchgridtextBox.Size = new System.Drawing.Size(193, 48);
            this.searchgridtextBox.TabIndex = 36;
            this.searchgridtextBox.TextChanged += new System.EventHandler(this.searchgridtextBox_TextChanged);
            // 
            // deletedatabutton
            // 
            this.deletedatabutton.BackColor = System.Drawing.Color.Cornsilk;
            this.deletedatabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedatabutton.ForeColor = System.Drawing.Color.Black;
            this.deletedatabutton.Location = new System.Drawing.Point(23, 421);
            this.deletedatabutton.Name = "deletedatabutton";
            this.deletedatabutton.Size = new System.Drawing.Size(154, 48);
            this.deletedatabutton.TabIndex = 37;
            this.deletedatabutton.Text = "Delete";
            this.deletedatabutton.UseVisualStyleBackColor = false;
            this.deletedatabutton.Click += new System.EventHandler(this.deletedatabutton_Click);
            // 
            // savedatabutton
            // 
            this.savedatabutton.BackColor = System.Drawing.Color.Cornsilk;
            this.savedatabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedatabutton.ForeColor = System.Drawing.Color.Black;
            this.savedatabutton.Location = new System.Drawing.Point(213, 421);
            this.savedatabutton.Name = "savedatabutton";
            this.savedatabutton.Size = new System.Drawing.Size(154, 48);
            this.savedatabutton.TabIndex = 38;
            this.savedatabutton.Text = "Save";
            this.savedatabutton.UseVisualStyleBackColor = false;
            this.savedatabutton.Click += new System.EventHandler(this.savedatabutton_Click);
            // 
            // backtologinbutton
            // 
            this.backtologinbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.backtologinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtologinbutton.ForeColor = System.Drawing.Color.Black;
            this.backtologinbutton.Location = new System.Drawing.Point(23, 358);
            this.backtologinbutton.Name = "backtologinbutton";
            this.backtologinbutton.Size = new System.Drawing.Size(154, 48);
            this.backtologinbutton.TabIndex = 39;
            this.backtologinbutton.Text = " Login Page";
            this.backtologinbutton.UseVisualStyleBackColor = false;
            this.backtologinbutton.Click += new System.EventHandler(this.backtologinbutton_Click);
            // 
            // adresstextBox
            // 
            this.adresstextBox.BackColor = System.Drawing.SystemColors.Window;
            this.adresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresstextBox.Location = new System.Drawing.Point(213, 310);
            this.adresstextBox.Multiline = true;
            this.adresstextBox.Name = "adresstextBox";
            this.adresstextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adresstextBox.Size = new System.Drawing.Size(178, 36);
            this.adresstextBox.TabIndex = 40;
            this.adresstextBox.TextChanged += new System.EventHandler(this.adresstextBox_TextChanged);
            // 
            // refreshgridbutton
            // 
            this.refreshgridbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.refreshgridbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshgridbutton.ForeColor = System.Drawing.Color.Black;
            this.refreshgridbutton.Location = new System.Drawing.Point(213, 358);
            this.refreshgridbutton.Name = "refreshgridbutton";
            this.refreshgridbutton.Size = new System.Drawing.Size(154, 48);
            this.refreshgridbutton.TabIndex = 41;
            this.refreshgridbutton.Text = "Refresh";
            this.refreshgridbutton.UseVisualStyleBackColor = false;
            this.refreshgridbutton.Click += new System.EventHandler(this.refreshgridbutton_Click_1);
            // 
            // Creat_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.refreshgridbutton);
            this.Controls.Add(this.adresstextBox);
            this.Controls.Add(this.backtologinbutton);
            this.Controls.Add(this.savedatabutton);
            this.Controls.Add(this.deletedatabutton);
            this.Controls.Add(this.searchgridtextBox);
            this.Controls.Add(this.searchgridbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventvenuetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eventdateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventnametextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventtypecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Creat_Event";
            this.Text = "Creat_Event";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eventtypecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventnametextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker eventdateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventvenuetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchgridbutton;
        private System.Windows.Forms.TextBox searchgridtextBox;
        private System.Windows.Forms.Button deletedatabutton;
        private System.Windows.Forms.Button savedatabutton;
        private System.Windows.Forms.Button backtologinbutton;
        private System.Windows.Forms.TextBox adresstextBox;
        private System.Windows.Forms.Button refreshgridbutton;
    }
}