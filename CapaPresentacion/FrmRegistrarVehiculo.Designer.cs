namespace CapaPresentacion
{
    partial class FrmRegistrarVehiculo
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
            txtId = new MaskedTextBox();
            lblIngreseID = new Label();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblAnio = new Label();
            lblPrecio = new Label();
            lblCat = new Label();
            txtAnio = new MaskedTextBox();
            lblEstado = new Label();
            cmbCategorias = new ComboBox();
            groupBox1 = new GroupBox();
            btnUsado = new RadioButton();
            btnNuevo = new RadioButton();
            txtPrecio = new MaskedTextBox();
            btnGuardar = new Button();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(36, 88);
            txtId.Mask = "000000";
            txtId.Name = "txtId";
            txtId.Size = new Size(270, 29);
            txtId.TabIndex = 13;
            // 
            // lblIngreseID
            // 
            lblIngreseID.AutoSize = true;
            lblIngreseID.BackColor = Color.Silver;
            lblIngreseID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseID.Location = new Point(36, 64);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(264, 21);
            lblIngreseID.TabIndex = 12;
            lblIngreseID.Text = "Ingrese el ID de Vehiculo ( 6 Digitos )";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Silver;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(360, 64);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(212, 21);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "Ingrese la Marca del Vehiculo";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = SystemColors.ActiveBorder;
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.Location = new Point(360, 88);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca del Vehiculo";
            txtMarca.Size = new Size(252, 29);
            txtMarca.TabIndex = 14;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Silver;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(36, 163);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(222, 21);
            lblModelo.TabIndex = 17;
            lblModelo.Text = "Ingrese el Modelo del Vehiculo";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = SystemColors.ActiveBorder;
            txtModelo.Font = new Font("Segoe UI", 12F);
            txtModelo.Location = new Point(36, 187);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo del Vehiculo";
            txtModelo.Size = new Size(270, 29);
            txtModelo.TabIndex = 16;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.BackColor = Color.Silver;
            lblAnio.Font = new Font("Segoe UI", 12F);
            lblAnio.Location = new Point(360, 163);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(195, 21);
            lblAnio.TabIndex = 19;
            lblAnio.Text = "Ingrese el año del Vehiculo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Silver;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(36, 260);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(212, 21);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Ingrese el Precio del Vehiculo";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.BackColor = Color.Silver;
            lblCat.Font = new Font("Segoe UI", 12F);
            lblCat.Location = new Point(360, 260);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(258, 21);
            lblCat.TabIndex = 23;
            lblCat.Text = "Seleccione la Categoria del Vehiculo";
            // 
            // txtAnio
            // 
            txtAnio.BackColor = SystemColors.ActiveBorder;
            txtAnio.Font = new Font("Segoe UI", 12F);
            txtAnio.Location = new Point(360, 187);
            txtAnio.Mask = "0000";
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(252, 29);
            txtAnio.TabIndex = 24;
            txtAnio.ValidatingType = typeof(DateTime);
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Silver;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(36, 353);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(215, 21);
            lblEstado.TabIndex = 26;
            lblEstado.Text = "Ingrese el estado del Vehiculo";
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = SystemColors.ActiveBorder;
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(360, 284);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(252, 29);
            cmbCategorias.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnUsado);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Location = new Point(37, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 41);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // btnUsado
            // 
            btnUsado.AutoSize = true;
            btnUsado.BackColor = SystemColors.ActiveBorder;
            btnUsado.Font = new Font("Segoe UI", 12F);
            btnUsado.Location = new Point(131, 16);
            btnUsado.Name = "btnUsado";
            btnUsado.Size = new Size(72, 25);
            btnUsado.TabIndex = 1;
            btnUsado.TabStop = true;
            btnUsado.Text = "Usado";
            btnUsado.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSize = true;
            btnNuevo.BackColor = SystemColors.ActiveBorder;
            btnNuevo.Font = new Font("Segoe UI", 12F);
            btnNuevo.Location = new Point(0, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(74, 25);
            btnNuevo.TabIndex = 0;
            btnNuevo.TabStop = true;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ActiveBorder;
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(36, 284);
            txtPrecio.Mask = "0000000000000000000000000000000";
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(270, 29);
            txtPrecio.TabIndex = 29;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(36, 479);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 47);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(222, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 32);
            lblTitulo.TabIndex = 31;
            lblTitulo.Text = "Registro Vehiculo";
            // 
            // FrmRegistrarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoPanelRVehi;
            ClientSize = new Size(651, 547);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(groupBox1);
            Controls.Add(cmbCategorias);
            Controls.Add(lblEstado);
            Controls.Add(txtAnio);
            Controls.Add(lblCat);
            Controls.Add(lblPrecio);
            Controls.Add(lblAnio);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(txtId);
            Controls.Add(lblIngreseID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarVehiculo";
            Text = "FrmRegistrarVehiculo";
            Load += FrmRegistrarVehiculo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtId;
        private Label lblIngreseID;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label lblAnio;
        private Label lblPrecio;
        private Label lblCat;
        private MaskedTextBox txtAnio;
        private Label lblEstado;
        private ComboBox cmbCategorias;
        private GroupBox groupBox1;
        private RadioButton btnUsado;
        private RadioButton btnNuevo;
        private MaskedTextBox txtPrecio;
        private Button btnGuardar;
        private Label lblTitulo;
    }
}