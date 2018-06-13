namespace LabCarlosAguila
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bbuscar = new System.Windows.Forms.Button();
            this.Bactores = new System.Windows.Forms.Button();
            this.Bdirectores = new System.Windows.Forms.Button();
            this.Bproductor = new System.Windows.Forms.Button();
            this.Bestudio = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.Bclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(594, 187);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(115, 38);
            this.Bbuscar.TabIndex = 0;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bactores
            // 
            this.Bactores.Location = new System.Drawing.Point(226, 299);
            this.Bactores.Name = "Bactores";
            this.Bactores.Size = new System.Drawing.Size(108, 38);
            this.Bactores.TabIndex = 1;
            this.Bactores.Text = "Actores";
            this.Bactores.UseVisualStyleBackColor = true;
            this.Bactores.Click += new System.EventHandler(this.Bactores_Click);
            // 
            // Bdirectores
            // 
            this.Bdirectores.Location = new System.Drawing.Point(353, 299);
            this.Bdirectores.Name = "Bdirectores";
            this.Bdirectores.Size = new System.Drawing.Size(108, 38);
            this.Bdirectores.TabIndex = 2;
            this.Bdirectores.Text = "Directores";
            this.Bdirectores.UseVisualStyleBackColor = true;
            this.Bdirectores.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bproductor
            // 
            this.Bproductor.Location = new System.Drawing.Point(489, 299);
            this.Bproductor.Name = "Bproductor";
            this.Bproductor.Size = new System.Drawing.Size(108, 38);
            this.Bproductor.TabIndex = 3;
            this.Bproductor.Text = "Productores";
            this.Bproductor.UseVisualStyleBackColor = true;
            this.Bproductor.Click += new System.EventHandler(this.Bproductor_Click);
            // 
            // Bestudio
            // 
            this.Bestudio.Location = new System.Drawing.Point(625, 299);
            this.Bestudio.Name = "Bestudio";
            this.Bestudio.Size = new System.Drawing.Size(108, 38);
            this.Bestudio.TabIndex = 4;
            this.Bestudio.Text = "Estudio";
            this.Bestudio.UseVisualStyleBackColor = true;
            this.Bestudio.Click += new System.EventHandler(this.Bestudio_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(91, 114);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(496, 22);
            this.text.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(88, 84);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 17);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscador:";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(91, 143);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(496, 116);
            this.listbox.TabIndex = 7;
            this.listbox.Visible = false;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // Bclear
            // 
            this.Bclear.Location = new System.Drawing.Point(594, 143);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(115, 38);
            this.Bclear.TabIndex = 8;
            this.Bclear.Text = "Clear";
            this.Bclear.UseVisualStyleBackColor = true;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Peliculas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Bestudio);
            this.Controls.Add(this.Bproductor);
            this.Controls.Add(this.Bdirectores);
            this.Controls.Add(this.Bactores);
            this.Controls.Add(this.Bbuscar);
            this.Name = "Form1";
            this.Text = "Buscador de Cine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Button Bactores;
        private System.Windows.Forms.Button Bdirectores;
        private System.Windows.Forms.Button Bproductor;
        private System.Windows.Forms.Button Bestudio;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Button button1;
    }
}

