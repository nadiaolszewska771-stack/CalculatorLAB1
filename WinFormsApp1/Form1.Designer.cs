namespace MiniCalculator
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
            button1 = new Button();
            button2 = new Button();
            txtFirstNo = new TextBox();
            txtSecNo = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(332, 80);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 0;
            button1.Text = "Addition";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 192);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 1;
            button2.Text = "Substraction";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtFirstNo
            // 
            txtFirstNo.Location = new Point(56, 55);
            txtFirstNo.Name = "txtFirstNo";
            txtFirstNo.Size = new Size(150, 31);
            txtFirstNo.TabIndex = 2;
            txtFirstNo.TextChanged += textBox1_TextChanged;
            // 
            // txtSecNo
            // 
            txtSecNo.Location = new Point(56, 154);
            txtSecNo.Name = "txtSecNo";
            txtSecNo.Size = new Size(150, 31);
            txtSecNo.TabIndex = 3;
            txtSecNo.TextChanged += textBox2_TextChanged;
            // 
            // txtResult
            // 
            txtResult.AccessibleName = "";
            txtResult.Location = new Point(56, 270);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(150, 31);
            txtResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(txtSecNo);
            Controls.Add(txtFirstNo);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtFirstNo;
        private TextBox txtSecNo;
        private TextBox txtResult;
    }
}
