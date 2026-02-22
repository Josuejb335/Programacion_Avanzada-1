namespace CapaPresentacion
{
    partial class FrmAsociar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            cmbVehi = new ComboBox();
            cmbSuc = new ComboBox();
            lblVehiculo = new Label();
            lblSucursal = new Label();
            pictureBox1 = new PictureBox();
            txtNum = new NumericUpDown();
            lblNum = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNum).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(164, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Asociar Vehiculo X Sucursal";
            // 
            // cmbVehi
            // 
            cmbVehi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVehi.FormattingEnabled = true;
            cmbVehi.Location = new Point(42, 144);
            cmbVehi.Name = "cmbVehi";
            cmbVehi.Size = new Size(199, 29);
            cmbVehi.TabIndex = 1;
            // 
            // cmbSuc
            // 
            cmbSuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSuc.FormattingEnabled = true;
            cmbSuc.Location = new Point(387, 144);
            cmbSuc.Name = "cmbSuc";
            cmbSuc.Size = new Size(199, 29);
            cmbSuc.TabIndex = 2;
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.BackColor = Color.Silver;
            lblVehiculo.Font = new Font("Segoe UI", 12F);
            lblVehiculo.Location = new Point(42, 121);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(199, 21);
            lblVehiculo.TabIndex = 6;
            lblVehiculo.Text = "Escoja el Vehiculo a Asociar";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.BackColor = Color.Silver;
            lblSucursal.Font = new Font("Segoe UI", 12F);
            lblSucursal.Location = new Point(387, 121);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(199, 21);
            lblSucursal.TabIndex = 7;
            lblSucursal.Text = "Escoja la Sucursal a Asociar";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconLink;
            pictureBox1.Location = new Point(267, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(42, 234);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(143, 23);
            txtNum.TabIndex = 9;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.BackColor = Color.Silver;
            lblNum.Font = new Font("Segoe UI", 12F);
            lblNum.Location = new Point(42, 210);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(143, 21);
            lblNum.TabIndex = 10;
            lblNum.Text = "Numero de asocies";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(42, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(178, 43);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAsociar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoPanelAsocie;
            ClientSize = new Size(651, 547);
            Controls.Add(btnGuardar);
            Controls.Add(lblNum);
            Controls.Add(txtNum);
            Controls.Add(pictureBox1);
            Controls.Add(lblSucursal);
            Controls.Add(lblVehiculo);
            Controls.Add(cmbSuc);
            Controls.Add(cmbVehi);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAsociar";
            Text = "FrmRegistrarSucursal";
            Load += FrmAsociar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbVehi;
        private ComboBox cmbSuc;
        private Label lblVehiculo;
        private Label lblSucursal;
        private PictureBox pictureBox1;
        private NumericUpDown txtNum;
        private Label lblNum;
        private Button btnGuardar;
    }
}