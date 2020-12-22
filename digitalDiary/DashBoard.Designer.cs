
namespace digitalDiary
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createEventButton = new System.Windows.Forms.Button();
            this.highDataGridView = new System.Windows.Forms.DataGridView();
            this.moderateDataGridView = new System.Windows.Forms.DataGridView();
            this.lessDataGridView = new System.Windows.Forms.DataGridView();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.eventLebel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Location = new System.Drawing.Point(-13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 89);
            this.panel1.TabIndex = 0;
            // 
            // profileButton
            // 
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.Location = new System.Drawing.Point(705, 31);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(117, 34);
            this.profileButton.TabIndex = 2;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(845, 31);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(117, 34);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(50, 31);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 29);
            this.welcomeLabel.TabIndex = 0;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.ForeColor = System.Drawing.Color.White;
            this.createEventButton.Location = new System.Drawing.Point(692, 98);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(257, 54);
            this.createEventButton.TabIndex = 3;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // highDataGridView
            // 
            this.highDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highDataGridView.Location = new System.Drawing.Point(12, 164);
            this.highDataGridView.Name = "highDataGridView";
            this.highDataGridView.RowHeadersWidth = 51;
            this.highDataGridView.RowTemplate.Height = 24;
            this.highDataGridView.Size = new System.Drawing.Size(432, 128);
            this.highDataGridView.TabIndex = 4;
            // 
            // moderateDataGridView
            // 
            this.moderateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moderateDataGridView.Location = new System.Drawing.Point(12, 298);
            this.moderateDataGridView.Name = "moderateDataGridView";
            this.moderateDataGridView.RowHeadersWidth = 51;
            this.moderateDataGridView.RowTemplate.Height = 24;
            this.moderateDataGridView.Size = new System.Drawing.Size(432, 126);
            this.moderateDataGridView.TabIndex = 5;
            // 
            // lessDataGridView
            // 
            this.lessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessDataGridView.Location = new System.Drawing.Point(12, 431);
            this.lessDataGridView.Name = "lessDataGridView";
            this.lessDataGridView.RowHeadersWidth = 51;
            this.lessDataGridView.RowTemplate.Height = 24;
            this.lessDataGridView.Size = new System.Drawing.Size(432, 110);
            this.lessDataGridView.TabIndex = 6;
            // 
            // updateEventButton
            // 
            this.updateEventButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventButton.ForeColor = System.Drawing.Color.White;
            this.updateEventButton.Location = new System.Drawing.Point(692, 274);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(257, 54);
            this.updateEventButton.TabIndex = 7;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = false;
            // 
            // eventLebel
            // 
            this.eventLebel.AutoSize = true;
            this.eventLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLebel.Location = new System.Drawing.Point(7, 111);
            this.eventLebel.Name = "eventLebel";
            this.eventLebel.Size = new System.Drawing.Size(83, 25);
            this.eventLebel.TabIndex = 8;
            this.eventLebel.Text = "Events :";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.eventLebel);
            this.Controls.Add(this.updateEventButton);
            this.Controls.Add(this.lessDataGridView);
            this.Controls.Add(this.moderateDataGridView);
            this.Controls.Add(this.highDataGridView);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.DataGridView highDataGridView;
        private System.Windows.Forms.DataGridView moderateDataGridView;
        private System.Windows.Forms.DataGridView lessDataGridView;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Label eventLebel;
    }
}