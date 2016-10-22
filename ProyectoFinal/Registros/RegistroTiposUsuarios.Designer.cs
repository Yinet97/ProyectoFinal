namespace ProyectoFinal
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
            this.Tipos_ConmoBox = new System.Windows.Forms.ComboBox();
            this.Boton_Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Clave = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.Boton_Nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tipos_ConmoBox
            // 
            this.Tipos_ConmoBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipos_ConmoBox.FormattingEnabled = true;
            this.Tipos_ConmoBox.Items.AddRange(new object[] {
            "Aministrador",
            "Empleado"});
            this.Tipos_ConmoBox.Location = new System.Drawing.Point(311, 250);
            this.Tipos_ConmoBox.Name = "Tipos_ConmoBox";
            this.Tipos_ConmoBox.Size = new System.Drawing.Size(228, 26);
            this.Tipos_ConmoBox.TabIndex = 9;
            // 
            // Boton_Buscar
            // 
            this.Boton_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Buscar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Buscar.Image = global::ProyectoFinal.Properties.Resources._40px_Icono_buscar;
            this.Boton_Buscar.Location = new System.Drawing.Point(403, 102);
            this.Boton_Buscar.Name = "Boton_Buscar";
            this.Boton_Buscar.Size = new System.Drawing.Size(52, 39);
            this.Boton_Buscar.TabIndex = 5;
            this.Boton_Buscar.UseVisualStyleBackColor = true;
            this.Boton_Buscar.Click += new System.EventHandler(this.Boton_Buscar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(134, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo Usuario";
            // 
            // textBox_Clave
            // 
            this.textBox_Clave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Clave.Location = new System.Drawing.Point(311, 205);
            this.textBox_Clave.Name = "textBox_Clave";
            this.textBox_Clave.Size = new System.Drawing.Size(228, 26);
            this.textBox_Clave.TabIndex = 5;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(311, 159);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(228, 26);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(311, 109);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(62, 26);
            this.textBox_ID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(194, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(171, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(150, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro de Usuario";
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Eliminar.Image = global::ProyectoFinal.Properties.Resources.cfl1401721102536_hiresdevice_es_es;
            this.Boton_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Eliminar.Location = new System.Drawing.Point(494, 319);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(155, 62);
            this.Boton_Eliminar.TabIndex = 10;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.BackColor = System.Drawing.Color.LavenderBlush;
            this.Boton_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Guardar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Guardar.Image = global::ProyectoFinal.Properties.Resources.save_32;
            this.Boton_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Guardar.Location = new System.Drawing.Point(283, 319);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(146, 62);
            this.Boton_Guardar.TabIndex = 9;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Guardar.UseVisualStyleBackColor = false;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // Boton_Nuevo
            // 
            this.Boton_Nuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Nuevo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Nuevo.Image = global::ProyectoFinal.Properties.Resources.anadir_mas_icono_6734_48;
            this.Boton_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_Nuevo.Location = new System.Drawing.Point(77, 319);
            this.Boton_Nuevo.Name = "Boton_Nuevo";
            this.Boton_Nuevo.Size = new System.Drawing.Size(140, 62);
            this.Boton_Nuevo.TabIndex = 8;
            this.Boton_Nuevo.Text = "Nuevo";
            this.Boton_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boton_Nuevo.UseVisualStyleBackColor = false;
            this.Boton_Nuevo.Click += new System.EventHandler(this.Boton_Nuevo_Click);
            // 
            // RegistroTiposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.Tipos_ConmoBox);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Buscar);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Boton_Nuevo);
            this.Controls.Add(this.textBox_Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RegistroTiposUsuarios";
            this.Text = "RegistroTiposUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.Button Boton_Nuevo;
        private System.Windows.Forms.ComboBox Tipos_ConmoBox;
        private System.Windows.Forms.Button Boton_Buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Clave;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}