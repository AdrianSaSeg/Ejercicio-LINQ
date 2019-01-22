namespace EjercicioLINQ
{
    partial class FormInsertar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonFormInsertar = new System.Windows.Forms.Button();
            this.buttonFormCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(97, 28);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(56, 20);
            this.textBoxEdad.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(97, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(128, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(97, 111);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(128, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // buttonFormInsertar
            // 
            this.buttonFormInsertar.Location = new System.Drawing.Point(44, 174);
            this.buttonFormInsertar.Name = "buttonFormInsertar";
            this.buttonFormInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonFormInsertar.TabIndex = 6;
            this.buttonFormInsertar.Text = "Insertar";
            this.buttonFormInsertar.UseVisualStyleBackColor = true;
            this.buttonFormInsertar.Click += new System.EventHandler(this.buttonFormInsertar_Click);
            // 
            // buttonFormCancelar
            // 
            this.buttonFormCancelar.Location = new System.Drawing.Point(178, 174);
            this.buttonFormCancelar.Name = "buttonFormCancelar";
            this.buttonFormCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonFormCancelar.TabIndex = 7;
            this.buttonFormCancelar.Text = "Cancelar";
            this.buttonFormCancelar.UseVisualStyleBackColor = true;
            this.buttonFormCancelar.Click += new System.EventHandler(this.buttonFormCancelar_Click);
            // 
            // FormInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 245);
            this.Controls.Add(this.buttonFormCancelar);
            this.Controls.Add(this.buttonFormInsertar);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertar";
            this.Text = "FormInsertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonFormInsertar;
        private System.Windows.Forms.Button buttonFormCancelar;
    }
}