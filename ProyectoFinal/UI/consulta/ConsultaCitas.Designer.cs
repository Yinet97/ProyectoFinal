namespace ProyectoFinal.consulta
{
    partial class ConsultaCitas
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrarFechaBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(79, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(361, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.Chocolate;
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonBuscar.Location = new System.Drawing.Point(471, 25);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(152, 49);
            this.BotonBuscar.TabIndex = 7;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // listadoConsulta
            // 
            this.listadoConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.listadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoConsulta.GridColor = System.Drawing.Color.LavenderBlush;
            this.listadoConsulta.Location = new System.Drawing.Point(11, 144);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(718, 186);
            this.listadoConsulta.TabIndex = 6;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(102, 85);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(97, 24);
            this.DesdeDateTimePicker.TabIndex = 9;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(250, 85);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(97, 24);
            this.HastaDateTimePicker.TabIndex = 10;
            // 
            // FiltrarFechaBoton
            // 
            this.FiltrarFechaBoton.BackColor = System.Drawing.Color.Chocolate;
            this.FiltrarFechaBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrarFechaBoton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarFechaBoton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FiltrarFechaBoton.Location = new System.Drawing.Point(376, 85);
            this.FiltrarFechaBoton.Name = "FiltrarFechaBoton";
            this.FiltrarFechaBoton.Size = new System.Drawing.Size(76, 34);
            this.FiltrarFechaBoton.TabIndex = 11;
            this.FiltrarFechaBoton.Text = "Buscar";
            this.FiltrarFechaBoton.UseVisualStyleBackColor = false;
            // 
            // ConsultaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(740, 388);
            this.Controls.Add(this.FiltrarFechaBoton);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.listadoConsulta);
            this.Name = "ConsultaCitas";
            this.Text = "Consulta Citas";
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView listadoConsulta;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Button FiltrarFechaBoton;
    }
}