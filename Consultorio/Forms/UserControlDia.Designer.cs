namespace Consultorio.Formularios
{
    partial class UserControlDia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            IdDia = new Label();
            SuspendLayout();
            // 
            // IdDia
            // 
            IdDia.AutoSize = true;
            IdDia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdDia.Location = new Point(67, 31);
            IdDia.Name = "IdDia";
            IdDia.Size = new Size(34, 28);
            IdDia.TabIndex = 0;
            IdDia.Text = "00";
            // 
            // UserControlDia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(IdDia);
            Name = "UserControlDia";
            Size = new Size(158, 85);
            Load += UserControlIDDia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdDia;
    }
}
