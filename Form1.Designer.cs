namespace CatchButton
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
            btnTarget = new Button();
            SuspendLayout();
            // 
            // btnTarget
            // 
            btnTarget.AutoSize = true;
            btnTarget.BackColor = SystemColors.Info;
            btnTarget.FlatStyle = FlatStyle.Flat;
            btnTarget.ForeColor = SystemColors.GrayText;
            btnTarget.Location = new Point(179, 114);
            btnTarget.Name = "btnTarget";
            btnTarget.Padding = new Padding(10);
            btnTarget.Size = new Size(304, 134);
            btnTarget.TabIndex = 0;
            btnTarget.Text = "나를 잡아봐";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += btnTarget_Click;
            btnTarget.MouseEnter += btnTarget_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTarget;
    }
}
