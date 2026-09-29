namespace Consultorio.Formularios
{
    partial class FrmCalendario
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
            dayContainer = new FlowLayoutPanel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelDato = new Label();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(10, 125);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1150, 612);
            dayContainer.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.Dock = DockStyle.Right;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Location = new Point(984, 0);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 49);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Dock = DockStyle.Right;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(1078, 0);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(94, 49);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSiguiente);
            panel1.Controls.Add(btnAnterior);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 761);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 49);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 66);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 4;
            label1.Text = "Domingo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 5;
            label2.Text = "Lunes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 66);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 6;
            label3.Text = "Martes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(543, 66);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 7;
            label4.Text = "Miercoles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(719, 66);
            label5.Name = "label5";
            label5.Size = new Size(56, 24);
            label5.TabIndex = 8;
            label5.Text = "Jueves";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(892, 66);
            label6.Name = "label6";
            label6.Size = new Size(59, 24);
            label6.TabIndex = 9;
            label6.Text = "Viernes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1042, 66);
            label7.Name = "label7";
            label7.Size = new Size(59, 24);
            label7.TabIndex = 10;
            label7.Text = "Sabado";
            // 
            // labelDato
            // 
            labelDato.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDato.Location = new Point(393, 9);
            labelDato.Name = "labelDato";
            labelDato.Size = new Size(377, 40);
            labelDato.TabIndex = 11;
            labelDato.Text = "MES AÑO";
            labelDato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1078, -2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 810);
            Controls.Add(btnCerrar);
            Controls.Add(labelDato);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalendario";
            Text = "Calendario";
            Load += FrmCalendario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelMes;
        private Label labelDato;
        private Button btnCerrar;
    }
}