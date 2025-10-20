namespace PilaApp
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTope = new System.Windows.Forms.Button();
            this.Pila = new System.Windows.Forms.ListBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbCargos = new System.Windows.Forms.TextBox();
            this.tbSalarios = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCargos = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(117, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnTope
            // 
            this.btnTope.Location = new System.Drawing.Point(207, 163);
            this.btnTope.Name = "btnTope";
            this.btnTope.Size = new System.Drawing.Size(75, 23);
            this.btnTope.TabIndex = 3;
            this.btnTope.Text = "Ver Tope";
            this.btnTope.UseVisualStyleBackColor = true;
            // 
            // Pila
            // 
            this.Pila.FormattingEnabled = true;
            this.Pila.Location = new System.Drawing.Point(79, 215);
            this.Pila.Name = "Pila";
            this.Pila.Size = new System.Drawing.Size(169, 173);
            this.Pila.TabIndex = 4;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(126, 61);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 5;
            // 
            // tbCargos
            // 
            this.tbCargos.Location = new System.Drawing.Point(126, 87);
            this.tbCargos.Name = "tbCargos";
            this.tbCargos.Size = new System.Drawing.Size(100, 20);
            this.tbCargos.TabIndex = 6;
            // 
            // tbSalarios
            // 
            this.tbSalarios.Location = new System.Drawing.Point(126, 113);
            this.tbSalarios.Name = "tbSalarios";
            this.tbSalarios.Size = new System.Drawing.Size(100, 20);
            this.tbSalarios.TabIndex = 7;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(48, 61);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 8;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Location = new System.Drawing.Point(51, 87);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(40, 13);
            this.lblCargos.TabIndex = 9;
            this.lblCargos.Text = "Cargos";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(54, 113);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 10;
            this.lblSalario.Text = "Salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.tbSalarios);
            this.Controls.Add(this.tbCargos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.Pila);
            this.Controls.Add(this.btnTope);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTope;
        private System.Windows.Forms.ListBox Pila;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCargos;
        private System.Windows.Forms.TextBox tbSalarios;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Label lblSalario;
    }
}

