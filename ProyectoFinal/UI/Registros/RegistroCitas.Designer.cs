﻿namespace ProyectoFinal.Registros
{
    partial class RegistroCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.ListaCitaDataGridView = new System.Windows.Forms.DataGridView();
            this.ClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.BuscarClienteBoton = new System.Windows.Forms.Button();
            this.IdClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.CitaGroupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarCitaBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdCitaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCitaDataGridView)).BeginInit();
            this.ClienteGroupBox.SuspendLayout();
            this.CitaGroupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ActualizarBoton);
            this.panel1.Controls.Add(this.ListaCitaDataGridView);
            this.panel1.Controls.Add(this.ClienteGroupBox);
            this.panel1.Controls.Add(this.CitaGroupBox1);
            this.panel1.Location = new System.Drawing.Point(53, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 395);
            this.panel1.TabIndex = 0;
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualizarBoton.BackColor = System.Drawing.Color.Khaki;
            this.ActualizarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBoton.Location = new System.Drawing.Point(350, 346);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(102, 37);
            this.ActualizarBoton.TabIndex = 46;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = false;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // ListaCitaDataGridView
            // 
            this.ListaCitaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaCitaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaCitaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ListaCitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCitaDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.ListaCitaDataGridView.Location = new System.Drawing.Point(77, 226);
            this.ListaCitaDataGridView.Name = "ListaCitaDataGridView";
            this.ListaCitaDataGridView.Size = new System.Drawing.Size(638, 109);
            this.ListaCitaDataGridView.TabIndex = 11;
            // 
            // ClienteGroupBox
            // 
            this.ClienteGroupBox.BackColor = System.Drawing.Color.White;
            this.ClienteGroupBox.Controls.Add(this.BuscarClienteBoton);
            this.ClienteGroupBox.Controls.Add(this.IdClienteTextBox);
            this.ClienteGroupBox.Controls.Add(this.label2);
            this.ClienteGroupBox.Controls.Add(this.label5);
            this.ClienteGroupBox.Controls.Add(this.ClienteTextBox);
            this.ClienteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteGroupBox.Location = new System.Drawing.Point(12, 36);
            this.ClienteGroupBox.Name = "ClienteGroupBox";
            this.ClienteGroupBox.Size = new System.Drawing.Size(360, 173);
            this.ClienteGroupBox.TabIndex = 1;
            this.ClienteGroupBox.TabStop = false;
            this.ClienteGroupBox.Text = "Cliente";
            // 
            // BuscarClienteBoton
            // 
            this.BuscarClienteBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarClienteBoton.BackColor = System.Drawing.Color.Khaki;
            this.BuscarClienteBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarClienteBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarClienteBoton.Location = new System.Drawing.Point(191, 27);
            this.BuscarClienteBoton.Name = "BuscarClienteBoton";
            this.BuscarClienteBoton.Size = new System.Drawing.Size(78, 37);
            this.BuscarClienteBoton.TabIndex = 4;
            this.BuscarClienteBoton.Text = "Buscar";
            this.BuscarClienteBoton.UseVisualStyleBackColor = false;
            this.BuscarClienteBoton.Click += new System.EventHandler(this.BuscarClienteBoton_Click);
            // 
            // IdClienteTextBox
            // 
            this.IdClienteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdClienteTextBox.Location = new System.Drawing.Point(83, 36);
            this.IdClienteTextBox.Name = "IdClienteTextBox";
            this.IdClienteTextBox.Size = new System.Drawing.Size(85, 26);
            this.IdClienteTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.ClienteTextBox.Location = new System.Drawing.Point(83, 79);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(240, 26);
            this.ClienteTextBox.TabIndex = 5;
            // 
            // CitaGroupBox1
            // 
            this.CitaGroupBox1.BackColor = System.Drawing.Color.White;
            this.CitaGroupBox1.Controls.Add(this.BuscarCitaBoton);
            this.CitaGroupBox1.Controls.Add(this.label1);
            this.CitaGroupBox1.Controls.Add(this.CitaDateTimePicker);
            this.CitaGroupBox1.Controls.Add(this.IdCitaTextBox);
            this.CitaGroupBox1.Controls.Add(this.label3);
            this.CitaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitaGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CitaGroupBox1.Location = new System.Drawing.Point(388, 36);
            this.CitaGroupBox1.Name = "CitaGroupBox1";
            this.CitaGroupBox1.Size = new System.Drawing.Size(360, 173);
            this.CitaGroupBox1.TabIndex = 10;
            this.CitaGroupBox1.TabStop = false;
            this.CitaGroupBox1.Text = "Cita";
            // 
            // BuscarCitaBoton
            // 
            this.BuscarCitaBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarCitaBoton.BackColor = System.Drawing.Color.Khaki;
            this.BuscarCitaBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarCitaBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCitaBoton.Location = new System.Drawing.Point(245, 32);
            this.BuscarCitaBoton.Name = "BuscarCitaBoton";
            this.BuscarCitaBoton.Size = new System.Drawing.Size(82, 31);
            this.BuscarCitaBoton.TabIndex = 10;
            this.BuscarCitaBoton.Text = "Buscar";
            this.BuscarCitaBoton.UseVisualStyleBackColor = false;
            this.BuscarCitaBoton.Click += new System.EventHandler(this.BuscarCitaBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // CitaDateTimePicker
            // 
            this.CitaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CitaDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.CitaDateTimePicker.Checked = false;
            this.CitaDateTimePicker.CustomFormat = "dd/mm /yyyy    hh :mm tt";
            this.CitaDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CitaDateTimePicker.Location = new System.Drawing.Point(120, 80);
            this.CitaDateTimePicker.Name = "CitaDateTimePicker";
            this.CitaDateTimePicker.Size = new System.Drawing.Size(207, 27);
            this.CitaDateTimePicker.TabIndex = 3;
            // 
            // IdCitaTextBox
            // 
            this.IdCitaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdCitaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCitaTextBox.Location = new System.Drawing.Point(120, 35);
            this.IdCitaTextBox.Name = "IdCitaTextBox";
            this.IdCitaTextBox.Size = new System.Drawing.Size(110, 26);
            this.IdCitaTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario";
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoBoton.BackColor = System.Drawing.Color.Khaki;
            this.NuevoBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBoton.Location = new System.Drawing.Point(12, 42);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(160, 49);
            this.NuevoBoton.TabIndex = 1;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = false;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarBoton.BackColor = System.Drawing.Color.Khaki;
            this.EliminarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBoton.Location = new System.Drawing.Point(713, 41);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(160, 49);
            this.EliminarBoton.TabIndex = 2;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = false;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarBoton.BackColor = System.Drawing.Color.Khaki;
            this.GuardarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBoton.Location = new System.Drawing.Point(242, 41);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(163, 49);
            this.GuardarBoton.TabIndex = 3;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = false;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(-4, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 162);
            this.panel3.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 70);
            this.panel2.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel4.Controls.Add(this.GuardarBoton);
            this.panel4.Controls.Add(this.NuevoBoton);
            this.panel4.Controls.Add(this.EditarBoton);
            this.panel4.Controls.Add(this.EliminarBoton);
            this.panel4.Location = new System.Drawing.Point(0, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(923, 96);
            this.panel4.TabIndex = 45;
            // 
            // EditarBoton
            // 
            this.EditarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarBoton.BackColor = System.Drawing.Color.Khaki;
            this.EditarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBoton.Location = new System.Drawing.Point(472, 41);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(163, 49);
            this.EditarBoton.TabIndex = 46;
            this.EditarBoton.Text = "Editar";
            this.EditarBoton.UseVisualStyleBackColor = false;
            this.EditarBoton.Click += new System.EventHandler(this.EditarBoton_Click);
            // 
            // RegistroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(923, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroCitas";
            this.Text = "Registro Citas";
            this.Load += new System.EventHandler(this.RegistroCitas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaCitaDataGridView)).EndInit();
            this.ClienteGroupBox.ResumeLayout(false);
            this.ClienteGroupBox.PerformLayout();
            this.CitaGroupBox1.ResumeLayout(false);
            this.CitaGroupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.TextBox IdCitaTextBox;
        private System.Windows.Forms.DateTimePicker CitaDateTimePicker;
        private System.Windows.Forms.GroupBox ClienteGroupBox;
        private System.Windows.Forms.TextBox IdClienteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox CitaGroupBox1;
        private System.Windows.Forms.Button BuscarClienteBoton;
        private System.Windows.Forms.Button BuscarCitaBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ListaCitaDataGridView;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.Button EditarBoton;
    }
}