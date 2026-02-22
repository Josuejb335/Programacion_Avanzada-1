namespace CapaPresentacion
{
    partial class FrmContInfoCat
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
            IdCategoria = new DataGridViewTextBoxColumn();
            NombreCategoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { IdCategoria, NombreCategoria, Descripcion });
            dataInfo.Location = new Point(8, 12);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(611, 400);
            dataInfo.TabIndex = 2;
            dataInfo.CellContentClick += dataInfo_CellContentClick;
            // 
            // IdCategoria
            // 
            IdCategoria.DataPropertyName = "IdCategoria";
            IdCategoria.HeaderText = "ID Categoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            // 
            // NombreCategoria
            // 
            NombreCategoria.DataPropertyName = "NombreCategoria";
            NombreCategoria.HeaderText = "Nombre Categoria";
            NombreCategoria.Name = "NombreCategoria";
            NombreCategoria.ReadOnly = true;
            NombreCategoria.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 280;
            // 
            // FrmContInfoCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoContInfoGen;
            ClientSize = new Size(627, 424);
            Controls.Add(dataInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContInfoCat";
            Text = "FrmContInfoCat";
            Load += FrmContInfoCat_Load;
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn NombreCategoria;
        private DataGridViewTextBoxColumn Descripcion;
    }
}