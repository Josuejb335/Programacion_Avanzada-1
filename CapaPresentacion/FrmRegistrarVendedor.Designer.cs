namespace CapaPresentacion
{
    partial class FrmRegistrarVendedor
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
            txtIden = new TextBox();
            txtId = new MaskedTextBox();
            lblIngreseID = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblNacimiento = new Label();
            dateNacimiento = new DateTimePicker();
            dateIngreso = new DateTimePicker();
            lblIngresp = new Label();
            txtTelefono = new MaskedTextBox();
            lblTlfn = new Label();
            btnGuardar = new Button();
            lblIdenti = new Label();
            SuspendLayout();
            // 
            // txtIden
            // 
            txtIden.BackColor = SystemColors.ActiveBorder;
            txtIden.Font = new Font("Segoe UI", 12F);
            txtIden.Location = new Point(367, 60);
            txtIden.Name = "txtIden";
            txtIden.PlaceholderText = "Identificacion";
            txtIden.Size = new Size(252, 29);
            txtIden.TabIndex = 38;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(40, 60);
            txtId.Mask = "000000";
            txtId.Name = "txtId";
            txtId.Size = new Size(270, 29);
            txtId.TabIndex = 37;
            // 
            // lblIngreseID
            // 
            lblIngreseID.AutoSize = true;
            lblIngreseID.BackColor = Color.Silver;
            lblIngreseID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseID.Location = new Point(40, 36);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(272, 21);
            lblIngreseID.TabIndex = 36;
            lblIngreseID.Text = "Ingrese el ID de Vendedor ( 6 Digitos )";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Silver;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(40, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(211, 21);
            lblNombre.TabIndex = 41;
            lblNombre.Text = "Ingrese el Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveBorder;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(40, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(252, 29);
            txtNombre.TabIndex = 40;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.BackColor = Color.Silver;
            lblNacimiento.Font = new Font("Segoe UI", 12F);
            lblNacimiento.Location = new Point(367, 135);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.RightToLeft = RightToLeft.Yes;
            lblNacimiento.Size = new Size(228, 21);
            lblNacimiento.TabIndex = 42;
            lblNacimiento.Text = "Ingrese la Fecha De Nacimiento";
            lblNacimiento.Click += label1_Click_1;
            // 
            // dateNacimiento
            // 
            dateNacimiento.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateNacimiento.Location = new Point(367, 161);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(252, 23);
            dateNacimiento.TabIndex = 43;
            // 
            // dateIngreso
            // 
            dateIngreso.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateIngreso.Location = new Point(367, 264);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(252, 23);
            dateIngreso.TabIndex = 45;
            // 
            // lblIngresp
            // 
            lblIngresp.AutoSize = true;
            lblIngresp.BackColor = Color.Silver;
            lblIngresp.Font = new Font("Segoe UI", 12F);
            lblIngresp.Location = new Point(367, 240);
            lblIngresp.Name = "lblIngresp";
            lblIngresp.Size = new Size(200, 21);
            lblIngresp.TabIndex = 44;
            lblIngresp.Text = "Ingrese la Fecha De Ingreso";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ActiveBorder;
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(40, 264);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 29);
            txtTelefono.TabIndex = 47;
            // 
            // lblTlfn
            // 
            lblTlfn.AutoSize = true;
            lblTlfn.BackColor = Color.Silver;
            lblTlfn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTlfn.Location = new Point(40, 240);
            lblTlfn.Name = "lblTlfn";
            lblTlfn.Size = new Size(224, 21);
            lblTlfn.TabIndex = 46;
            lblTlfn.Text = "Ingrese El Numero De Telefono";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(40, 476);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 47);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblIdenti
            // 
            lblIdenti.AutoSize = true;
            lblIdenti.BackColor = Color.Silver;
            lblIdenti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdenti.Location = new Point(367, 36);
            lblIdenti.Name = "lblIdenti";
            lblIdenti.Size = new Size(177, 21);
            lblIdenti.TabIndex = 49;
            lblIdenti.Text = "Ingrese La Identificacion";
            // 
            // FrmRegistrarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoContenedor;
            ClientSize = new Size(651, 547);
            Controls.Add(lblIdenti);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTlfn);
            Controls.Add(dateIngreso);
            Controls.Add(lblIngresp);
            Controls.Add(dateNacimiento);
            Controls.Add(lblNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtIden);
            Controls.Add(txtId);
            Controls.Add(lblIngreseID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarVendedor";
            Text = "FrmRegistrarVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgMarca;
        private PictureBox imgCar;
        private Label lblMarca;
        private TextBox txtIden;
        private MaskedTextBox txtId;
        private Label lblIngreseID;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblNacimiento;
        private DateTimePicker dateNacimiento;
        private DateTimePicker dateIngreso;
        private Label lblIngresp;
        private MaskedTextBox txtTelefono;
        private Label lblTlfn;
        private Button btnGuardar;
        private Label lblIdenti;
    }
}