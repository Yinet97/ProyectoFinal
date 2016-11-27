namespace ProyectoFinal
{
    partial class Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.MontoAdicionalTextBox = new System.Windows.Forms.TextBox();
            this.ComentarioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ServiciosComboBox = new System.Windows.Forms.ComboBox();
            this.ServiciosDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.TipoPagoTextBox = new System.Windows.Forms.TextBox();
            this.PorcientoDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto Adicional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(751, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.TotalTextBox.Location = new System.Drawing.Point(816, 604);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(93, 26);
            this.TotalTextBox.TabIndex = 7;
            this.TotalTextBox.Text = "0.00";
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "$ Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo de Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Comentario";
            // 
            // FechaActualDateTimePicker
            // 
            this.FechaActualDateTimePicker.Enabled = false;
            this.FechaActualDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaActualDateTimePicker.Location = new System.Drawing.Point(686, 25);
            this.FechaActualDateTimePicker.Name = "FechaActualDateTimePicker";
            this.FechaActualDateTimePicker.Size = new System.Drawing.Size(223, 23);
            this.FechaActualDateTimePicker.TabIndex = 14;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(109, 25);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(68, 34);
            this.BuscarBoton.TabIndex = 15;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(30, 594);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(99, 52);
            this.NuevoBoton.TabIndex = 16;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(251, 594);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(112, 52);
            this.GuardarBoton.TabIndex = 17;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(500, 594);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(105, 52);
            this.EliminarBoton.TabIndex = 18;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(42, 29);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(49, 26);
            this.IdTextBox.TabIndex = 19;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(194, 140);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(273, 26);
            this.NombreClienteTextBox.TabIndex = 20;
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpuestoTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.ImpuestoTextBox.Location = new System.Drawing.Point(645, 143);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.Size = new System.Drawing.Size(94, 26);
            this.ImpuestoTextBox.TabIndex = 21;
            this.ImpuestoTextBox.Text = "18";
            this.ImpuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescuentoTextBox.Location = new System.Drawing.Point(645, 182);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(94, 26);
            this.DescuentoTextBox.TabIndex = 22;
            this.DescuentoTextBox.Text = "0";
            this.DescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MontoAdicionalTextBox
            // 
            this.MontoAdicionalTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoAdicionalTextBox.Location = new System.Drawing.Point(645, 271);
            this.MontoAdicionalTextBox.Name = "MontoAdicionalTextBox";
            this.MontoAdicionalTextBox.Size = new System.Drawing.Size(94, 26);
            this.MontoAdicionalTextBox.TabIndex = 23;
            this.MontoAdicionalTextBox.Text = "0";
            this.MontoAdicionalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComentarioRichTextBox
            // 
            this.ComentarioRichTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComentarioRichTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ComentarioRichTextBox.Location = new System.Drawing.Point(194, 234);
            this.ComentarioRichTextBox.Name = "ComentarioRichTextBox";
            this.ComentarioRichTextBox.Size = new System.Drawing.Size(273, 63);
            this.ComentarioRichTextBox.TabIndex = 25;
            this.ComentarioRichTextBox.Text = "Comentario";
            // 
            // ServiciosComboBox
            // 
            this.ServiciosComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosComboBox.FormattingEnabled = true;
            this.ServiciosComboBox.Location = new System.Drawing.Point(325, 326);
            this.ServiciosComboBox.Name = "ServiciosComboBox";
            this.ServiciosComboBox.Size = new System.Drawing.Size(307, 26);
            this.ServiciosComboBox.TabIndex = 26;
            // 
            // ServiciosDataGridView
            // 
            this.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiciosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiciosDataGridView.Location = new System.Drawing.Point(72, 377);
            this.ServiciosDataGridView.Name = "ServiciosDataGridView";
            this.ServiciosDataGridView.Size = new System.Drawing.Size(767, 168);
            this.ServiciosDataGridView.TabIndex = 27;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(662, 318);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(107, 43);
            this.AgregarBoton.TabIndex = 28;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // TipoPagoTextBox
            // 
            this.TipoPagoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPagoTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.TipoPagoTextBox.Location = new System.Drawing.Point(194, 185);
            this.TipoPagoTextBox.Name = "TipoPagoTextBox";
            this.TipoPagoTextBox.Size = new System.Drawing.Size(273, 26);
            this.TipoPagoTextBox.TabIndex = 29;
            // 
            // PorcientoDescuentoTextBox
            // 
            this.PorcientoDescuentoTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorcientoDescuentoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PorcientoDescuentoTextBox.Location = new System.Drawing.Point(645, 226);
            this.PorcientoDescuentoTextBox.Name = "PorcientoDescuentoTextBox";
            this.PorcientoDescuentoTextBox.Size = new System.Drawing.Size(94, 26);
            this.PorcientoDescuentoTextBox.TabIndex = 31;
            this.PorcientoDescuentoTextBox.Text = "0";
            this.PorcientoDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(542, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "% Descuento";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.ForeColor = System.Drawing.Color.Orange;
            this.SubTotalTextBox.Location = new System.Drawing.Point(816, 563);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(93, 26);
            this.SubTotalTextBox.TabIndex = 33;
            this.SubTotalTextBox.Text = "0.00";
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "SubTotal";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 671);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PorcientoDescuentoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TipoPagoTextBox);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.ServiciosDataGridView);
            this.Controls.Add(this.ServiciosComboBox);
            this.Controls.Add(this.ComentarioRichTextBox);
            this.Controls.Add(this.MontoAdicionalTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.ImpuestoTextBox);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.FechaActualDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker FechaActualDateTimePicker;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox MontoAdicionalTextBox;
        private System.Windows.Forms.RichTextBox ComentarioRichTextBox;
        private System.Windows.Forms.ComboBox ServiciosComboBox;
        private System.Windows.Forms.DataGridView ServiciosDataGridView;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.TextBox TipoPagoTextBox;
        private System.Windows.Forms.TextBox PorcientoDescuentoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label2;
    }
}