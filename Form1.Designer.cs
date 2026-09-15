namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPLus = new Button();
            buttonSamadengan = new Button();
            buttonMinus = new Button();
            buttonBagi = new Button();
            buttonKali = new Button();
            buttonC = new Button();
            buttonTrash = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(261, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(590, 94);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(29, 145);
            button1.Name = "button1";
            button1.Size = new Size(126, 113);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Angka_Click;
            // 
            // button2
            // 
            button2.Location = new Point(161, 145);
            button2.Name = "button2";
            button2.Size = new Size(126, 113);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Angka_Click;
            // 
            // button3
            // 
            button3.Location = new Point(293, 145);
            button3.Name = "button3";
            button3.Size = new Size(126, 113);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Angka_Click;
            // 
            // button4
            // 
            button4.Location = new Point(29, 263);
            button4.Name = "button4";
            button4.Size = new Size(126, 113);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Angka_Click;
            // 
            // button5
            // 
            button5.Location = new Point(161, 264);
            button5.Name = "button5";
            button5.Size = new Size(126, 113);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Angka_Click;
            // 
            // button6
            // 
            button6.Location = new Point(293, 264);
            button6.Name = "button6";
            button6.Size = new Size(126, 113);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Angka_Click;
            // 
            // button7
            // 
            button7.Location = new Point(29, 382);
            button7.Name = "button7";
            button7.Size = new Size(126, 113);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Angka_Click;
            // 
            // button8
            // 
            button8.Location = new Point(161, 383);
            button8.Name = "button8";
            button8.Size = new Size(126, 113);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Angka_Click;
            // 
            // button9
            // 
            button9.Location = new Point(293, 383);
            button9.Name = "button9";
            button9.Size = new Size(126, 113);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Angka_Click;
            // 
            // button0
            // 
            button0.Location = new Point(425, 383);
            button0.Name = "button0";
            button0.Size = new Size(126, 113);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Angka_Click;
            // 
            // buttonPLus
            // 
            buttonPLus.Location = new Point(425, 145);
            buttonPLus.Name = "buttonPLus";
            buttonPLus.Size = new Size(126, 113);
            buttonPLus.TabIndex = 11;
            buttonPLus.Text = "+";
            buttonPLus.UseVisualStyleBackColor = true;
            buttonPLus.Click += buttonPlus_Click;
            // 
            // buttonSamadengan
            // 
            buttonSamadengan.Location = new Point(425, 263);
            buttonSamadengan.Name = "buttonSamadengan";
            buttonSamadengan.Size = new Size(126, 113);
            buttonSamadengan.TabIndex = 12;
            buttonSamadengan.Text = "=";
            buttonSamadengan.UseVisualStyleBackColor = true;
            buttonSamadengan.Click += buttonSamadengan_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(557, 145);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(126, 113);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonBagi
            // 
            buttonBagi.Location = new Point(557, 264);
            buttonBagi.Name = "buttonBagi";
            buttonBagi.Size = new Size(126, 113);
            buttonBagi.TabIndex = 14;
            buttonBagi.Text = "/";
            buttonBagi.UseVisualStyleBackColor = true;
            buttonBagi.Click += buttonBagi_Click;
            // 
            // buttonKali
            // 
            buttonKali.Location = new Point(557, 383);
            buttonKali.Name = "buttonKali";
            buttonKali.Size = new Size(126, 113);
            buttonKali.TabIndex = 15;
            buttonKali.Text = "*";
            buttonKali.UseVisualStyleBackColor = true;
            buttonKali.Click += buttonKali_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(689, 145);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(126, 113);
            buttonC.TabIndex = 16;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonTrash
            // 
            buttonTrash.Location = new Point(689, 264);
            buttonTrash.Name = "buttonTrash";
            buttonTrash.Size = new Size(126, 113);
            buttonTrash.TabIndex = 17;
            buttonTrash.Text = "Trash";
            buttonTrash.UseVisualStyleBackColor = true;
            buttonTrash.Click += buttonTrash_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 525);
            Controls.Add(buttonTrash);
            Controls.Add(buttonC);
            Controls.Add(buttonKali);
            Controls.Add(buttonBagi);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSamadengan);
            Controls.Add(buttonPLus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPLus;
        private Button buttonSamadengan;
        private Button buttonMinus;
        private Button buttonBagi;
        private Button buttonKali;
        private Button buttonC;
        private Button buttonTrash;
    }
}
