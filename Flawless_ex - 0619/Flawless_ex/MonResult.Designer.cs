﻿namespace Flawless_ex
{
    partial class MonResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.choice = new System.Windows.Forms.Button();
            this.return3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付検索";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(255, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 39);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(489, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "～";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBox2.Location = new System.Drawing.Point(566, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 39);
            this.textBox2.TabIndex = 3;
            // 
            // search1
            // 
            this.search1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.search1.Location = new System.Drawing.Point(826, 39);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(148, 84);
            this.search1.TabIndex = 4;
            this.search1.Text = "検索";
            this.search1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1149, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "全レコード表示";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(161, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1188, 940);
            this.listBox1.TabIndex = 6;
            // 
            // choice
            // 
            this.choice.Location = new System.Drawing.Point(1308, 1138);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(182, 95);
            this.choice.TabIndex = 7;
            this.choice.Text = "選択";
            this.choice.UseVisualStyleBackColor = true;
            // 
            // return3
            // 
            this.return3.Location = new System.Drawing.Point(110, 1138);
            this.return3.Name = "return3";
            this.return3.Size = new System.Drawing.Size(200, 95);
            this.return3.TabIndex = 8;
            this.return3.Text = "戻る";
            this.return3.UseVisualStyleBackColor = true;
            this.return3.Click += new System.EventHandler(this.Return3_Click);
            // 
            // MonResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 1393);
            this.Controls.Add(this.return3);
            this.Controls.Add(this.choice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "MonResult";
            this.Text = "月間成績表一覧";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button choice;
        private System.Windows.Forms.Button return3;
    }
}