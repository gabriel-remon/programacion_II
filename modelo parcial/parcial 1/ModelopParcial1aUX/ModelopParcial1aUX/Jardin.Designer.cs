namespace ModelopParcial1aUX
{
    partial class Jardin
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
            this.btn_VerDatos = new System.Windows.Forms.Button();
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_VerDatos
            // 
            this.btn_VerDatos.Location = new System.Drawing.Point(516, 22);
            this.btn_VerDatos.Name = "btn_VerDatos";
            this.btn_VerDatos.Size = new System.Drawing.Size(130, 37);
            this.btn_VerDatos.TabIndex = 0;
            this.btn_VerDatos.Text = "Ver Datos";
            this.btn_VerDatos.UseVisualStyleBackColor = true;
            this.btn_VerDatos.Click += new System.EventHandler(this.btn_VerDatos_Click);
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(12, 76);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(650, 244);
            this.rtbSalidaDeTest.TabIndex = 1;
            this.rtbSalidaDeTest.Text = "";
            // 
            // Jardin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(674, 332);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Controls.Add(this.btn_VerDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jardin2";
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.Jardin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VerDatos;
        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}
