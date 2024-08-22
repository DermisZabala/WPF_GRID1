using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Grid1
{
    public partial class MainWindow : Window
    {
        private double valorActual = 0; // Almacena el valor actual que se está ingresando
        private double valorAnterior = 0; // Almacena el valor antes de realizar la operación
        private string operacionActual = ""; // Almacena la operación seleccionada (+, -, X, etc.)

        public MainWindow()
        {
            InitializeComponent();
        }

        // Maneja los clics en los botones numéricos
        private void numero_Click(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;

            // Si el valor actual es "0", reemplazarlo con el número seleccionado
            if (Resultado.Text == "0" && boton.Content.ToString() != ".")
            {
                Resultado.Text = boton.Content.ToString();
            }
            else
            {
                Resultado.Text += boton.Content.ToString(); // Concatenar el número al valor existente
            }
        }

        // Maneja el clic en el botón "DELETE" para reiniciar la calculadora
        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = "0";
            valorActual = 0;
            valorAnterior = 0;
            operacionActual = "";
        }

        // Maneja el clic en el botón "+" para una suma
        private void suma_Click(object sender, RoutedEventArgs e)
        {
            valorAnterior = double.Parse(Resultado.Text); // Guardar el valor actual como anterior
            operacionActual = "+"; // Guardar la operación seleccionada
            Resultado.Text = "0"; // Reiniciar el texto para ingresar el siguiente número
        }

        // Maneja el clic en el botón "-" para una resta
        private void resta_Click(object sender, RoutedEventArgs e)
        {
            valorAnterior = double.Parse(Resultado.Text);
            operacionActual = "-";
            Resultado.Text = "0";
        }

        // Maneja el clic en el botón "X" para una multiplicación
        private void Multiplicar_Click(object sender, RoutedEventArgs e)
        {
            valorAnterior = double.Parse(Resultado.Text);
            operacionActual = "X";
            Resultado.Text = "0";
        }

        // Maneja el clic en el botón "=" para calcular el resultado
        private void signoIgual_Click(object sender, RoutedEventArgs e)
        {
            valorActual = double.Parse(Resultado.Text); // Guardar el valor actual

            // Realizar la operación correspondiente y mostrar el resultado
            switch (operacionActual)
            {
                case "+":
                    Resultado.Text = (valorAnterior + valorActual).ToString();
                    break;
                case "-":
                    Resultado.Text = (valorAnterior - valorActual).ToString();
                    break;
                case "X":
                    Resultado.Text = (valorAnterior * valorActual).ToString();
                    break;
                    // Se pueden agregar otras operaciones aquí
            }

            operacionActual = ""; // Reiniciar la operación
        }

        // Maneja el clic en el botón "." para agregar un punto decimal
        private void punto_Click(object sender, RoutedEventArgs e)
        {
            if (!Resultado.Text.Contains("."))
            {
                Resultado.Text += ".";
            }
        }

        // Asigna el evento clic a los botones numéricos
        private void numero1_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero2_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero3_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero4_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero5_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero6_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero7_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero8_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero9_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
        private void numero0_Click(object sender, RoutedEventArgs e) => numero_Click(sender, e);
    }
}
