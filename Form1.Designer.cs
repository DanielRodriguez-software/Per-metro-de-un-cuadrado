namespace Perimetro_de_un_cuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPantalla_principal = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.gbPantalla_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPantalla_principal
            // 
            this.gbPantalla_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbPantalla_principal.Controls.Add(this.lblError);
            this.gbPantalla_principal.Controls.Add(this.btnLimpiar);
            this.gbPantalla_principal.Controls.Add(this.btnResolver);
            this.gbPantalla_principal.Controls.Add(this.txtPerimetro);
            this.gbPantalla_principal.Controls.Add(this.txtLado);
            this.gbPantalla_principal.Controls.Add(this.lblPerimetro);
            this.gbPantalla_principal.Controls.Add(this.lblLado);
            this.gbPantalla_principal.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPantalla_principal.Location = new System.Drawing.Point(25, 35);
            this.gbPantalla_principal.Name = "gbPantalla_principal";
            this.gbPantalla_principal.Size = new System.Drawing.Size(639, 175);
            this.gbPantalla_principal.TabIndex = 0;
            this.gbPantalla_principal.TabStop = false;
            this.gbPantalla_principal.Text = "Pantalla principal";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(346, 135);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(44, 17);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Perimetro_de_un_cuadrado.Properties.Resources.icons8_broom_48;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(327, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 46);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Image = global::Perimetro_de_un_cuadrado.Properties.Resources.icons8_add_48;
            this.btnResolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResolver.Location = new System.Drawing.Point(313, 17);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(123, 50);
            this.btnResolver.TabIndex = 4;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(87, 78);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 24);
            this.txtPerimetro.TabIndex = 3;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.txtPerimetro_TextChanged);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(87, 35);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 24);
            this.txtLado.TabIndex = 2;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(6, 81);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(80, 17);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(15, 41);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(48, 17);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPantalla_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de un permietro de un cuadrado";
            this.gbPantalla_principal.ResumeLayout(false);
            this.gbPantalla_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPantalla_principal;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblError;
    }
}

