namespace CapaPresentacion
{
    partial class FrmContInfoVehi
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
            IdVehiculo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            NombreCat = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { IdVehiculo, Marca, Modelo, Anio, Precio, Estado, NombreCat, Descripcion });
            dataInfo.Location = new Point(12, 12);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(603, 400);
            dataInfo.TabIndex = 1;
            dataInfo.CellFormatting += dataInfo_CellFormatting;
            // 
            // IdVehiculo
            // 
            IdVehiculo.DataPropertyName = "IdVehiculo";
            IdVehiculo.HeaderText = "ID Vehi";
            IdVehiculo.Name = "IdVehiculo";
            IdVehiculo.Width = 50;
            // 
            // Marca
            // 
            Marca.DataPropertyName = "Marca";
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.Width = 60;
            // 
            // Modelo
            // 
            Modelo.DataPropertyName = "Modelo";
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.Width = 60;
            // 
            // Anio
            // 
            Anio.DataPropertyName = "Anio";
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            Anio.Width = 40;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 60;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Width = 50;
            // 
            // NombreCat
            // 
            NombreCat.DataPropertyName = "NombreCategoria";
            NombreCat.HeaderText = "Nombre Categoria";
            NombreCat.Name = "NombreCat";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "DescripcionCategoria";
            Descripcion.HeaderText = "Cat Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 140;
            // 
            // FrmContInfoVehi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoContInfoGen;
            ClientSize = new Size(627, 424);
            Controls.Add(dataInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContInfoVehi";
            Text = "FrmContInfoVehi";
            Load += FrmContInfoVehi_Load;
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn IdVehiculo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn NombreCat;
        private DataGridViewTextBoxColumn Descripcion;
    }
}