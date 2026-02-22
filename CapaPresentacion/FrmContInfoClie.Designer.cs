namespace CapaPresentacion
{
    partial class FrmContInfoClie
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
            IdCliente = new DataGridViewTextBoxColumn();
            registro = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nacimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { IdCliente, registro, Activo, Identificacion, Nombre, Nacimiento });
            dataInfo.Location = new Point(12, 12);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(603, 400);
            dataInfo.TabIndex = 3;
            dataInfo.CellFormatting += dataInfo_CellFormatting;
            // 
            // IdCliente
            // 
            IdCliente.DataPropertyName = "IdCliente";
            IdCliente.HeaderText = "ID Clie";
            IdCliente.Name = "IdCliente";
            IdCliente.Width = 50;
            // 
            // registro
            // 
            registro.DataPropertyName = "FechaRegistro";
            registro.HeaderText = "Fecha Registro";
            registro.Name = "registro";
            registro.Width = 90;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            Activo.Width = 70;
            // 
            // Identificacion
            // 
            Identificacion.DataPropertyName = "Identificacion";
            Identificacion.HeaderText = "Identificacion";
            Identificacion.Name = "Identificacion";
            Identificacion.Width = 80;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 180;
            // 
            // Nacimiento
            // 
            Nacimiento.DataPropertyName = "FechaNacimiento";
            Nacimiento.HeaderText = "Fecha Nacimiento";
            Nacimiento.Name = "Nacimiento";
            Nacimiento.Width = 90;
            // 
            // FrmContInfoClie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoContInfoGen;
            ClientSize = new Size(627, 424);
            Controls.Add(dataInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContInfoClie";
            Text = "FrmContInfoClie";
            Load += FrmContInfoClie_Load;
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn registro;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nacimiento;
    }
}