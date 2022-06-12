namespace EjercicioC02__la_centalida_II_
{
    partial class FrmMostrar
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
            this.rtb_Mostrar = new System.Windows.Forms.RichTextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Mostrar
            // 
            this.rtb_Mostrar.Location = new System.Drawing.Point(12, 12);
            this.rtb_Mostrar.Name = "rtb_Mostrar";
            this.rtb_Mostrar.Size = new System.Drawing.Size(295, 261);
            this.rtb_Mostrar.TabIndex = 0;
            this.rtb_Mostrar.Text = "";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(96, 281);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(131, 33);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 326);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.rtb_Mostrar);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Mostrar;
        private System.Windows.Forms.Button btn_Salir;
    }
}