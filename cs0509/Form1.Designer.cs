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
            SuspendLayout();
            // 
            // buttonProperty
            // 
            buttonProperty.BackColor = Color.FromArgb(192, 255, 192);
            buttonProperty.Font = new Font("メイリオ", 32F);
            buttonProperty.ForeColor = Color.FromArgb(0, 64, 0);
            buttonProperty.Location = new Point(214, 108);
            buttonProperty.Name = "buttonProperty";
            buttonProperty.Size = new Size(400, 100);
            buttonProperty.TabIndex = 0;
            buttonProperty.Text = "ボタン";
            buttonProperty.UseVisualStyleBackColor = false;
            buttonProperty.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProperty);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonProperty;
    }
}
