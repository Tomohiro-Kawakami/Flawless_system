﻿namespace Flawless_ex
{
    partial class Data_search_results
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
            this.returnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.Location = new System.Drawing.Point(31, 397);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(216, 52);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "戻る";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(280, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "印刷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(1005, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "計算書表示";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Data_search_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnButton);
            this.Name = "Data_search_results";
            this.Text = "買取販売データ検索　検索結果";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}