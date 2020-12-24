﻿namespace WindowsFormsAircraft
{
    partial class FormAerodrom
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
            this.pictureBoxAerodrom = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAerodrom = new System.Windows.Forms.TextBox();
            this.buttonAddAerodrom = new System.Windows.Forms.Button();
            this.listBoxAerodrom = new System.Windows.Forms.ListBox();
            this.buttonDelAerodrom = new System.Windows.Forms.Button();
            this.buttonAddAircraft = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrom
            // 
            this.pictureBoxAerodrom.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxAerodrom.Name = "pictureBoxAerodrom";
            this.pictureBoxAerodrom.Size = new System.Drawing.Size(655, 620);
            this.pictureBoxAerodrom.TabIndex = 0;
            this.pictureBoxAerodrom.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeAircraft);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(668, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолет";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(12, 68);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(107, 27);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(68, 31);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Аэродромы";
            // 
            // textBoxAerodrom
            // 
            this.textBoxAerodrom.Location = new System.Drawing.Point(665, 60);
            this.textBoxAerodrom.Name = "textBoxAerodrom";
            this.textBoxAerodrom.Size = new System.Drawing.Size(161, 20);
            this.textBoxAerodrom.TabIndex = 5;
            // 
            // buttonAddAerodrom
            // 
            this.buttonAddAerodrom.Location = new System.Drawing.Point(667, 102);
            this.buttonAddAerodrom.Name = "buttonAddAerodrom";
            this.buttonAddAerodrom.Size = new System.Drawing.Size(159, 25);
            this.buttonAddAerodrom.TabIndex = 6;
            this.buttonAddAerodrom.Text = "Добавить аэродром";
            this.buttonAddAerodrom.UseVisualStyleBackColor = true;
            this.buttonAddAerodrom.Click += new System.EventHandler(this.buttonAddAerodrom_Click);
            // 
            // listBoxAerodrom
            // 
            this.listBoxAerodrom.FormattingEnabled = true;
            this.listBoxAerodrom.Location = new System.Drawing.Point(667, 133);
            this.listBoxAerodrom.Name = "listBoxAerodrom";
            this.listBoxAerodrom.Size = new System.Drawing.Size(160, 108);
            this.listBoxAerodrom.TabIndex = 7;
            this.listBoxAerodrom.SelectedIndexChanged += new System.EventHandler(this.listBoxAerodrom_SelectedIndexChanged);
            // 
            // buttonDelAerodrom
            // 
            this.buttonDelAerodrom.Location = new System.Drawing.Point(665, 247);
            this.buttonDelAerodrom.Name = "buttonDelAerodrom";
            this.buttonDelAerodrom.Size = new System.Drawing.Size(159, 25);
            this.buttonDelAerodrom.TabIndex = 8;
            this.buttonDelAerodrom.Text = "Удалить аэродром";
            this.buttonDelAerodrom.UseVisualStyleBackColor = true;
            this.buttonDelAerodrom.Click += new System.EventHandler(this.buttonDelAerodrom_Click);
            // 
            // buttonAddAircraft
            // 
            this.buttonAddAircraft.Location = new System.Drawing.Point(665, 300);
            this.buttonAddAircraft.Name = "buttonAddAircraft";
            this.buttonAddAircraft.Size = new System.Drawing.Size(159, 62);
            this.buttonAddAircraft.TabIndex = 9;
            this.buttonAddAircraft.Text = "Добавить самолет";
            this.buttonAddAircraft.UseVisualStyleBackColor = true;
            this.buttonAddAircraft.Click += new System.EventHandler(this.buttonAddAircraft_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(667, 384);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(157, 51);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // FormAerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 621);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddAircraft);
            this.Controls.Add(this.buttonDelAerodrom);
            this.Controls.Add(this.listBoxAerodrom);
            this.Controls.Add(this.buttonAddAerodrom);
            this.Controls.Add(this.textBoxAerodrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAerodrom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAerodrom";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAerodrom;
        private System.Windows.Forms.Button buttonAddAerodrom;
        private System.Windows.Forms.ListBox listBoxAerodrom;
        private System.Windows.Forms.Button buttonDelAerodrom;
        private System.Windows.Forms.Button buttonAddAircraft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}