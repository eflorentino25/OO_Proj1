namespace OO_Proj1
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
            S1_PBOX_MAIN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)S1_PBOX_MAIN).BeginInit();
            SuspendLayout();
            // 
            // S1_PBOX_MAIN
            // 
            S1_PBOX_MAIN.Location = new Point(205, 72);
            S1_PBOX_MAIN.Name = "S1_PBOX_MAIN";
            S1_PBOX_MAIN.Size = new Size(252, 205);
            S1_PBOX_MAIN.TabIndex = 0;
            S1_PBOX_MAIN.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(S1_PBOX_MAIN);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)S1_PBOX_MAIN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox S1_PBOX_MAIN;
    }
}
