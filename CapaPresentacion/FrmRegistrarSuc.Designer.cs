namespace CapaPresentacion
{
    partial class FrmRegistrarSuc
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblUbi = new Label();
            txtUbicacion = new TextBox();
            txtTelefono = new MaskedTextBox();
            lblTlfn = new Label();
            cmbEncargado = new ComboBox();
            lblEncargadi = new Label();
            grupobtn = new GroupBox();
            btnInactivo = new RadioButton();
            btnActivo = new RadioButton();
            lblestado = new Label();
            btnGuardar = new Button();
            lblTitulo = new Label();
            grupobtn.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(31, 107);
            txtId.Mask = "000000";
            txtId.Name = "txtId";
            txtId.Size = new Size(270, 29);
            txtId.TabIndex = 39;
            // 
            // lblIngreseID
            // 
            lblIngreseID.AutoSize = true;
            lblIngreseID.BackColor = Color.Silver;
            lblIngreseID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseID.Location = new Point(31, 83);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(254, 21);
            lblIngreseID.TabIndex = 38;
            lblIngreseID.Text = "Ingrese el ID de Sucursal (6 digitos)";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Silver;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(361, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(211, 21);
            lblNombre.TabIndex = 43;
            lblNombre.Text = "Ingrese el Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveBorder;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(361, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de la Sucursal";
            txtNombre.Size = new Size(252, 29);
            txtNombre.TabIndex = 42;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.BackColor = Color.Silver;
            lblUbi.Font = new Font("Segoe UI", 12F);
            lblUbi.Location = new Point(31, 184);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(249, 21);
            lblUbi.TabIndex = 45;
            lblUbi.Text = "Ingrese la Ubicacion de la Sucursal";
            // 
            // txtUbicacion
            // 
            txtUbicacion.BackColor = SystemColors.ActiveBorder;
            txtUbicacion.Font = new Font("Segoe UI", 12F);
            txtUbicacion.Location = new Point(31, 210);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Ubicacion";
            txtUbicacion.Size = new Size(252, 29);
            txtUbicacion.TabIndex = 44;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ActiveBorder;
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(361, 208);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 29);
            txtTelefono.TabIndex = 49;
            // 
            // lblTlfn
            // 
            lblTlfn.AutoSize = true;
            lblTlfn.BackColor = Color.Silver;
            lblTlfn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTlfn.Location = new Point(361, 184);
            lblTlfn.Name = "lblTlfn";
            lblTlfn.Size = new Size(224, 21);
            lblTlfn.TabIndex = 48;
            lblTlfn.Text = "Ingrese El Numero De Telefono";
            // 
            // cmbEncargado
            // 
            cmbEncargado.BackColor = SystemColors.ActiveBorder;
            cmbEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEncargado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEncargado.FormattingEnabled = true;
            cmbEncargado.Location = new Point(29, 318);
            cmbEncargado.Name = "cmbEncargado";
            cmbEncargado.Size = new Size(249, 29);
            cmbEncargado.TabIndex = 51;
            // 
            // lblEncargadi
            // 
            lblEncargadi.AutoSize = true;
            lblEncargadi.BackColor = Color.Silver;
            lblEncargadi.Font = new Font("Segoe UI", 12F);
            lblEncargadi.Location = new Point(31, 294);
            lblEncargadi.Name = "lblEncargadi";
            lblEncargadi.Size = new Size(247, 21);
            lblEncargadi.TabIndex = 50;
            lblEncargadi.Text = "Seleccione al Vendedor Encargado";
            // 
            // grupobtn
            // 
            grupobtn.BackColor = Color.Transparent;
            grupobtn.Controls.Add(btnInactivo);
            grupobtn.Controls.Add(btnActivo);
            grupobtn.Location = new Point(361, 318);
            grupobtn.Name = "grupobtn";
            grupobtn.Size = new Size(248, 45);
            grupobtn.TabIndex = 53;
            grupobtn.TabStop = false;
            // 
            // btnInactivo
            // 
            btnInactivo.AutoSize = true;
            btnInactivo.BackColor = SystemColors.ActiveBorder;
            btnInactivo.Font = new Font("Segoe UI", 12F);
            btnInactivo.Location = new Point(168, 16);
            btnInactivo.Name = "btnInactivo";
            btnInactivo.Size = new Size(81, 25);
            btnInactivo.TabIndex = 1;
            btnInactivo.TabStop = true;
            btnInactivo.Text = "Inactiva";
            btnInactivo.UseVisualStyleBackColor = false;
            // 
            // btnActivo
            // 
            btnActivo.AutoSize = true;
            btnActivo.BackColor = SystemColors.ActiveBorder;
            btnActivo.Font = new Font("Segoe UI", 12F);
            btnActivo.Location = new Point(0, 16);
            btnActivo.Name = "btnActivo";
            btnActivo.Size = new Size(70, 25);
            btnActivo.TabIndex = 0;
            btnActivo.TabStop = true;
            btnActivo.Text = "Activa";
            btnActivo.UseVisualStyleBackColor = false;
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.BackColor = Color.Silver;
            lblestado.Font = new Font("Segoe UI", 12F);
            lblestado.Location = new Point(361, 294);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(251, 21);
            lblestado.TabIndex = 52;
            lblestado.Text = "Seleccione si la sucursal esta activa";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(34, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 47);
            btnGuardar.TabIndex = 54;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(233, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 32);
            lblTitulo.TabIndex = 55;
            lblTitulo.Text = "Registro Sucursal";
            // 
            // FrmRegistrarSuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoContenedor;
            ClientSize = new Size(651, 547);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(grupobtn);
            Controls.Add(lblestado);
            Controls.Add(cmbEncargado);
            Controls.Add(lblEncargadi);
            Controls.Add(txtTelefono);
            Controls.Add(lblTlfn);
            Controls.Add(lblUbi);
            Controls.Add(txtUbicacion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblIngreseID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarSuc";
            Text = "FrmAsociarSuc";
            Load += FrmRegistrarSuc_Load;
            grupobtn.ResumeLayout(false);
            grupobtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtId;
        private Label lblIngreseID;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblUbi;
        private TextBox txtUbicacion;
        private MaskedTextBox txtTelefono;
        private Label lblTlfn;
        private ComboBox cmbEncargado;
        private Label lblEncargadi;
        private GroupBox grupobtn;
        private RadioButton btnInactivo;
        private RadioButton btnActivo;
        private Label lblestado;
        private Button btnGuardar;
        private Label lblTitulo;
    }
}