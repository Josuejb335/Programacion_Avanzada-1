namespace CapaPresentacion
{
    partial class FrmMostrarInfo
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
            btnCategorias = new Button();
            btnVehiculos = new Button();
            btnSucursales = new Button();
            btnVendedores = new Button();
            btnClientes = new Button();
            btnAsociaciones = new Button();
            pnlContenedor = new Panel();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            btnCategorias.Location = new Point(7, 21);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(101, 38);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            btnVehiculos.Location = new Point(114, 21);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(101, 38);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            btnSucursales.Location = new Point(328, 21);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(101, 38);
            btnSucursales.TabIndex = 2;
            btnSucursales.Text = "Sucursales";
            btnSucursales.UseVisualStyleBackColor = true;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            btnVendedores.Location = new Point(221, 21);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(101, 38);
            btnVendedores.TabIndex = 3;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            btnClientes.Location = new Point(435, 21);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(101, 38);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnAsociaciones
            // 
            btnAsociaciones.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsociaciones.Location = new Point(542, 21);
            btnAsociaciones.Name = "btnAsociaciones";
            btnAsociaciones.Size = new Size(101, 38);
            btnAsociaciones.TabIndex = 5;
            btnAsociaciones.Text = "Asociaciones";
            btnAsociaciones.UseVisualStyleBackColor = true;
            btnAsociaciones.Click += btnAsociaciones_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Transparent;
            pnlContenedor.Location = new Point(12, 86);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(627, 424);
            pnlContenedor.TabIndex = 6;
            // 
            // FrmMostrarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.fondoPanelInfo;
            ClientSize = new Size(651, 533);
            Controls.Add(pnlContenedor);
            Controls.Add(btnAsociaciones);
            Controls.Add(btnClientes);
            Controls.Add(btnVendedores);
            Controls.Add(btnSucursales);
            Controls.Add(btnVehiculos);
            Controls.Add(btnCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMostrarInfo";
            Text = "FrmMostrarInfo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private Button btnVehiculos;
        private Button btnSucursales;
        private Button btnVendedores;
        private Button btnClientes;
        private Button btnAsociaciones;
        private Panel pnlContenedor;
    }
}