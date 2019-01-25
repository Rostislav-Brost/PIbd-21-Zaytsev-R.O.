namespace lab2
{
    partial class FAquarium
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
            this.FAqu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FShark = new System.Windows.Forms.PictureBox();
            this.FGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FTicket = new System.Windows.Forms.MaskedTextBox();
            this.FSetShark = new System.Windows.Forms.Button();
            this.FSetTShark = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FAqu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FShark)).BeginInit();
            this.SuspendLayout();
            // 
            // FAqu
            // 
            this.FAqu.Dock = System.Windows.Forms.DockStyle.Left;
            this.FAqu.Location = new System.Drawing.Point(0, 0);
            this.FAqu.Margin = new System.Windows.Forms.Padding(2);
            this.FAqu.Name = "FAqu";
            this.FAqu.Size = new System.Drawing.Size(592, 435);
            this.FAqu.TabIndex = 0;
            this.FAqu.TabStop = false;
            this.FAqu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FShark);
            this.groupBox1.Controls.Add(this.FGet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FTicket);
            this.groupBox1.Location = new System.Drawing.Point(610, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(181, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Fish";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FShark
            // 
            this.FShark.Location = new System.Drawing.Point(4, 71);
            this.FShark.Margin = new System.Windows.Forms.Padding(2);
            this.FShark.Name = "FShark";
            this.FShark.Size = new System.Drawing.Size(184, 115);
            this.FShark.TabIndex = 3;
            this.FShark.TabStop = false;
            // 
            // FGet
            // 
            this.FGet.Location = new System.Drawing.Point(4, 203);
            this.FGet.Margin = new System.Windows.Forms.Padding(2);
            this.FGet.Name = "FGet";
            this.FGet.Size = new System.Drawing.Size(195, 27);
            this.FGet.TabIndex = 2;
            this.FGet.Text = "Get";
            this.FGet.UseVisualStyleBackColor = true;
            this.FGet.Click += new System.EventHandler(this.FGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "number";
            // 
            // FTicket
            // 
            this.FTicket.Location = new System.Drawing.Point(41, 44);
            this.FTicket.Margin = new System.Windows.Forms.Padding(2);
            this.FTicket.Mask = "00";
            this.FTicket.Name = "FTicket";
            this.FTicket.Size = new System.Drawing.Size(110, 20);
            this.FTicket.TabIndex = 0;
            // 
            // FSetShark
            // 
            this.FSetShark.Location = new System.Drawing.Point(596, 11);
            this.FSetShark.Margin = new System.Windows.Forms.Padding(2);
            this.FSetShark.Name = "FSetShark";
            this.FSetShark.Size = new System.Drawing.Size(105, 21);
            this.FSetShark.TabIndex = 3;
            this.FSetShark.Text = "Set Shark";
            this.FSetShark.UseVisualStyleBackColor = true;
            this.FSetShark.Click += new System.EventHandler(this.FSetShark_Click);
            // 
            // FSetTShark
            // 
            this.FSetTShark.Location = new System.Drawing.Point(705, 11);
            this.FSetTShark.Margin = new System.Windows.Forms.Padding(2);
            this.FSetTShark.Name = "FSetTShark";
            this.FSetTShark.Size = new System.Drawing.Size(93, 21);
            this.FSetTShark.TabIndex = 4;
            this.FSetTShark.Text = "Set Tiger Shark";
            this.FSetTShark.UseVisualStyleBackColor = true;
            this.FSetTShark.Click += new System.EventHandler(this.FSetTShark_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(642, 47);
            this.listBoxLevels.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(110, 147);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(762, 86);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(36, 53);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "->";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(596, 86);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(36, 53);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.Text = "<-";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // FAquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 435);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.FSetTShark);
            this.Controls.Add(this.FSetShark);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FAqu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAquarium";
            this.Text = "FAquarium";
            ((System.ComponentModel.ISupportInitialize)(this.FAqu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FShark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FAqu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox FTicket;
        private System.Windows.Forms.PictureBox FShark;
        private System.Windows.Forms.Button FGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FSetShark;
        private System.Windows.Forms.Button FSetTShark;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}