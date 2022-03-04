namespace BancoNaucalpan
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.LBL_nombre = new System.Windows.Forms.Label();
            this.BTN_regresar = new System.Windows.Forms.Button();
            this.BTN_confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_DatosPersonales = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_origen = new System.Windows.Forms.ComboBox();
            this.CBO_raza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_DatosPrestamo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_monto = new System.Windows.Forms.TextBox();
            this.CBO_cuotas = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_DatosPersonales.SuspendLayout();
            this.panel_DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_nombre
            // 
            this.LBL_nombre.AutoSize = true;
            this.LBL_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_nombre.Location = new System.Drawing.Point(12, 9);
            this.LBL_nombre.Name = "LBL_nombre";
            this.LBL_nombre.Size = new System.Drawing.Size(191, 37);
            this.LBL_nombre.TabIndex = 0;
            this.LBL_nombre.Text = "Bienvenido, ";
            // 
            // BTN_regresar
            // 
            this.BTN_regresar.BackColor = System.Drawing.Color.Maroon;
            this.BTN_regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_regresar.Location = new System.Drawing.Point(717, 426);
            this.BTN_regresar.Name = "BTN_regresar";
            this.BTN_regresar.Size = new System.Drawing.Size(75, 23);
            this.BTN_regresar.TabIndex = 1;
            this.BTN_regresar.Text = "Regresar";
            this.BTN_regresar.UseVisualStyleBackColor = false;
            this.BTN_regresar.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // BTN_confirmar
            // 
            this.BTN_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_confirmar.Location = new System.Drawing.Point(327, 340);
            this.BTN_confirmar.Name = "BTN_confirmar";
            this.BTN_confirmar.Size = new System.Drawing.Size(147, 70);
            this.BTN_confirmar.TabIndex = 2;
            this.BTN_confirmar.Text = "Confirmar solicitud";
            this.BTN_confirmar.UseVisualStyleBackColor = true;
            this.BTN_confirmar.Click += new System.EventHandler(this.BTN_confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(136, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(515, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle del préstamo";
            // 
            // panel_DatosPersonales
            // 
            this.panel_DatosPersonales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_DatosPersonales.Controls.Add(this.label4);
            this.panel_DatosPersonales.Controls.Add(this.CBO_origen);
            this.panel_DatosPersonales.Controls.Add(this.CBO_raza);
            this.panel_DatosPersonales.Controls.Add(this.label3);
            this.panel_DatosPersonales.Location = new System.Drawing.Point(42, 150);
            this.panel_DatosPersonales.Name = "panel_DatosPersonales";
            this.panel_DatosPersonales.Size = new System.Drawing.Size(372, 89);
            this.panel_DatosPersonales.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lugar de origen:";
            // 
            // CBO_origen
            // 
            this.CBO_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_origen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_origen.FormattingEnabled = true;
            this.CBO_origen.Location = new System.Drawing.Point(198, 53);
            this.CBO_origen.Name = "CBO_origen";
            this.CBO_origen.Size = new System.Drawing.Size(150, 21);
            this.CBO_origen.TabIndex = 3;
            // 
            // CBO_raza
            // 
            this.CBO_raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_raza.FormattingEnabled = true;
            this.CBO_raza.Location = new System.Drawing.Point(198, 14);
            this.CBO_raza.Name = "CBO_raza";
            this.CBO_raza.Size = new System.Drawing.Size(150, 21);
            this.CBO_raza.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Raza:";
            // 
            // panel_DatosPrestamo
            // 
            this.panel_DatosPrestamo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_DatosPrestamo.Controls.Add(this.label7);
            this.panel_DatosPrestamo.Controls.Add(this.label8);
            this.panel_DatosPrestamo.Controls.Add(this.TXT_monto);
            this.panel_DatosPrestamo.Controls.Add(this.CBO_cuotas);
            this.panel_DatosPrestamo.Location = new System.Drawing.Point(420, 150);
            this.panel_DatosPrestamo.Name = "panel_DatosPrestamo";
            this.panel_DatosPrestamo.Size = new System.Drawing.Size(372, 89);
            this.panel_DatosPrestamo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Monto del préstamo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cuotas:";
            // 
            // TXT_monto
            // 
            this.TXT_monto.Location = new System.Drawing.Point(198, 14);
            this.TXT_monto.Name = "TXT_monto";
            this.TXT_monto.Size = new System.Drawing.Size(150, 20);
            this.TXT_monto.TabIndex = 1;
            // 
            // CBO_cuotas
            // 
            this.CBO_cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBO_cuotas.FormattingEnabled = true;
            this.CBO_cuotas.Location = new System.Drawing.Point(198, 49);
            this.CBO_cuotas.Name = "CBO_cuotas";
            this.CBO_cuotas.Size = new System.Drawing.Size(150, 21);
            this.CBO_cuotas.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panel_DatosPrestamo);
            this.Controls.Add(this.panel_DatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_confirmar);
            this.Controls.Add(this.BTN_regresar);
            this.Controls.Add(this.LBL_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panel_DatosPersonales.ResumeLayout(false);
            this.panel_DatosPersonales.PerformLayout();
            this.panel_DatosPrestamo.ResumeLayout(false);
            this.panel_DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_nombre;
        private System.Windows.Forms.Button BTN_regresar;
        private System.Windows.Forms.Button BTN_confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_DatosPersonales;
        private System.Windows.Forms.Panel panel_DatosPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_origen;
        private System.Windows.Forms.ComboBox CBO_raza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_monto;
        private System.Windows.Forms.ComboBox CBO_cuotas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}