namespace Ejercicio5Colores
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnazul = new System.Windows.Forms.Button();
            this.btnamarillo = new System.Windows.Forms.Button();
            this.btnrojo = new System.Windows.Forms.Button();
            this.brnverde = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(97, 27);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(613, 39);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Seleccione el color de fondo que desea";
            // 
            // btnazul
            // 
            this.btnazul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnazul.Location = new System.Drawing.Point(129, 166);
            this.btnazul.Name = "btnazul";
            this.btnazul.Size = new System.Drawing.Size(105, 33);
            this.btnazul.TabIndex = 1;
            this.btnazul.Text = "Azul";
            this.btnazul.UseVisualStyleBackColor = true;
            this.btnazul.Click += new System.EventHandler(this.Btnazul_Click);
            // 
            // btnamarillo
            // 
            this.btnamarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamarillo.Location = new System.Drawing.Point(327, 166);
            this.btnamarillo.Name = "btnamarillo";
            this.btnamarillo.Size = new System.Drawing.Size(119, 33);
            this.btnamarillo.TabIndex = 2;
            this.btnamarillo.Text = "Amarillo";
            this.btnamarillo.UseVisualStyleBackColor = true;
            this.btnamarillo.Click += new System.EventHandler(this.Btnamarillo_Click);
            // 
            // btnrojo
            // 
            this.btnrojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrojo.Location = new System.Drawing.Point(560, 166);
            this.btnrojo.Name = "btnrojo";
            this.btnrojo.Size = new System.Drawing.Size(109, 33);
            this.btnrojo.TabIndex = 3;
            this.btnrojo.Text = "Rojo";
            this.btnrojo.UseVisualStyleBackColor = true;
            this.btnrojo.Click += new System.EventHandler(this.Btnrojo_Click);
            // 
            // brnverde
            // 
            this.brnverde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnverde.Location = new System.Drawing.Point(191, 268);
            this.brnverde.Name = "brnverde";
            this.brnverde.Size = new System.Drawing.Size(97, 34);
            this.brnverde.TabIndex = 4;
            this.brnverde.Text = "Verde";
            this.brnverde.UseVisualStyleBackColor = true;
            this.brnverde.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btncafe
            // 
            this.btncafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncafe.Location = new System.Drawing.Point(492, 268);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(107, 34);
            this.btncafe.TabIndex = 5;
            this.btncafe.Text = "Marron";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.Btncafe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncafe);
            this.Controls.Add(this.brnverde);
            this.Controls.Add(this.btnrojo);
            this.Controls.Add(this.btnamarillo);
            this.Controls.Add(this.btnazul);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fondo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnazul;
        private System.Windows.Forms.Button btnamarillo;
        private System.Windows.Forms.Button btnrojo;
        private System.Windows.Forms.Button brnverde;
        private System.Windows.Forms.Button btncafe;
    }
}

