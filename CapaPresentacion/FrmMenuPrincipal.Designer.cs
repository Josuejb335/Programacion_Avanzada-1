namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            topPanel = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.ControlDarkDark;
            topPanel.Controls.Add(btnMinimizar);
            topPanel.Controls.Add(btnCerrar);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(374, 23);
            topPanel.TabIndex = 0;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.DarkGreen;
            btnMinimizar.Image = Properties.Resources.iconMinimizar;
            btnMinimizar.Location = new Point(328, 0);
            btnMinimizar.Margin = new Padding(0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;

            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Image = Properties.Resources.iconoCerrarV;
            btnCerrar.Location = new Point(351, 0);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(374, 720);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMenuPrincipal_Load;
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel topPanel;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
    }
}
