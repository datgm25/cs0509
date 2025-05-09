namespace cs0509
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
            buttonProperty = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // buttonProperty
            // 
            buttonProperty.BackColor = Color.FromArgb(192, 255, 192);
            buttonProperty.Font = new Font("メイリオ", 32F);
            buttonProperty.ForeColor = Color.FromArgb(0, 64, 0);
            buttonProperty.Location = new Point(12, 12);
            buttonProperty.Name = "buttonProperty";
            buttonProperty.Size = new Size(402, 67);
            buttonProperty.TabIndex = 0;
            buttonProperty.Text = "ボタン";
            buttonProperty.UseVisualStyleBackColor = false;
            buttonProperty.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(107, 62);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F);
            label1.Location = new Point(367, 238);
            label1.Name = "label1";
            label1.Size = new Size(98, 45);
            label1.TabIndex = 2;
            label1.Text = "(・ω・)";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(752, 346);
            button2.Name = "button2";
            button2.Size = new Size(54, 53);
            button2.TabIndex = 3;
            button2.Text = "UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(704, 405);
            button3.Name = "button3";
            button3.Size = new Size(50, 51);
            button3.TabIndex = 4;
            button3.Text = "LEFT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(802, 405);
            button4.Name = "button4";
            button4.Size = new Size(51, 51);
            button4.TabIndex = 5;
            button4.Text = "RIGHT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(752, 462);
            button5.Name = "button5";
            button5.Size = new Size(54, 42);
            button5.TabIndex = 6;
            button5.Text = "DOWN";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 520);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonProperty);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProperty;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
