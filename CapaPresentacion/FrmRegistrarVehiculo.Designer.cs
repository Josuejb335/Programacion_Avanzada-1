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
            txtPrecio = new TextBox();
            lblCat = new Label();
            txtAnio = new MaskedTextBox();
            lblEstado = new Label();
            cmbCategorias = new ComboBox();
            groupBox1 = new GroupBox();
            btnNuevo = new RadioButton();
            btnUsado = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Location = new Point(26, 50);
            txtId.Mask = "000000";
            txtId.Name = "txtId";
            txtId.Size = new Size(252, 23);
            txtId.TabIndex = 13;
            // 
            // lblIngreseID
            // 
            lblIngreseID.AutoSize = true;
            lblIngreseID.BackColor = Color.Silver;
            lblIngreseID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseID.Location = new Point(26, 27);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(255, 20);
            lblIngreseID.TabIndex = 12;
            lblIngreseID.Text = "Ingrese el ID de Vehiculo ( 6 Digitos )";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Silver;
            lblMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(203, 20);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "Ingrese la Marca del Vehiculo";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = SystemColors.ActiveBorder;
            txtMarca.Location = new Point(26, 113);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca del Vehiculo";
            txtMarca.Size = new Size(252, 23);
            txtMarca.TabIndex = 14;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Silver;
            lblModelo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(26, 158);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(214, 20);
            lblModelo.TabIndex = 17;
            lblModelo.Text = "Ingrese el Modelo del Vehiculo";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = SystemColors.ActiveBorder;
            txtModelo.Location = new Point(26, 181);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo del Vehiculo";
            txtModelo.Size = new Size(252, 23);
            txtModelo.TabIndex = 16;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.BackColor = Color.Silver;
            lblAnio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnio.Location = new Point(26, 225);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(187, 20);
            lblAnio.TabIndex = 19;
            lblAnio.Text = "Ingrese el año del Vehiculo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Silver;
            lblPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(26, 291);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(203, 20);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Ingrese el Precio del Vehiculo";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ActiveBorder;
            txtPrecio.Location = new Point(26, 314);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Marca del Vehiculo";
            txtPrecio.Size = new Size(252, 23);
            txtPrecio.TabIndex = 20;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.BackColor = Color.Silver;
            lblCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCat.Location = new Point(26, 357);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(203, 20);
            lblCat.TabIndex = 23;
            lblCat.Text = "Ingrese la Marca del Vehiculo";
            // 
            // txtAnio
            // 
            txtAnio.BackColor = SystemColors.ActiveBorder;
            txtAnio.Location = new Point(26, 248);
            txtAnio.Mask = "0000";
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(252, 23);
            txtAnio.TabIndex = 24;
            txtAnio.ValidatingType = typeof(DateTime);
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Silver;
            lblEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(26, 418);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(207, 20);
            lblEstado.TabIndex = 26;
            lblEstado.Text = "Ingrese el estado del Vehiculo";
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = SystemColors.ActiveBorder;
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(26, 380);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(203, 23);
            cmbCategorias.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnUsado);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Location = new Point(26, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 41);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSize = true;
            btnNuevo.BackColor = SystemColors.ActiveBorder;
            btnNuevo.Location = new Point(0, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(60, 19);
            btnNuevo.TabIndex = 0;
            btnNuevo.TabStop = true;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnUsado
            // 
            btnUsado.AutoSize = true;
            btnUsado.BackColor = SystemColors.ActiveBorder;
            btnUsado.Location = new Point(145, 18);
            btnUsado.Name = "btnUsado";
            btnUsado.Size = new Size(58, 19);
            btnUsado.TabIndex = 1;
            btnUsado.TabStop = true;
            btnUsado.Text = "Usado";
            btnUsado.UseVisualStyleBackColor = false;
            btnUsado.CheckedChanged += btnUsado_CheckedChanged;
            // 
            // FrmRegistrarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.bgPnlContenedor;
            ClientSize = new Size(906, 547);
            Controls.Add(groupBox1);
            Controls.Add(cmbCategorias);
            Controls.Add(lblEstado);
            Controls.Add(txtAnio);
            Controls.Add(lblCat);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
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
        private TextBox txtPrecio;
        private Label lblCat;
        private MaskedTextBox txtAnio;
        private Label lblEstado;
        private ComboBox cmbCategorias;
        private GroupBox groupBox1;
        private RadioButton btnUsado;
        private RadioButton btnNuevo;
    }
}