﻿namespace ProyectoFinal
{
    partial class RegistroTiposUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTiposUsuarios));
            this.TiposComboBox = new System.Windows.Forms.ComboBox();
            this.Boton_Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.Boton_Nuevo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TiposComboBox
            // 
            this.TiposComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiposComboBox.FormattingEnabled = true;
            this.TiposComboBox.Items.AddRange(new object[] {
            "Aministrador",
            "Empleado"});
            this.TiposComboBox.Location = new System.Drawing.Point(311, 238);
            this.TiposComboBox.Name = "TiposComboBox";
            this.TiposComboBox.Size = new System.Drawing.Size(228, 26);
            this.TiposComboBox.TabIndex = 9;
            // 
            // Boton_Buscar
            // 
            this.Boton_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Buscar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Buscar.Image = global::ProyectoFinal.Properties.Resources._40px_Icono_buscar;
            this.Boton_Buscar.Location = new System.Drawing.Point(403, 90);
            this.Boton_Buscar.Name = "Boton_Buscar";
            this.Boton_Buscar.Size = new System.Drawing.Size(52, 39);
            this.Boton_Buscar.TabIndex = 5;
            this.Boton_Buscar.UseVisualStyleBackColor = false;
            this.Boton_Buscar.Click += new System.EventHandler(this.Boton_Buscar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(134, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo Usuario";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.Location = new System.Drawing.Point(311, 193);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(228, 26);
            this.ClaveTextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(311, 147);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(228, 26);
            this.NombreTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(311, 97);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(62, 26);
            this.IdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(194, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(171, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(150, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario ID";
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Eliminar.Image = global::ProyectoFinal.Properties.Resources.cfl1401721102536_hiresdevice_es_es;
            this.Boton_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Eliminar.Location = new System.Drawing.Point(529, 165);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(131, 52);
            this.Boton_Eliminar.TabIndex = 10;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Boton_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Guardar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Guardar.Image = global::ProyectoFinal.Properties.Resources.save_32;
            this.Boton_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Guardar.Location = new System.Drawing.Point(186, 165);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(139, 52);
            this.Boton_Guardar.TabIndex = 9;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Guardar.UseVisualStyleBackColor = false;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // Boton_Nuevo
            // 
            this.Boton_Nuevo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Boton_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Nuevo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Nuevo.Image = global::ProyectoFinal.Properties.Resources.anadir_mas_icono_6734_48;
            this.Boton_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Nuevo.Location = new System.Drawing.Point(23, 165);
            this.Boton_Nuevo.Name = "Boton_Nuevo";
            this.Boton_Nuevo.Size = new System.Drawing.Size(124, 52);
            this.Boton_Nuevo.TabIndex = 8;
            this.Boton_Nuevo.Text = "Nuevo";
            this.Boton_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Nuevo.UseVisualStyleBackColor = false;
            this.Boton_Nuevo.Click += new System.EventHandler(this.Boton_Nuevo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(102, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 225);
            this.panel4.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 174);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.EditarBoton);
            this.panel2.Controls.Add(this.Boton_Eliminar);
            this.panel2.Controls.Add(this.Boton_Nuevo);
            this.panel2.Controls.Add(this.Boton_Guardar);
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 228);
            this.panel2.TabIndex = 50;
            // 
            // EditarBoton
            // 
            this.EditarBoton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.EditarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBoton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBoton.Image = global::ProyectoFinal.Properties.Resources.save_32;
            this.EditarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarBoton.Location = new System.Drawing.Point(359, 165);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(135, 52);
            this.EditarBoton.TabIndex = 51;
            this.EditarBoton.Text = "Editar";
            this.EditarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarBoton.UseVisualStyleBackColor = false;
            this.EditarBoton.Click += new System.EventHandler(this.EditarBoton_Click);
            // 
            // RegistroTiposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TiposComboBox);
            this.Controls.Add(this.Boton_Buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroTiposUsuarios";
            this.Text = "RegistroTiposUsuarios";
            this.Load += new System.EventHandler(this.RegistroTiposUsuarios_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.Button Boton_Nuevo;
        private System.Windows.Forms.ComboBox TiposComboBox;
        private System.Windows.Forms.Button Boton_Buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditarBoton;
    }
}