namespace CapaPresentacion
{
    partial class FrmRegistrarCategoria
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
            components = new System.ComponentModel.Container();
            dataPreviewRegistro = new DataGridView();
            IdCat = new DataGridViewTextBoxColumn();
            NombreCat = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            lblInfoVistaPrevia = new Label();
            btnLimpiar = new Button();
            btnGuardarCat = new Button();
            lblIngreseID = new Label();
            lblIngreseNombre = new Label();
            txtNombreCat = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnPrevisual = new Button();
            txtIdCategoria = new MaskedTextBox();
            error1 = new ErrorProvider(components);
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataPreviewRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // dataPreviewRegistro
            // 
            dataPreviewRegistro.BackgroundColor = Color.LightGray;
            dataPreviewRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPreviewRegistro.Columns.AddRange(new DataGridViewColumn[] { IdCat, NombreCat, Descripcion });
            dataPreviewRegistro.Location = new Point(36, 368);
            dataPreviewRegistro.Name = "dataPreviewRegistro";
            dataPreviewRegistro.Size = new Size(583, 96);
            dataPreviewRegistro.TabIndex = 1;
            // 
            // IdCat
            // 
            IdCat.HeaderText = "ID Cat";
            IdCat.Name = "IdCat";
            IdCat.Width = 180;
            // 
            // NombreCat
            // 
            NombreCat.HeaderText = "Nombre Cat";
            NombreCat.Name = "NombreCat";
            NombreCat.Width = 180;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 180;
            // 
            // lblInfoVistaPrevia
            // 
            lblInfoVistaPrevia.AutoSize = true;
            lblInfoVistaPrevia.BackColor = Color.Silver;
            lblInfoVistaPrevia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoVistaPrevia.Location = new Point(38, 335);
            lblInfoVistaPrevia.Name = "lblInfoVistaPrevia";
            lblInfoVistaPrevia.Size = new Size(276, 20);
            lblInfoVistaPrevia.TabIndex = 2;
            lblInfoVistaPrevia.Text = "Vista Previa de Datos antes de Registrar ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(29, 494);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 41);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarCat
            // 
            btnGuardarCat.Enabled = false;
            btnGuardarCat.Font = new Font("Segoe UI", 12F);
            btnGuardarCat.Location = new Point(163, 494);
            btnGuardarCat.Name = "btnGuardarCat";
            btnGuardarCat.Size = new Size(165, 41);
            btnGuardarCat.TabIndex = 4;
            btnGuardarCat.Text = "Guardar Categoria";
            btnGuardarCat.UseVisualStyleBackColor = true;
            btnGuardarCat.Click += btnGuardarCat_Click;
            // 
            // lblIngreseID
            // 
            lblIngreseID.AutoSize = true;
            lblIngreseID.BackColor = Color.Silver;
            lblIngreseID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseID.Location = new Point(38, 71);
            lblIngreseID.Name = "lblIngreseID";
            lblIngreseID.Size = new Size(252, 20);
            lblIngreseID.TabIndex = 5;
            lblIngreseID.Text = "Ingrese el ID de categoria (6 digitos)";
            // 
            // lblIngreseNombre
            // 
            lblIngreseNombre.AutoSize = true;
            lblIngreseNombre.BackColor = Color.Silver;
            lblIngreseNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreseNombre.Location = new Point(38, 141);
            lblIngreseNombre.Name = "lblIngreseNombre";
            lblIngreseNombre.Size = new Size(235, 20);
            lblIngreseNombre.TabIndex = 7;
            lblIngreseNombre.Text = "Ingrese el nombre de la Categoria";
            // 
            // txtNombreCat
            // 
            txtNombreCat.BackColor = SystemColors.ActiveBorder;
            txtNombreCat.Location = new Point(38, 164);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.PlaceholderText = "Nombre Categoria";
            txtNombreCat.Size = new Size(252, 23);
            txtNombreCat.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Silver;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(38, 207);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(153, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Ingrese la descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.ActiveBorder;
            txtDescripcion.Location = new Point(38, 230);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.Size = new Size(252, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnPrevisual
            // 
            btnPrevisual.Font = new Font("Segoe UI", 12F);
            btnPrevisual.Location = new Point(36, 276);
            btnPrevisual.Name = "btnPrevisual";
            btnPrevisual.Size = new Size(165, 32);
            btnPrevisual.TabIndex = 10;
            btnPrevisual.Text = "Previsualizar Datos";
            btnPrevisual.UseVisualStyleBackColor = true;
            btnPrevisual.Click += btnPrevisual_Click;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.BackColor = SystemColors.ActiveBorder;
            txtIdCategoria.Location = new Point(38, 94);
            txtIdCategoria.Mask = "000000";
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(252, 23);
            txtIdCategoria.TabIndex = 11;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(201, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 32);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Registro de Categoria";
            // 
            // FrmRegistrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoPanelCat;
            ClientSize = new Size(651, 547);
            Controls.Add(lblTitulo);
            Controls.Add(txtIdCategoria);
            Controls.Add(btnPrevisual);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblIngreseNombre);
            Controls.Add(txtNombreCat);
            Controls.Add(lblIngreseID);
            Controls.Add(btnGuardarCat);
            Controls.Add(btnLimpiar);
            Controls.Add(lblInfoVistaPrevia);
            Controls.Add(dataPreviewRegistro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarCategoria";
            Text = "FrmRegistrarCategoria";
            ((System.ComponentModel.ISupportInitialize)dataPreviewRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataPreviewRegistro;
        private Label lblInfoVistaPrevia;
        private Button btnLimpiar;
        private Button btnGuardarCat;
        private Label lblIngreseID;
        private Label lblIngreseNombre;
        private TextBox txtNombreCat;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnPrevisual;
        private MaskedTextBox txtIdCategoria;
        private ErrorProvider error1;
        private DataGridViewTextBoxColumn IdCat;
        private DataGridViewTextBoxColumn NombreCat;
        private DataGridViewTextBoxColumn Descripcion;
        private Label lblTitulo;
    }
}