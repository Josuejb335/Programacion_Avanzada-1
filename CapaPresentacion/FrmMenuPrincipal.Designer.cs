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
            txtTitulo = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedorBtns = new Panel();
            btnAsociar = new Button();
            btnRegistrarCliente = new Button();
            btnConsultarInfo = new Button();
            btnRegistrarSucursal = new Button();
            btnRegistrarVendedor = new Button();
            btnRegistrarVehiculo = new Button();
            imgLogo = new PictureBox();
            btnRegistrarCat = new Button();
            pnlContenedor = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelContenedorBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Maroon;
            topPanel.Controls.Add(txtTitulo);
            topPanel.Controls.Add(btnMinimizar);
            topPanel.Controls.Add(btnCerrar);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1280, 80);
            topPanel.TabIndex = 0;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Sitka Banner", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonFace;
            txtTitulo.Location = new Point(3, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(325, 53);
            txtTitulo.TabIndex = 3;
            txtTitulo.Text = "Gestión AutoMarket";
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.LimeGreen;
            btnMinimizar.Image = Properties.Resources.iconMinimizar2;
            btnMinimizar.Location = new Point(1234, 0);
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
            btnCerrar.Location = new Point(1257, 0);
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
            // panelContenedorBtns
            // 
            panelContenedorBtns.BackColor = Color.LightGray;
            panelContenedorBtns.BackgroundImage = Properties.Resources.fondoPanelContBtnsMP;
            panelContenedorBtns.Controls.Add(btnAsociar);
            panelContenedorBtns.Controls.Add(btnRegistrarCliente);
            panelContenedorBtns.Controls.Add(btnConsultarInfo);
            panelContenedorBtns.Controls.Add(btnRegistrarSucursal);
            panelContenedorBtns.Controls.Add(btnRegistrarVendedor);
            panelContenedorBtns.Controls.Add(btnRegistrarVehiculo);
            panelContenedorBtns.Controls.Add(imgLogo);
            panelContenedorBtns.Controls.Add(btnRegistrarCat);
            panelContenedorBtns.Location = new Point(24, 129);
            panelContenedorBtns.Name = "panelContenedorBtns";
            panelContenedorBtns.Size = new Size(282, 547);
            panelContenedorBtns.TabIndex = 1;
            // 
            // btnAsociar
            // 
            btnAsociar.BackColor = Color.Transparent;
            btnAsociar.BackgroundImage = Properties.Resources.bgBotones;
            btnAsociar.Cursor = Cursors.Hand;
            btnAsociar.FlatAppearance.BorderSize = 0;
            btnAsociar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAsociar.FlatStyle = FlatStyle.Flat;
            btnAsociar.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsociar.Location = new Point(18, 216);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(244, 34);
            btnAsociar.TabIndex = 7;
            btnAsociar.Text = "Asociar Vehiculo a Sucursal";
            btnAsociar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.Transparent;
            btnRegistrarCliente.BackgroundImage = Properties.Resources.bgBotones;
            btnRegistrarCliente.Cursor = Cursors.Hand;
            btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            btnRegistrarCliente.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistrarCliente.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            btnRegistrarCliente.Location = new Point(18, 176);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(244, 34);
            btnRegistrarCliente.TabIndex = 6;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            // 
            // btnConsultarInfo
            // 
            btnConsultarInfo.BackColor = Color.Transparent;
            btnConsultarInfo.BackgroundImage = Properties.Resources.bgBotones;
            btnConsultarInfo.Cursor = Cursors.Hand;
            btnConsultarInfo.FlatAppearance.BorderColor = Color.Black;
            btnConsultarInfo.FlatAppearance.BorderSize = 0;
            btnConsultarInfo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnConsultarInfo.FlatStyle = FlatStyle.Flat;
            btnConsultarInfo.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            btnConsultarInfo.Location = new Point(18, 256);
            btnConsultarInfo.Name = "btnConsultarInfo";
            btnConsultarInfo.Size = new Size(244, 34);
            btnConsultarInfo.TabIndex = 6;
            btnConsultarInfo.Text = "Consultar Informacion";
            btnConsultarInfo.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarSucursal
            // 
            btnRegistrarSucursal.BackColor = Color.Transparent;
            btnRegistrarSucursal.BackgroundImage = Properties.Resources.bgBotones;
            btnRegistrarSucursal.Cursor = Cursors.Hand;
            btnRegistrarSucursal.FlatAppearance.BorderSize = 0;
            btnRegistrarSucursal.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRegistrarSucursal.FlatStyle = FlatStyle.Flat;
            btnRegistrarSucursal.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            btnRegistrarSucursal.Location = new Point(18, 136);
            btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            btnRegistrarSucursal.Size = new Size(244, 34);
            btnRegistrarSucursal.TabIndex = 5;
            btnRegistrarSucursal.Text = "Registrar Sucursal";
            btnRegistrarSucursal.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVendedor
            // 
            btnRegistrarVendedor.BackColor = Color.Transparent;
            btnRegistrarVendedor.BackgroundImage = Properties.Resources.bgBotones;
            btnRegistrarVendedor.Cursor = Cursors.Hand;
            btnRegistrarVendedor.FlatAppearance.BorderSize = 0;
            btnRegistrarVendedor.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRegistrarVendedor.FlatStyle = FlatStyle.Flat;
            btnRegistrarVendedor.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            btnRegistrarVendedor.Location = new Point(18, 96);
            btnRegistrarVendedor.Name = "btnRegistrarVendedor";
            btnRegistrarVendedor.Size = new Size(244, 34);
            btnRegistrarVendedor.TabIndex = 4;
            btnRegistrarVendedor.Text = "Registrar Vendedor";
            btnRegistrarVendedor.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVehiculo
            // 
            btnRegistrarVehiculo.BackColor = Color.Transparent;
            btnRegistrarVehiculo.BackgroundImage = Properties.Resources.bgBotones;
            btnRegistrarVehiculo.Cursor = Cursors.Hand;
            btnRegistrarVehiculo.FlatAppearance.BorderSize = 0;
            btnRegistrarVehiculo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRegistrarVehiculo.FlatStyle = FlatStyle.Flat;
            btnRegistrarVehiculo.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            btnRegistrarVehiculo.Location = new Point(18, 56);
            btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            btnRegistrarVehiculo.Size = new Size(244, 34);
            btnRegistrarVehiculo.TabIndex = 3;
            btnRegistrarVehiculo.Text = "Registrar Vehiculo";
            btnRegistrarVehiculo.UseVisualStyleBackColor = false;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = Properties.Resources.logoAutoMarket;
            imgLogo.Location = new Point(42, 404);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(184, 117);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 2;
            imgLogo.TabStop = false;
            // 
            // btnRegistrarCat
            // 
            btnRegistrarCat.BackColor = Color.Transparent;
            btnRegistrarCat.BackgroundImage = Properties.Resources.bgBotones;
            btnRegistrarCat.Cursor = Cursors.Hand;
            btnRegistrarCat.FlatAppearance.BorderSize = 0;
            btnRegistrarCat.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRegistrarCat.FlatStyle = FlatStyle.Flat;
            btnRegistrarCat.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCat.Location = new Point(18, 16);
            btnRegistrarCat.Name = "btnRegistrarCat";
            btnRegistrarCat.Size = new Size(244, 34);
            btnRegistrarCat.TabIndex = 0;
            btnRegistrarCat.Text = "Registrar Cat Vehiculo";
            btnRegistrarCat.UseVisualStyleBackColor = false;
            btnRegistrarCat.Click += btnRegistrarCat_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Transparent;
            pnlContenedor.Location = new Point(351, 129);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(906, 547);
            pnlContenedor.TabIndex = 2;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlContenedor);
            Controls.Add(panelContenedorBtns);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelContenedorBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel topPanel;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel panelContenedorBtns;
        private Button btnRegistrarCat;
        private PictureBox imgLogo;
        private Button btnAsociar;
        private Button btnRegistrarCliente;
        private Button btnConsultarInfo;
        private Button btnRegistrarSucursal;
        private Button btnRegistrarVendedor;
        private Button btnRegistrarVehiculo;
        private Label txtTitulo;
        private Panel pnlContenedor;
    }
}
