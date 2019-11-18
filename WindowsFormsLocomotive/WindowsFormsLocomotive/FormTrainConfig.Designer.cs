namespace WindowsFormsLocomotive
{
    partial class FormTrainConfig
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
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            this.groupBoxTrain = new System.Windows.Forms.GroupBox();
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelLocomotive = new System.Windows.Forms.Label();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            this.groupBoxTrain.SuspendLayout();
            this.panelTrain.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(180, 118);
            this.pictureBoxTrain.TabIndex = 0;
            this.pictureBoxTrain.TabStop = false;
            // 
            // groupBoxTrain
            // 
            this.groupBoxTrain.Controls.Add(this.labelTrain);
            this.groupBoxTrain.Location = new System.Drawing.Point(64, 95);
            this.groupBoxTrain.Name = "groupBoxTrain";
            this.groupBoxTrain.Size = new System.Drawing.Size(200, 206);
            this.groupBoxTrain.TabIndex = 1;
            this.groupBoxTrain.TabStop = false;
            this.groupBoxTrain.Text = "Тип поезда";
            // 
            // labelTrain
            // 
            this.labelTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrain.Location = new System.Drawing.Point(53, 66);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(87, 24);
            this.labelTrain.TabIndex = 2;
            this.labelTrain.Text = "Локомотив";
            this.labelTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrain_MouseDown);
            // 
            // labelLocomotive
            // 
            this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocomotive.Location = new System.Drawing.Point(117, 206);
            this.labelLocomotive.Name = "labelLocomotive";
            this.labelLocomotive.Size = new System.Drawing.Size(87, 25);
            this.labelLocomotive.TabIndex = 2;
            this.labelLocomotive.Text = "Тепловоз";
            this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLocomotive_MouseDown);
            // 
            // panelTrain
            // 
            this.panelTrain.AllowDrop = true;
            this.panelTrain.Controls.Add(this.labelDopColor);
            this.panelTrain.Controls.Add(this.labelMainColor);
            this.panelTrain.Controls.Add(this.pictureBoxTrain);
            this.panelTrain.Location = new System.Drawing.Point(297, 115);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(226, 233);
            this.panelTrain.TabIndex = 3;
            this.panelTrain.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragDrop);
            this.panelTrain.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(24, 195);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(180, 29);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "             Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(24, 154);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(180, 32);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "        Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(16, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(52, 50);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(92, 21);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(52, 50);
            this.panelWhite.TabIndex = 5;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Gold;
            this.panelYellow.Location = new System.Drawing.Point(92, 156);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(52, 50);
            this.panelYellow.TabIndex = 6;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(16, 156);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(52, 50);
            this.panelRed.TabIndex = 5;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelBlue.Location = new System.Drawing.Point(92, 88);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(52, 50);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(16, 227);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(52, 50);
            this.panelGray.TabIndex = 5;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.OrangeRed;
            this.panelOrange.Location = new System.Drawing.Point(92, 227);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(52, 50);
            this.panelOrange.TabIndex = 5;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(16, 88);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(52, 50);
            this.panelGreen.TabIndex = 5;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(551, 41);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(168, 315);
            this.groupBoxColor.TabIndex = 7;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(182, 379);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 29);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(64, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 29);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click_1);
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.labelLocomotive);
            this.Controls.Add(this.groupBoxTrain);
            this.Name = "FormTrainConfig";
            this.Text = "FormTrainConfig";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            this.groupBoxTrain.ResumeLayout(false);
            this.panelTrain.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrain;
        private System.Windows.Forms.GroupBox groupBoxTrain;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Label labelLocomotive;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}