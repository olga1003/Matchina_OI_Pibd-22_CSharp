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
            this.buttonSetTrain = new System.Windows.Forms.Button();
            this.buttonSetLocoTrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeTrain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(3, 11);
            this.pictureBoxDepot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(484, 345);
            this.pictureBoxDepot.TabIndex = 0;
            this.pictureBoxDepot.TabStop = false;
            // 
            // buttonSetTrain
            // 
            this.buttonSetTrain.Location = new System.Drawing.Point(491, 10);
            this.buttonSetTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetTrain.Name = "buttonSetTrain";
            this.buttonSetTrain.Size = new System.Drawing.Size(105, 25);
            this.buttonSetTrain.TabIndex = 1;
            this.buttonSetTrain.Text = "Поставить поезд";
            this.buttonSetTrain.UseVisualStyleBackColor = true;
            this.buttonSetTrain.Click += new System.EventHandler(this.ButtonSetLoc_Click_1);
            // 
            // buttonSetLocoTrain
            // 
            this.buttonSetLocoTrain.Location = new System.Drawing.Point(491, 40);
            this.buttonSetLocoTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetLocoTrain.Name = "buttonSetLocoTrain";
            this.buttonSetLocoTrain.Size = new System.Drawing.Size(105, 37);
            this.buttonSetLocoTrain.TabIndex = 2;
            this.buttonSetLocoTrain.Text = "Поставить тепловоз";
            this.buttonSetLocoTrain.UseVisualStyleBackColor = true;
            this.buttonSetLocoTrain.Click += new System.EventHandler(this.ButtonSetLocoTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.pictureBoxTakeTrain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTakeTrain);
            this.groupBox1.Location = new System.Drawing.Point(494, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(127, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "забрать поезд";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(86, 41);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(18, 20);
            this.maskedTextBox.TabIndex = 3;
            // 
            // pictureBoxTakeTrain
            // 
            this.pictureBoxTakeTrain.Location = new System.Drawing.Point(4, 62);
            this.pictureBoxTakeTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxTakeTrain.Name = "pictureBoxTakeTrain";
            this.pictureBoxTakeTrain.Size = new System.Drawing.Size(114, 97);
            this.pictureBoxTakeTrain.TabIndex = 2;
            this.pictureBoxTakeTrain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Место";
            // 
            // buttonTakeTrain
            // 
            this.buttonTakeTrain.Location = new System.Drawing.Point(36, 19);
            this.buttonTakeTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTakeTrain.Name = "buttonTakeTrain";
            this.buttonTakeTrain.Size = new System.Drawing.Size(66, 20);
            this.buttonTakeTrain.TabIndex = 0;
            this.buttonTakeTrain.Text = "Забрать";
            this.buttonTakeTrain.UseVisualStyleBackColor = true;
            this.buttonTakeTrain.Click += new System.EventHandler(this.ButtonTakeTrain_Click);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetLocoTrain);
            this.Controls.Add(this.buttonSetTrain);
            this.Controls.Add(this.pictureBoxDepot);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDepot";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.Button buttonSetTrain;
        private System.Windows.Forms.Button buttonSetLocoTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.PictureBox pictureBoxTakeTrain;
        private System.Windows.Forms.Label label1;
    }
}