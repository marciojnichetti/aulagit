namespace CalculadoraIMC
{
    partial class FormPrincipal
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
            this.label_peso = new System.Windows.Forms.Label();
            this.label_altura = new System.Windows.Forms.Label();
            this.textbox_peso = new System.Windows.Forms.TextBox();
            this.textbox_altura = new System.Windows.Forms.TextBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(27, 36);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(125, 15);
            this.label_peso.TabIndex = 0;
            this.label_peso.Text = "Informe seu peso (kg):";
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(24, 81);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(128, 15);
            this.label_altura.TabIndex = 1;
            this.label_altura.Text = "Informe sua altura (m):";
            // 
            // textbox_peso
            // 
            this.textbox_peso.Location = new System.Drawing.Point(168, 33);
            this.textbox_peso.Name = "textbox_peso";
            this.textbox_peso.Size = new System.Drawing.Size(100, 23);
            this.textbox_peso.TabIndex = 2;
            this.textbox_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_peso_KeyPress);
            // 
            // textbox_altura
            // 
            this.textbox_altura.Location = new System.Drawing.Point(168, 78);
            this.textbox_altura.Name = "textbox_altura";
            this.textbox_altura.Size = new System.Drawing.Size(100, 23);
            this.textbox_altura.TabIndex = 3;
            this.textbox_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_altura_KeyPress);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(57, 171);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(95, 15);
            this.label_resultado.TabIndex = 4;
            this.label_resultado.Text = "Resultado (IMC):";
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(193, 125);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 5;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 202);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.textbox_altura);
            this.Controls.Add(this.textbox_peso);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.label_peso);
            this.Name = "FormPrincipal";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_peso;
        private Label label_altura;
        private TextBox textbox_peso;
        private TextBox textbox_altura;
        private Label label_resultado;
        private Button button_calcular;
    }
}