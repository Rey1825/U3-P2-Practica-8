namespace U3_P2_Practica_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 0;
            label1.Text = "La factorial de:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 32);
            label2.Name = "label2";
            label2.Size = new Size(681, 27);
            label2.TabIndex = 1;
            label2.Text = "Este programa calcula la factorial del valor que introduscas.\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(186, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 39);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(398, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(258, 254);
            listBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 210);
            label3.Name = "label3";
            label3.Size = new Size(277, 27);
            label3.TabIndex = 4;
            label3.Text = "La factorial del numero:\r\n";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 39);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 258);
            label4.Name = "label4";
            label4.Size = new Size(37, 27);
            label4.TabIndex = 6;
            label4.Text = "es\r\n";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(162, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 39);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(109, 325);
            button1.Name = "button1";
            button1.Size = new Size(157, 34);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(686, 395);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Factorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
    }
}