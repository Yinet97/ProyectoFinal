﻿namespace ProyectoFinal.consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCitas));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrarFechaBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImprmirReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(178, 33);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(361, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.LightCoral;
            this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonBuscar.Location = new System.Drawing.Point(547, 21);
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
            this.listadoConsulta.Location = new System.Drawing.Point(12, 172);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(749, 186);
            this.listadoConsulta.TabIndex = 6;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(135, 107);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(118, 30);
            this.DesdeDateTimePicker.TabIndex = 9;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(303, 107);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(128, 30);
            this.HastaDateTimePicker.TabIndex = 10;
            // 
            // FiltrarFechaBoton
            // 
            this.FiltrarFechaBoton.BackColor = System.Drawing.Color.LightCoral;
            this.FiltrarFechaBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrarFechaBoton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarFechaBoton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FiltrarFechaBoton.Location = new System.Drawing.Point(462, 99);
            this.FiltrarFechaBoton.Name = "FiltrarFechaBoton";
            this.FiltrarFechaBoton.Size = new System.Drawing.Size(194, 38);
            this.FiltrarFechaBoton.TabIndex = 11;
            this.FiltrarFechaBoton.Text = "Filtrar";
            this.FiltrarFechaBoton.UseVisualStyleBackColor = false;
            this.FiltrarFechaBoton.Click += new System.EventHandler(this.FiltrarFechaBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(132, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(384, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(272, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(79, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID o Nombre";
            // 
            // ImprmirReporte
            // 
            this.ImprmirReporte.BackColor = System.Drawing.Color.LightCoral;
            this.ImprmirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprmirReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprmirReporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ImprmirReporte.Location = new System.Drawing.Point(303, 380);
            this.ImprmirReporte.Name = "ImprmirReporte";
            this.ImprmirReporte.Size = new System.Drawing.Size(152, 49);
            this.ImprmirReporte.TabIndex = 16;
            this.ImprmirReporte.Text = "Imprimir Reporte";
            this.ImprmirReporte.UseVisualStyleBackColor = false;
            this.ImprmirReporte.Click += new System.EventHandler(this.ImprmirReporte_Click);
            // 
            // ConsultaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(772, 441);
            this.Controls.Add(this.ImprmirReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarFechaBoton);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.listadoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ImprmirReporte;
    }
}