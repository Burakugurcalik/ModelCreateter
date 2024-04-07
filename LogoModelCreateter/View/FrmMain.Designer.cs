namespace LogoModelCreateter
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            rtSendValue = new RichTextBox();
            rtSendValueLabel = new Label();
            rtViewValue = new RichTextBox();
            rtViewValueLabel = new Label();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            Btn10 = new Button();
            SuspendLayout();
            // 
            // rtSendValue
            // 
            rtSendValue.Location = new Point(25, 43);
            rtSendValue.Name = "rtSendValue";
            rtSendValue.Size = new Size(375, 419);
            rtSendValue.TabIndex = 0;
            rtSendValue.Text = "";
            // 
            // rtSendValueLabel
            // 
            rtSendValueLabel.AutoSize = true;
            rtSendValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtSendValueLabel.Location = new Point(27, 16);
            rtSendValueLabel.Name = "rtSendValueLabel";
            rtSendValueLabel.Size = new Size(60, 15);
            rtSendValueLabel.TabIndex = 1;
            rtSendValueLabel.Text = "Veri Girişi";
            // 
            // rtViewValue
            // 
            rtViewValue.Location = new Point(585, 43);
            rtViewValue.Name = "rtViewValue";
            rtViewValue.Size = new Size(375, 419);
            rtViewValue.TabIndex = 2;
            rtViewValue.Text = "";
            // 
            // rtViewValueLabel
            // 
            rtViewValueLabel.AutoSize = true;
            rtViewValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtViewValueLabel.Location = new Point(585, 16);
            rtViewValueLabel.Name = "rtViewValueLabel";
            rtViewValueLabel.Size = new Size(65, 15);
            rtViewValueLabel.TabIndex = 3;
            rtViewValueLabel.Text = "Veri Çıktısı";
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1.Location = new Point(413, 43);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(164, 34);
            Btn1.TabIndex = 4;
            Btn1.Text = " c# için Hazırla";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn2.Location = new Point(413, 83);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(164, 34);
            Btn2.TabIndex = 5;
            Btn2.Text = "Sql Tablodan Class oluştur";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn3.Location = new Point(413, 123);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(164, 34);
            Btn3.TabIndex = 6;
            Btn3.Text = "Modelden Sql Insert Sorgusu";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn4
            // 
            Btn4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4.Location = new Point(413, 163);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(164, 34);
            Btn4.TabIndex = 7;
            Btn4.Text = "Modelden Sql Update Sorgusu";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn5
            // 
            Btn5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn5.Location = new Point(413, 203);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(164, 34);
            Btn5.TabIndex = 8;
            Btn5.Text = "Modelden Sql Select Sorgusu";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn6.Location = new Point(413, 243);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(164, 34);
            Btn6.TabIndex = 9;
            Btn6.Text = "İsimden Modelli Boolen Fonksiyon Hazırla";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            Btn6.ChangeUICues += Btn6_ChangeUICues;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(413, 283);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(164, 34);
            Btn7.TabIndex = 10;
            Btn7.Text = "Sqlden c# Hazırla";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Visible = false;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(413, 323);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(164, 34);
            Btn8.TabIndex = 11;
            Btn8.Text = "Sqlden c# Hazırla";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Visible = false;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(413, 363);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(164, 34);
            Btn9.TabIndex = 12;
            Btn9.Text = "Sqlden c# Hazırla";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Visible = false;
            // 
            // Btn10
            // 
            Btn10.Location = new Point(413, 403);
            Btn10.Name = "Btn10";
            Btn10.Size = new Size(164, 34);
            Btn10.TabIndex = 13;
            Btn10.Text = "Temizle";
            Btn10.UseVisualStyleBackColor = true;
            Btn10.Click += Btn10_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 474);
            Controls.Add(Btn10);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(rtViewValueLabel);
            Controls.Add(rtViewValue);
            Controls.Add(rtSendValueLabel);
            Controls.Add(rtSendValue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logo Model Creater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtSendValue;
        private Label rtSendValueLabel;
        private RichTextBox rtViewValue;
        private Label rtViewValueLabel;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button Btn10;
    }
}