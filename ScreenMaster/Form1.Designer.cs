﻿namespace ScreenMaster
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonScreen = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCopyLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxCase = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxOnlyServer = new System.Windows.Forms.CheckBox();
            this.checkBoxSendtoServer = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonScreen
            // 
            this.buttonScreen.Location = new System.Drawing.Point(133, 33);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(129, 23);
            this.buttonScreen.TabIndex = 0;
            this.buttonScreen.Text = "Снимок";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(6, 6);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(442, 22);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(320, 34);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(128, 23);
            this.buttonPath.TabIndex = 2;
            this.buttonPath.Text = "Выбрать";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 310);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCopyLink);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxLink);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.comboBoxCase);
            this.tabPage1.Controls.Add(this.buttonScreen);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скриншот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCopyLink
            // 
            this.buttonCopyLink.Location = new System.Drawing.Point(293, 175);
            this.buttonCopyLink.Name = "buttonCopyLink";
            this.buttonCopyLink.Size = new System.Drawing.Size(124, 25);
            this.buttonCopyLink.TabIndex = 8;
            this.buttonCopyLink.Text = "Скопировать";
            this.buttonCopyLink.UseVisualStyleBackColor = true;
            this.buttonCopyLink.Click += new System.EventHandler(this.buttonCopyLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ссылка";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(293, 138);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.ReadOnly = true;
            this.textBoxLink.Size = new System.Drawing.Size(226, 22);
            this.textBoxLink.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Форматы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Область";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(6, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 134);
            this.panel1.TabIndex = 3;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 21);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "GIF";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "BMP";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "JPEG";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PNG";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // comboBoxCase
            // 
            this.comboBoxCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCase.FormattingEnabled = true;
            this.comboBoxCase.Items.AddRange(new object[] {
            "Весь экран",
            "Рамка"});
            this.comboBoxCase.Location = new System.Drawing.Point(6, 32);
            this.comboBoxCase.Name = "comboBoxCase";
            this.comboBoxCase.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCase.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxOnlyServer);
            this.tabPage2.Controls.Add(this.checkBoxSendtoServer);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.textBoxPath);
            this.tabPage2.Controls.Add(this.buttonPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnlyServer
            // 
            this.checkBoxOnlyServer.AutoSize = true;
            this.checkBoxOnlyServer.Location = new System.Drawing.Point(7, 168);
            this.checkBoxOnlyServer.Name = "checkBoxOnlyServer";
            this.checkBoxOnlyServer.Size = new System.Drawing.Size(173, 21);
            this.checkBoxOnlyServer.TabIndex = 5;
            this.checkBoxOnlyServer.Text = "Не сохранять на диск";
            this.checkBoxOnlyServer.UseVisualStyleBackColor = true;
            this.checkBoxOnlyServer.CheckedChanged += new System.EventHandler(this.checkBoxOnlyServer_CheckedChanged);
            // 
            // checkBoxSendtoServer
            // 
            this.checkBoxSendtoServer.AutoSize = true;
            this.checkBoxSendtoServer.Location = new System.Drawing.Point(7, 129);
            this.checkBoxSendtoServer.Name = "checkBoxSendtoServer";
            this.checkBoxSendtoServer.Size = new System.Drawing.Size(221, 21);
            this.checkBoxSendtoServer.TabIndex = 4;
            this.checkBoxSendtoServer.Text = "Отправлять скрин на сервер";
            this.checkBoxSendtoServer.UseVisualStyleBackColor = true;
            this.checkBoxSendtoServer.CheckedChanged += new System.EventHandler(this.checkBoxSendtoServer_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(294, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Компенсация масштабирования экрана";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ScreenMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxCase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxSendtoServer;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Button buttonCopyLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxOnlyServer;
    }
}

