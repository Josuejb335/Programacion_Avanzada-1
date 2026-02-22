namespace CapaPresentacion
{
    partial class FrmRegistrarCliente
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
            dateRegistro = new DateTimePicker();
            lblRegistro = new Label();
            btnGuardar = new Button();
            lblIdenti = new Label();
            grupobtn = new GroupBox();
            btnInactivo = new RadioButton();
            btnActivo = new RadioButton();
            lblestado = new Label();
            lblTitulo = new Label();
            grupobtn.SuspendLayout();
            SuspendLayout();
            // 
            // txtIden
            // 
            txtIden.BackColor = SystemColors.ActiveBorder;
            txtIden.Font = new Font("Segoe UI", 12F);
            txtIden.Location = new Point(367, 109);
            txtIden.Name = "txtIden";
            txtIden.PlaceholderText = "Identificacion";
            txtIden.Size = new Size(252, 29);
            txtIden.TabIndex = 38;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(40, 109);
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
            lblIngreseID.Location = new Point(40, 85);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(253, 21);
            lblIngreseID.TabIndex = 36;
            lblIngreseID.Text = "Ingrese el ID de Cliente ( 6 Digitos )";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Silver;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(40, 184);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(211, 21);
            lblNombre.TabIndex = 41;
            lblNombre.Text = "Ingrese el Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveBorder;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(40, 210);
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
            lblNacimiento.Location = new Point(367, 184);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.RightToLeft = RightToLeft.Yes;
            lblNacimiento.Size = new Size(228, 21);
            lblNacimiento.TabIndex = 42;
            lblNacimiento.Text = "Ingrese la Fecha De Nacimiento";
            // 
            // dateNacimiento
            // 
            dateNacimiento.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateNacimiento.Location = new Point(367, 210);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(252, 23);
            dateNacimiento.TabIndex = 43;
            // 
            // dateRegistro
            // 
            dateRegistro.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateRegistro.Location = new Point(367, 313);
            dateRegistro.Name = "dateRegistro";
            dateRegistro.Size = new Size(252, 23);
            dateRegistro.TabIndex = 45;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.BackColor = Color.Silver;
            lblRegistro.Font = new Font("Segoe UI", 12F);
            lblRegistro.Location = new Point(367, 289);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(206, 21);
            lblRegistro.TabIndex = 44;
            lblRegistro.Text = "Ingrese la Fecha De Registro";
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
            lblIdenti.Location = new Point(367, 85);
            lblIdenti.Name = "lblIdenti";
            lblIdenti.Size = new Size(177, 21);
            lblIdenti.TabIndex = 49;
            lblIdenti.Text = "Ingrese La Identificacion";
            // 
            // grupobtn
            // 
            grupobtn.BackColor = Color.Transparent;
            grupobtn.Controls.Add(btnInactivo);
            grupobtn.Controls.Add(btnActivo);
            grupobtn.Location = new Point(42, 313);
            grupobtn.Name = "grupobtn";
            grupobtn.Size = new Size(248, 45);
            grupobtn.TabIndex = 55;
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
            lblestado.Location = new Point(42, 289);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(245, 21);
            lblestado.TabIndex = 54;
            lblestado.Text = "Seleccione si el Cliente esta Activo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(225, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 32);
            lblTitulo.TabIndex = 56;
            lblTitulo.Text = "Registro Cliente";
            // 
            // FrmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoPanelRCliente;
            ClientSize = new Size(651, 547);
            Controls.Add(lblTitulo);
            Controls.Add(grupobtn);
            Controls.Add(lblestado);
            Controls.Add(lblIdenti);
            Controls.Add(btnGuardar);
            Controls.Add(dateRegistro);
            Controls.Add(lblRegistro);
            Controls.Add(dateNacimiento);
            Controls.Add(lblNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtIden);
            Controls.Add(txtId);
            Controls.Add(lblIngreseID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarCliente";
            Text = "FrmRegistrarVendedor";
            grupobtn.ResumeLayout(false);
            grupobtn.PerformLayout();
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
        private DateTimePicker dateRegistro;
        private Label lblRegistro;
        private Button btnGuardar;
        private Label lblIdenti;
        private GroupBox grupobtn;
        private RadioButton btnInactivo;
        private RadioButton btnActivo;
        private Label lblestado;
        private Label lblTitulo;
    }
}