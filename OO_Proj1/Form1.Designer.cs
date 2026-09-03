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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            S1_PBOX_MAIN = new PictureBox();
            S1_LBL_XPOS = new Label();
            S1_LBL_YPOS = new Label();
            S1_TM_UPD = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)S1_PBOX_MAIN).BeginInit();
            SuspendLayout();
            // 
            // S1_PBOX_MAIN
            // 
            S1_PBOX_MAIN.BackgroundImage = (Image)resources.GetObject("S1_PBOX_MAIN.BackgroundImage");
            S1_PBOX_MAIN.BackgroundImageLayout = ImageLayout.Stretch;
            S1_PBOX_MAIN.Location = new Point(262, 114);
            S1_PBOX_MAIN.Name = "S1_PBOX_MAIN";
            S1_PBOX_MAIN.Size = new Size(186, 178);
            S1_PBOX_MAIN.TabIndex = 0;
            S1_PBOX_MAIN.TabStop = false;
            S1_PBOX_MAIN.Click += S1_PBOX_MAIN_Click;
            // 
            // S1_LBL_XPOS
            // 
            S1_LBL_XPOS.AutoSize = true;
            S1_LBL_XPOS.Location = new Point(590, 84);
            S1_LBL_XPOS.Name = "S1_LBL_XPOS";
            S1_LBL_XPOS.Size = new Size(0, 15);
            S1_LBL_XPOS.TabIndex = 1;
            // 
            // S1_LBL_YPOS
            // 
            S1_LBL_YPOS.AutoSize = true;
            S1_LBL_YPOS.Location = new Point(590, 128);
            S1_LBL_YPOS.Name = "S1_LBL_YPOS";
            S1_LBL_YPOS.Size = new Size(0, 15);
            S1_LBL_YPOS.TabIndex = 2;
            // 
            // S1_TM_UPD
            // 
            S1_TM_UPD.Enabled = true;
            S1_TM_UPD.Tick += S1_TM_UPD_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 608);
            Controls.Add(S1_LBL_YPOS);
            Controls.Add(S1_LBL_XPOS);
            Controls.Add(S1_PBOX_MAIN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)S1_PBOX_MAIN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox S1_PBOX_MAIN;
        private Label S1_LBL_XPOS;
        private Label S1_LBL_YPOS;
        private System.Windows.Forms.Timer S1_TM_UPD;
    }
}
