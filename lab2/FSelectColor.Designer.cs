namespace lab2
{
    partial class FSelectColor
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
            this.FCShark = new System.Windows.Forms.Label();
            this.FCTigherShark = new System.Windows.Forms.Label();
            this.FCOk = new System.Windows.Forms.Button();
            this.FCancel = new System.Windows.Forms.Button();
            this.panelCar = new System.Windows.Forms.Panel();
            this.FDopColor = new System.Windows.Forms.Label();
            this.FBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelFiol = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // FCShark
            // 
            this.FCShark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCShark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FCShark.Location = new System.Drawing.Point(11, 11);
            this.FCShark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCShark.Name = "FCShark";
            this.FCShark.Size = new System.Drawing.Size(77, 36);
            this.FCShark.TabIndex = 1;
            this.FCShark.Text = "Shark";
            this.FCShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCShark_MouseDown);
            // 
            // FCTigherShark
            // 
            this.FCTigherShark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCTigherShark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FCTigherShark.Location = new System.Drawing.Point(11, 46);
            this.FCTigherShark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCTigherShark.Name = "FCTigherShark";
            this.FCTigherShark.Size = new System.Drawing.Size(77, 60);
            this.FCTigherShark.TabIndex = 2;
            this.FCTigherShark.Text = "TigherShark";
            this.FCTigherShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCTigherShark_MouseDown);
            // 
            // FCOk
            // 
            this.FCOk.Location = new System.Drawing.Point(11, 147);
            this.FCOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FCOk.Name = "FCOk";
            this.FCOk.Size = new System.Drawing.Size(77, 32);
            this.FCOk.TabIndex = 7;
            this.FCOk.Text = "Добавить";
            this.FCOk.UseVisualStyleBackColor = true;
            this.FCOk.Click += new System.EventHandler(this.FCOk_Click);
            // 
            // FCancel
            // 
            this.FCancel.Location = new System.Drawing.Point(11, 183);
            this.FCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FCancel.Name = "FCancel";
            this.FCancel.Size = new System.Drawing.Size(77, 38);
            this.FCancel.TabIndex = 8;
            this.FCancel.Text = "Отмена";
            this.FCancel.UseVisualStyleBackColor = true;
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.Controls.Add(this.FDopColor);
            this.panelCar.Controls.Add(this.FBaseColor);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Location = new System.Drawing.Point(92, 11);
            this.panelCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(264, 210);
            this.panelCar.TabIndex = 9;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // FDopColor
            // 
            this.FDopColor.AllowDrop = true;
            this.FDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FDopColor.Location = new System.Drawing.Point(131, 137);
            this.FDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FDopColor.Name = "FDopColor";
            this.FDopColor.Size = new System.Drawing.Size(121, 48);
            this.FDopColor.TabIndex = 2;
            this.FDopColor.Text = "Доп.цвет";
            this.FDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.FDopColor_DragDrop);
            this.FDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.FBaseColor_DragEnter);
            // 
            // FBaseColor
            // 
            this.FBaseColor.AllowDrop = true;
            this.FBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FBaseColor.Location = new System.Drawing.Point(12, 137);
            this.FBaseColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FBaseColor.Name = "FBaseColor";
            this.FBaseColor.Size = new System.Drawing.Size(108, 48);
            this.FBaseColor.TabIndex = 1;
            this.FBaseColor.Text = "Основной";
            this.FBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.FBaseColor_DradDrop);
            this.FBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.FBaseColor_DragEnter);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(241, 101);
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Controls.Add(this.panelOrange);
            this.panelColor.Controls.Add(this.panelFiol);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelLightBlue);
            this.panelColor.Location = new System.Drawing.Point(360, 11);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(109, 210);
            this.panelColor.TabIndex = 10;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(14, 27);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(25, 24);
            this.panelRed.TabIndex = 3;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(67, 27);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(25, 24);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(14, 68);
            this.panelOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(25, 24);
            this.panelOrange.TabIndex = 4;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFiol
            // 
            this.panelFiol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelFiol.Location = new System.Drawing.Point(67, 68);
            this.panelFiol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFiol.Name = "panelFiol";
            this.panelFiol.Size = new System.Drawing.Size(25, 24);
            this.panelFiol.TabIndex = 4;
            this.panelFiol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(14, 105);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(25, 24);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(67, 105);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(25, 24);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(14, 144);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(25, 24);
            this.panelGreen.TabIndex = 4;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelLightBlue.Location = new System.Drawing.Point(67, 144);
            this.panelLightBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(25, 24);
            this.panelLightBlue.TabIndex = 4;
            this.panelLightBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FSelectColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.FCancel);
            this.Controls.Add(this.FCOk);
            this.Controls.Add(this.FCTigherShark);
            this.Controls.Add(this.FCShark);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FSelectColor";
            this.Text = "FSelectColor";
            this.panelCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FCShark;
        private System.Windows.Forms.Label FCTigherShark;
        private System.Windows.Forms.Button FCOk;
        private System.Windows.Forms.Button FCancel;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label FDopColor;
        private System.Windows.Forms.Label FBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelFiol;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelLightBlue;
    }
}