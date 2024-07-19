using System.ComponentModel.Design;
using System.Data;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += "0";
            textBox2.Text += "0";
        }


        Double resultado = 0;
        Double numerodos = 0;
        char operador = ' '; //permite saber que operacion se debe hacer cuando se le da al boton igual

        //void operacion(Double resultado, Double numerodos, char operador)
        //{
        //switch (operador)
        //{
        //    case '+':
        //        resultado += numerodos;
        //        break;
        //    case '-':
        //        resultado -= numerodos;
        //        break;
        //    case '*':
        //        resultado *= numerodos;
        //        break;
        //    case '/':
        //        resultado /= numerodos;
        //        break;
        //}
        //}

        private void suma_Click(object sender, EventArgs e)
        {
            //Se evalua si el valor del resultado es un valor inicial 0, o si ya se esta usando dicha variable en el calculo (osea, si ya se inicio a hacer un calculo)
            if (resultado == 0) { resultado = Convert.ToDouble(textBox1.Text); textBox1.Text = "0"; }
            else { numerodos = Convert.ToDouble(textBox1.Text); resultado += numerodos; textBox1.Text = "0"; numerodos = 0; }
            operador = '+';
            textBox2.Text += "+";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (resultado == 0) { resultado = Convert.ToDouble(textBox1.Text); textBox1.Text = "0"; }
            else { numerodos = Convert.ToDouble(textBox1.Text); resultado -= numerodos; textBox1.Text = "0"; numerodos = 0; }
            operador = '-';
            textBox2.Text += "-";
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            if (resultado == 0) { resultado = Convert.ToDouble(textBox1.Text); textBox1.Text = "0"; }
            else { numerodos = Convert.ToDouble(textBox1.Text); resultado *= numerodos; textBox1.Text = "0"; numerodos = 0; }
            operador = '*';
            textBox2.Text += "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (resultado == 0) { resultado = Convert.ToDouble(textBox1.Text); textBox1.Text = "0"; }
            else { numerodos = Convert.ToDouble(textBox1.Text); resultado /= numerodos; textBox1.Text = "0"; numerodos = 0; }
            operador = '/';
            textBox2.Text += "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            textBox1.Text += ".";
        }





        private void igual_Click(object sender, EventArgs e)
        {
            string registroOperaciones = textBox2.Text;

            switch (operador)
            {
                case '+':
                    resultado += Convert.ToDouble(textBox1.Text);
                    break;
                case '-':
                    resultado -= Convert.ToDouble(textBox1.Text);
                    break;
                case '*':
                    resultado *= Convert.ToDouble(textBox1.Text);
                    break;
                case '/':
                    resultado /= Convert.ToDouble(textBox1.Text);
                    break;
            }

            textBox1.Text = resultado.ToString();

            textBox2.Text = resultado.ToString();
            registroOperaciones += " = " + textBox2.Text;
            listBox1.Items.Add(registroOperaciones);
            numerodos = 0;
            resultado = 0;
            operador = ' ';

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1) { textBox1.Text = "0"; } else { textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numerodos = 0;
            resultado = 0;
            operador = ' ';
            textBox1.Text = "0";
            textBox2.Text = "0";
        }




        //private void igual_Click(object sender, EventArgs e)
        //{
        //    DataTable tablla = new DataTable();
        //    tablla.Columns.Add("Resultado", typeof(string));
        //    tablla.Rows.Add(textBox1.Text.ToString());
        //    Double total = Convert.ToDouble(tablla.Rows[0]["Resultado"]);
        //    textBox1.Text = total.ToString();
        //}
    }
}
