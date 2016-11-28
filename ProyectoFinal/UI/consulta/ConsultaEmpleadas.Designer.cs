namespace ProyectoFinal.consulta
{
    partial class ConsultaEmpleadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEmpleadas));
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.ImprimirReporteBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoConsulta
            // 
            this.listadoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.listadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoConsulta.Location = new System.Drawing.Point(37, 129);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(718, 186);
            this.listadoConsulta.TabIndex = 0;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.Location = new System.Drawing.Point(519, 44);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(152, 49);
            this.BotonBuscar.TabIndex = 1;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(91, 56);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(390, 27);
            this.textBoxID.TabIndex = 2;
            // 
            // ImprimirReporteBoton
            // 
            this.ImprimirReporteBoton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ImprimirReporteBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirReporteBoton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirReporteBoton.Location = new System.Drawing.Point(312, 332);
            this.ImprimirReporteBoton.Name = "ImprimirReporteBoton";
            this.ImprimirReporteBoton.Size = new System.Drawing.Size(180, 49);
            this.ImprimirReporteBoton.TabIndex = 3;
            this.ImprimirReporteBoton.Text = "Imprimir Reporte";
            this.ImprimirReporteBoton.UseVisualStyleBackColor = false;
            this.ImprimirReporteBoton.Click += new System.EventHandler(this.ImprimirReporteBoton_Click);
            // 
            // ConsultaEmpleadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.ImprimirReporteBoton);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.listadoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaEmpleadas";
            this.Text = "ConsultaEmpleadas";
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoConsulta;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button ImprimirReporteBoton;
    }
}