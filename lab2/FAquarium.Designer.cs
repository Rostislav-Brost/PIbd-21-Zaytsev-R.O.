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
            this.FAqu.Size = new System.Drawing.Size(632, 435);
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
            this.groupBox1.Location = new System.Drawing.Point(661, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(203, 274);
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
            this.FShark.Size = new System.Drawing.Size(195, 115);
            this.FShark.TabIndex = 3;
            this.FShark.TabStop = false;
            // 
            // FGet
            // 
            this.FGet.Location = new System.Drawing.Point(33, 203);
            this.FGet.Margin = new System.Windows.Forms.Padding(2);
            this.FGet.Name = "FGet";
            this.FGet.Size = new System.Drawing.Size(133, 27);
            this.FGet.TabIndex = 2;
            this.FGet.Text = "Get Fish!";
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
            this.FTicket.Location = new System.Drawing.Point(33, 44);
            this.FTicket.Margin = new System.Windows.Forms.Padding(2);
            this.FTicket.Mask = "00";
            this.FTicket.Name = "FTicket";
            this.FTicket.Size = new System.Drawing.Size(133, 20);
            this.FTicket.TabIndex = 0;
            // 
            // FSetShark
            // 
            this.FSetShark.Location = new System.Drawing.Point(694, 73);
            this.FSetShark.Margin = new System.Windows.Forms.Padding(2);
            this.FSetShark.Name = "FSetShark";
            this.FSetShark.Size = new System.Drawing.Size(133, 45);
            this.FSetShark.TabIndex = 3;
            this.FSetShark.Text = "Set Shark";
            this.FSetShark.UseVisualStyleBackColor = true;
            this.FSetShark.Click += new System.EventHandler(this.FSetShark_Click);
            // 
            // FSetTShark
            // 
            this.FSetTShark.Location = new System.Drawing.Point(694, 22);
            this.FSetTShark.Margin = new System.Windows.Forms.Padding(2);
            this.FSetTShark.Name = "FSetTShark";
            this.FSetTShark.Size = new System.Drawing.Size(133, 47);
            this.FSetTShark.TabIndex = 4;
            this.FSetTShark.Text = "Set Tiger Shark";
            this.FSetTShark.UseVisualStyleBackColor = true;
            this.FSetTShark.Click += new System.EventHandler(this.FSetTShark_Click);
            // 
            // FAquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 435);
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
    }
}