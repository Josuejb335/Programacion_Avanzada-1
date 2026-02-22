namespace CapaPresentacion
{
    partial class FrmContInfoSuc
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
            dataInfo = new DataGridView();
            IdSucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            NombreVendedor = new DataGridViewTextBoxColumn();
            IdVendedor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { IdSucursal, Nombre, Direccion, Telefono, Activo, NombreVendedor, IdVendedor });
            dataInfo.Location = new Point(12, 12);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(603, 400);
            dataInfo.TabIndex = 1;
            dataInfo.CellFormatting += dataInfo_CellFormatting;
            // 
            // IdSucursal
            // 
            IdSucursal.DataPropertyName = "IdSucursal";
            IdSucursal.HeaderText = "ID Suc";
            IdSucursal.Name = "IdSucursal";
            IdSucursal.Width = 80;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "NombreSucursal";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 60;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            Activo.Width = 50;
            // 
            // NombreVendedor
            // 
            NombreVendedor.DataPropertyName = "Nombre";
            NombreVendedor.HeaderText = "Encargado";
            NombreVendedor.Name = "NombreVendedor";
            // 
            // IdVendedor
            // 
            IdVendedor.DataPropertyName = "Identificacion";
            IdVendedor.HeaderText = "Vendedor ID";
            IdVendedor.Name = "IdVendedor";
            IdVendedor.Width = 70;
            // 
            // FrmContInfoSuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoContInfoGen;
            ClientSize = new Size(627, 424);
            Controls.Add(dataInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContInfoSuc";
            Text = "FrmContInfoSuc";
            Load += FrmContInfoSuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn NombreVendedor;
        private DataGridViewTextBoxColumn IdVendedor;
    }
}