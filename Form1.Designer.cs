namespace Boxx
{
    partial class BoxxWindow
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(154, 357);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.ImeMode = ImeMode.NoControl;
            richTextBox1.Location = new Point(12, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(245, 134);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Command (optional)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 22);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 270);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 23);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Icon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 252);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "Buttons";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 316);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Delay";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(54, 314);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 22);
            textBox2.TabIndex = 3;
            // 
            // BoxxWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(269, 401);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BoxxWindow";
            Text = "Boxx";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
    }
}