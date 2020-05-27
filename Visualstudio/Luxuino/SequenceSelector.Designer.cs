namespace LedController
{
    partial class SequenceSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceSelector));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteSequence = new System.Windows.Forms.Button();
            this.editSequence = new System.Windows.Forms.Button();
            this.uploadSequence = new System.Windows.Forms.Button();
            this.addSequence = new System.Windows.Forms.Button();
            this.lengthLabel = new MetroFramework.Controls.MetroLabel();
            this.pointsLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 326);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // deleteSequence
            // 
            this.deleteSequence.BackColor = System.Drawing.Color.White;
            this.deleteSequence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteSequence.BackgroundImage")));
            this.deleteSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSequence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteSequence.Location = new System.Drawing.Point(527, 10);
            this.deleteSequence.Name = "deleteSequence";
            this.deleteSequence.Size = new System.Drawing.Size(40, 40);
            this.deleteSequence.TabIndex = 37;
            this.deleteSequence.UseVisualStyleBackColor = false;
            this.deleteSequence.Click += new System.EventHandler(this.deleteSequence_Click);
            // 
            // editSequence
            // 
            this.editSequence.BackColor = System.Drawing.Color.White;
            this.editSequence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editSequence.BackgroundImage")));
            this.editSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSequence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editSequence.Location = new System.Drawing.Point(481, 10);
            this.editSequence.Name = "editSequence";
            this.editSequence.Size = new System.Drawing.Size(40, 40);
            this.editSequence.TabIndex = 38;
            this.editSequence.UseVisualStyleBackColor = false;
            this.editSequence.Click += new System.EventHandler(this.editSequence_Click);
            // 
            // uploadSequence
            // 
            this.uploadSequence.BackColor = System.Drawing.Color.White;
            this.uploadSequence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadSequence.BackgroundImage")));
            this.uploadSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadSequence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uploadSequence.Location = new System.Drawing.Point(435, 10);
            this.uploadSequence.Name = "uploadSequence";
            this.uploadSequence.Size = new System.Drawing.Size(40, 40);
            this.uploadSequence.TabIndex = 39;
            this.uploadSequence.UseVisualStyleBackColor = false;
            // 
            // addSequence
            // 
            this.addSequence.BackColor = System.Drawing.Color.White;
            this.addSequence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSequence.BackgroundImage")));
            this.addSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSequence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addSequence.Location = new System.Drawing.Point(527, 56);
            this.addSequence.Name = "addSequence";
            this.addSequence.Size = new System.Drawing.Size(40, 40);
            this.addSequence.TabIndex = 40;
            this.addSequence.UseVisualStyleBackColor = false;
            this.addSequence.Click += new System.EventHandler(this.addSequence_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(340, 11);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(51, 19);
            this.lengthLabel.TabIndex = 41;
            this.lengthLabel.Text = "Length:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(340, 29);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(46, 19);
            this.pointsLabel.TabIndex = 42;
            this.pointsLabel.Text = "Points:";
            // 
            // SequenceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.addSequence);
            this.Controls.Add(this.uploadSequence);
            this.Controls.Add(this.editSequence);
            this.Controls.Add(this.deleteSequence);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SequenceSelector";
            this.Size = new System.Drawing.Size(582, 326);
            this.Load += new System.EventHandler(this.SequenceSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteSequence;
        private System.Windows.Forms.Button editSequence;
        public System.Windows.Forms.Button uploadSequence;
        private System.Windows.Forms.Button addSequence;
        private MetroFramework.Controls.MetroLabel lengthLabel;
        private MetroFramework.Controls.MetroLabel pointsLabel;
    }
}
