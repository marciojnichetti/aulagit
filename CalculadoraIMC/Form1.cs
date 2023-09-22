namespace CalculadoraIMC
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            label_resultado.Text = "Resultado --> " + String.Format("{0:F2}", (Convert.ToDecimal(textbox_peso.Text) / (Convert.ToDecimal(textbox_altura.Text) * Convert.ToDecimal(textbox_altura.Text))));
        }

        private void textbox_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada � um n�mero, uma v�rgula ou a tecla de retrocesso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Se n�o for um n�mero, uma v�rgula ou a tecla de retrocesso, cancela a entrada
                e.Handled = true;
            }

            // Certifica-se de que haja apenas uma v�rgula permitida no TextBox
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void textbox_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada � um n�mero, uma v�rgula ou a tecla de retrocesso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Se n�o for um n�mero, uma v�rgula ou a tecla de retrocesso, cancela a entrada
                e.Handled = true;
            }

            // Certifica-se de que haja apenas uma v�rgula permitida no TextBox
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}