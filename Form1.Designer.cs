namespace _10_лаба
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(568, 226);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 0;
            button1.Text = "Нажми";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 1;
            label1.Text = "Значение h";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Ответ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 29);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 305);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}