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
            txtIdCategoria = new TextBox();
            dataPreviewRegistro = new DataGridView();
            IdCat = new DataGridViewTextBoxColumn();
            NombreCat = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            lblInfoVistaPrevia = new Label();
            ((System.ComponentModel.ISupportInitialize)dataPreviewRegistro).BeginInit();
            SuspendLayout();
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.BackColor = SystemColors.ActiveBorder;
            txtIdCategoria.Location = new Point(34, 52);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.PlaceholderText = "ID Categoria";
            txtIdCategoria.Size = new Size(283, 23);
            txtIdCategoria.TabIndex = 0;
            // 
            // dataPreviewRegistro
            // 
            dataPreviewRegistro.BackgroundColor = Color.LightGray;
            dataPreviewRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPreviewRegistro.Columns.AddRange(new DataGridViewColumn[] { IdCat, NombreCat, Descripcion });
            dataPreviewRegistro.Location = new Point(12, 324);
            dataPreviewRegistro.Name = "dataPreviewRegistro";
            dataPreviewRegistro.Size = new Size(868, 164);
            dataPreviewRegistro.TabIndex = 1;
            // 
            // IdCat
            // 
            IdCat.HeaderText = "ID Cat";
            IdCat.Name = "IdCat";
            IdCat.Width = 275;
            // 
            // NombreCat
            // 
            NombreCat.HeaderText = "Nombre Cat";
            NombreCat.Name = "NombreCat";
            NombreCat.Width = 275;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 275;
            // 
            // lblInfoVistaPrevia
            // 
            lblInfoVistaPrevia.AutoSize = true;
            lblInfoVistaPrevia.Location = new Point(18, 291);
            lblInfoVistaPrevia.Name = "lblInfoVistaPrevia";
            lblInfoVistaPrevia.Size = new Size(331, 15);
            lblInfoVistaPrevia.TabIndex = 2;
            lblInfoVistaPrevia.Text = "Vista Previa de Datos  a Registrar ( Visualice si estan correctos)";
            // 
            // FrmRegistrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.bgPnlContenedor;
            ClientSize = new Size(906, 547);
            Controls.Add(lblInfoVistaPrevia);
            Controls.Add(dataPreviewRegistro);
            Controls.Add(txtIdCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarCategoria";
            Text = "FrmRegistrarCategoria";
            ((System.ComponentModel.ISupportInitialize)dataPreviewRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCategoria;
        private DataGridView dataPreviewRegistro;
        private DataGridViewTextBoxColumn IdCat;
        private DataGridViewTextBoxColumn NombreCat;
        private DataGridViewTextBoxColumn Descripcion;
        private Label lblInfoVistaPrevia;
    }
}