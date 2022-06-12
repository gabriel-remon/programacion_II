namespace EjercicoC02__atrapame_si_puedes_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Mostrar = new System.Windows.Forms.RichTextBox();
            this.txt_kilometros = new System.Windows.Forms.TextBox();
            this.txt_Litros = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "kilometros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litros";
            // 
            // rtb_Mostrar
            // 
            this.rtb_Mostrar.Enabled = false;
            this.rtb_Mostrar.Location = new System.Drawing.Point(209, 21);
            this.rtb_Mostrar.Name = "rtb_Mostrar";
            this.rtb_Mostrar.Size = new System.Drawing.Size(314, 154);
            this.rtb_Mostrar.TabIndex = 2;
            this.rtb_Mostrar.Text = "";
            // 
            // txt_kilometros
            // 
            this.txt_kilometros.Location = new System.Drawing.Point(24, 47);
            this.txt_kilometros.Name = "txt_kilometros";
            this.txt_kilometros.Size = new System.Drawing.Size(160, 23);
            this.txt_kilometros.TabIndex = 3;
            // 
            // txt_Litros
            // 
            this.txt_Litros.Location = new System.Drawing.Point(24, 107);
            this.txt_Litros.Name = "txt_Litros";
            this.txt_Litros.Size = new System.Drawing.Size(160, 23);
            this.txt_Litros.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(24, 145);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(160, 30);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 186);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Litros);
            this.Controls.Add(this.txt_kilometros);
            this.Controls.Add(this.rtb_Mostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Mostrar;
        private System.Windows.Forms.TextBox txt_kilometros;
        private System.Windows.Forms.TextBox txt_Litros;
        private System.Windows.Forms.Button btn_Calcular;
    }
}
