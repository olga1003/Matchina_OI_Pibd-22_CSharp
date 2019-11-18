namespace WindowsFormsLocomotive
{
    partial class FormDepot
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
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeTrain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSetTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(12, 39);
            this.pictureBoxDepot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(645, 397);
            this.pictureBoxDepot.TabIndex = 1;
            this.pictureBoxDepot.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.pictureBoxTakeTrain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTakeTrain);
            this.groupBox1.Location = new System.Drawing.Point(675, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(169, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "забрать поезд";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(115, 50);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(23, 22);
            this.maskedTextBox.TabIndex = 3;
            // 
            // pictureBoxTakeTrain
            // 
            this.pictureBoxTakeTrain.Location = new System.Drawing.Point(5, 76);
            this.pictureBoxTakeTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTakeTrain.Name = "pictureBoxTakeTrain";
            this.pictureBoxTakeTrain.Size = new System.Drawing.Size(152, 119);
            this.pictureBoxTakeTrain.TabIndex = 2;
            this.pictureBoxTakeTrain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место";
            // 
            // buttonTakeTrain
            // 
            this.buttonTakeTrain.Location = new System.Drawing.Point(48, 23);
            this.buttonTakeTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTakeTrain.Name = "buttonTakeTrain";
            this.buttonTakeTrain.Size = new System.Drawing.Size(88, 25);
            this.buttonTakeTrain.TabIndex = 0;
            this.buttonTakeTrain.Text = "Забрать";
            this.buttonTakeTrain.UseVisualStyleBackColor = true;
            this.buttonTakeTrain.Click += new System.EventHandler(this.ButtonTakeTrain_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(675, 125);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(157, 84);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ListBoxLevels_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSetTrain
            // 
            this.buttonSetTrain.Location = new System.Drawing.Point(680, 39);
            this.buttonSetTrain.Name = "buttonSetTrain";
            this.buttonSetTrain.Size = new System.Drawing.Size(139, 68);
            this.buttonSetTrain.TabIndex = 8;
            this.buttonSetTrain.Text = "Заказать поезд";
            this.buttonSetTrain.UseVisualStyleBackColor = true;
            this.buttonSetTrain.Click += new System.EventHandler(this.ButtonSetTrain_Click_1);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.buttonSetTrain);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxDepot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDepot";
            this.Text = "FormDepot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxTakeTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonSetTrain;
    }
}