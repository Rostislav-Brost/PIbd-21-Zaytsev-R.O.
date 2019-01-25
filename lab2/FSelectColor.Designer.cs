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
            this.panelFish = new System.Windows.Forms.Panel();
            this.FDopColor = new System.Windows.Forms.Label();
            this.FBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxFish = new System.Windows.Forms.PictureBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelFiol = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelFish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // FCShark
            // 
            this.FCShark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCShark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FCShark.Location = new System.Drawing.Point(43, 42);
            this.FCShark.Name = "FCShark";
            this.FCShark.Size = new System.Drawing.Size(114, 54);
            this.FCShark.TabIndex = 1;
            this.FCShark.Text = "Shark";
            this.FCShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCShark_MouseDown);
            // 
            // FCTigherShark
            // 
            this.FCTigherShark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCTigherShark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FCTigherShark.Location = new System.Drawing.Point(43, 96);
            this.FCTigherShark.Name = "FCTigherShark";
            this.FCTigherShark.Size = new System.Drawing.Size(114, 91);
            this.FCTigherShark.TabIndex = 2;
            this.FCTigherShark.Text = "TigherShark";
            this.FCTigherShark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCTigherShark_MouseDown);
            // 
            // FCOk
            // 
            this.FCOk.Location = new System.Drawing.Point(43, 303);
            this.FCOk.Name = "FCOk";
            this.FCOk.Size = new System.Drawing.Size(127, 49);
            this.FCOk.TabIndex = 7;
            this.FCOk.Text = "Добавить";
            this.FCOk.UseVisualStyleBackColor = true;
            this.FCOk.Click += new System.EventHandler(this.FCOk_Click);
            // 
            // FCancel
            // 
            this.FCancel.Location = new System.Drawing.Point(43, 399);
            this.FCancel.Name = "FCancel";
            this.FCancel.Size = new System.Drawing.Size(120, 67);
            this.FCancel.TabIndex = 8;
            this.FCancel.Text = "Отмена";
            this.FCancel.UseVisualStyleBackColor = true;
            // 
            // panelFish
            // 
            this.panelFish.AllowDrop = true;
            this.panelFish.Controls.Add(this.FDopColor);
            this.panelFish.Controls.Add(this.FBaseColor);
            this.panelFish.Controls.Add(this.pictureBoxFish);
            this.panelFish.Location = new System.Drawing.Point(215, 59);
            this.panelFish.Name = "panelFish";
            this.panelFish.Size = new System.Drawing.Size(214, 413);
            this.panelFish.TabIndex = 9;
            this.panelFish.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFish_DragDrop);
            this.panelFish.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFish_DragEnter);
            // 
            // FDopColor
            // 
            this.FDopColor.AllowDrop = true;
            this.FDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FDopColor.Location = new System.Drawing.Point(18, 301);
            this.FDopColor.Name = "FDopColor";
            this.FDopColor.Size = new System.Drawing.Size(180, 73);
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
            this.FBaseColor.Location = new System.Drawing.Point(18, 211);
            this.FBaseColor.Name = "FBaseColor";
            this.FBaseColor.Size = new System.Drawing.Size(180, 73);
            this.FBaseColor.TabIndex = 1;
            this.FBaseColor.Text = "Основной";
            this.FBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.FBaseColor_DradDrop);
            this.FBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.FBaseColor_DragEnter);
            // 
            // pictureBoxFish
            // 
            this.pictureBoxFish.Location = new System.Drawing.Point(17, 17);
            this.pictureBoxFish.Name = "pictureBoxFish";
            this.pictureBoxFish.Size = new System.Drawing.Size(181, 156);
            this.pictureBoxFish.TabIndex = 0;
            this.pictureBoxFish.TabStop = false;
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
            this.panelColor.Location = new System.Drawing.Point(467, 42);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(165, 406);
            this.panelColor.TabIndex = 10;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(21, 41);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 37);
            this.panelRed.TabIndex = 3;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(101, 41);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 37);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(21, 105);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 37);
            this.panelOrange.TabIndex = 4;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFiol
            // 
            this.panelFiol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelFiol.Location = new System.Drawing.Point(101, 105);
            this.panelFiol.Name = "panelFiol";
            this.panelFiol.Size = new System.Drawing.Size(38, 37);
            this.panelFiol.TabIndex = 4;
            this.panelFiol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(21, 161);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 37);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(101, 161);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 37);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(21, 222);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 37);
            this.panelGreen.TabIndex = 4;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelLightBlue.Location = new System.Drawing.Point(101, 222);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(38, 37);
            this.panelLightBlue.TabIndex = 4;
            this.panelLightBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FSelectColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 530);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelFish);
            this.Controls.Add(this.FCancel);
            this.Controls.Add(this.FCOk);
            this.Controls.Add(this.FCTigherShark);
            this.Controls.Add(this.FCShark);
            this.Name = "FSelectColor";
            this.Text = "FSelectColor";
            this.panelFish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FCShark;
        private System.Windows.Forms.Label FCTigherShark;
        private System.Windows.Forms.Button FCOk;
        private System.Windows.Forms.Button FCancel;
        private System.Windows.Forms.Panel panelFish;
        private System.Windows.Forms.Label FDopColor;
        private System.Windows.Forms.Label FBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxFish;
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