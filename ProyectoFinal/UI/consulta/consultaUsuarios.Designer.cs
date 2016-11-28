namespace ProyectoFinal
{
    partial class consultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaUsuarios));
            this.listadoConsulta = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoConsulta
            // 
            this.listadoConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoConsulta.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoConsulta.Location = new System.Drawing.Point(28, 113);
            this.listadoConsulta.Name = "listadoConsulta";
            this.listadoConsulta.Size = new System.Drawing.Size(672, 205);
            this.listadoConsulta.TabIndex = 0;
            // 
            // botonConsultar
            // 
            this.botonConsultar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.botonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(533, 27);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(112, 44);
            this.botonConsultar.TabIndex = 1;
            this.botonConsultar.Text = "consultar";
            this.botonConsultar.UseVisualStyleBackColor = false;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 26);
            this.textBox1.TabIndex = 2;
            // 
            // consultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(737, 404);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.listadoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultaUsuarios";
            this.Text = "consultaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.listadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoConsulta;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.TextBox textBox1;
    }
}