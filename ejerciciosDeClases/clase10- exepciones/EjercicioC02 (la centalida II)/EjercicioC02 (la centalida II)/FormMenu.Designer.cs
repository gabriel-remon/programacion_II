namespace EjercicioC02__la_centalida_II_
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GenerarLlamada = new System.Windows.Forms.Button();
            this.btn_FacturacionTotal = new System.Windows.Forms.Button();
            this.btn_FacturacionLocal = new System.Windows.Forms.Button();
            this.btn_FacturacionProvincial = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerarLlamada
            // 
            this.btn_GenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btn_GenerarLlamada.Name = "btn_GenerarLlamada";
            this.btn_GenerarLlamada.Size = new System.Drawing.Size(180, 40);
            this.btn_GenerarLlamada.TabIndex = 0;
            this.btn_GenerarLlamada.Text = "Generar Llamada";
            this.btn_GenerarLlamada.UseVisualStyleBackColor = true;
            this.btn_GenerarLlamada.Click += new System.EventHandler(this.btn_GenerarLlamada_Click);
            // 
            // btn_FacturacionTotal
            // 
            this.btn_FacturacionTotal.Location = new System.Drawing.Point(12, 67);
            this.btn_FacturacionTotal.Name = "btn_FacturacionTotal";
            this.btn_FacturacionTotal.Size = new System.Drawing.Size(180, 40);
            this.btn_FacturacionTotal.TabIndex = 1;
            this.btn_FacturacionTotal.Text = "Facturacion Total";
            this.btn_FacturacionTotal.UseVisualStyleBackColor = true;
            this.btn_FacturacionTotal.Click += new System.EventHandler(this.btn_FacturacionTotal_Click);
            // 
            // btn_FacturacionLocal
            // 
            this.btn_FacturacionLocal.Location = new System.Drawing.Point(12, 126);
            this.btn_FacturacionLocal.Name = "btn_FacturacionLocal";
            this.btn_FacturacionLocal.Size = new System.Drawing.Size(180, 40);
            this.btn_FacturacionLocal.TabIndex = 3;
            this.btn_FacturacionLocal.Text = "Facturacion Local";
            this.btn_FacturacionLocal.UseVisualStyleBackColor = true;
            this.btn_FacturacionLocal.Click += new System.EventHandler(this.btn_FacturacionLocal_Click);
            // 
            // btn_FacturacionProvincial
            // 
            this.btn_FacturacionProvincial.Location = new System.Drawing.Point(12, 178);
            this.btn_FacturacionProvincial.Name = "btn_FacturacionProvincial";
            this.btn_FacturacionProvincial.Size = new System.Drawing.Size(180, 40);
            this.btn_FacturacionProvincial.TabIndex = 5;
            this.btn_FacturacionProvincial.Text = "Facturacion Provincial";
            this.btn_FacturacionProvincial.UseVisualStyleBackColor = true;
            this.btn_FacturacionProvincial.Click += new System.EventHandler(this.btn_FacturacionProvincial_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(12, 234);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(180, 40);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 294);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.btn_FacturacionProvincial);
            this.Controls.Add(this.btn_FacturacionLocal);
            this.Controls.Add(this.btn_FacturacionTotal);
            this.Controls.Add(this.btn_GenerarLlamada);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerarLlamada;
        private System.Windows.Forms.Button btn_FacturacionTotal;
        private System.Windows.Forms.Button btn_FacturacionLocal;
        private System.Windows.Forms.Button btn_FacturacionProvincial;
        private System.Windows.Forms.Button Btn_Salir;
    }
}
