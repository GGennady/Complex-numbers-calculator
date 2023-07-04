using System;
using System.IO;
using System.Windows.Forms;

namespace Calc {
    public partial class Form1 : Form {

        private const string ProtocolFilePath = "C:\\Files\\Programs\\C#\\Calc\\protocol.txt";

        public Form1() {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, EventArgs e) {
            try
            {
                double realPart1 = double.Parse(txtRealPart1.Text);
                double imaginaryPart1 = double.Parse(txtImaginaryPart1.Text);
                double realPart2 = double.Parse(txtRealPart2.Text);
                double imaginaryPart2 = double.Parse(txtImaginaryPart2.Text);

                ComplexNumber number1 = new ComplexNumber(realPart1, imaginaryPart1);
                ComplexNumber number2 = new ComplexNumber(realPart2, imaginaryPart2);

                ComplexNumber sum = number1 + number2;
                ComplexNumber difference = number1 - number2;
                ComplexNumber product = number1 * number2;
                ComplexNumber div = number1 / number2;

                WriteProtocol(number1, number2, sum, difference, product);

                lblSum.Text = sum.ToString();
                lblDifference.Text = difference.ToString();
                lblProduct.Text = product.ToString();
                lblDiv.Text = div.ToString();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WriteProtocol(ComplexNumber number1, ComplexNumber number2, ComplexNumber sum, ComplexNumber difference, ComplexNumber product) {
            string protocol = $"Исходные данные:\r\n" +
                              $"Комплексное число 1: {number1}\r\n" +
                              $"Комплексное число 2: {number2}\r\n" +
                              $"Выполненные операции:\r\n" +
                              $"Сложение: {number1} + {number2} = {sum}\r\n" +
                              $"Вычитание: {number1} - {number2} = {difference}\r\n" +
                              $"Умножение: {number1} * {number2} = {product}\r\n" +
                              $"Деление: {number1} / {number2} = {product}\r\n" +
                              $"-----------------------------------\r\n";
            File.AppendAllText(ProtocolFilePath, protocol);
        }
    }

    public class ComplexNumber {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double realPart, double imaginaryPart) {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
            double realPart = a.RealPart + b.RealPart;
            double imaginaryPart = a.ImaginaryPart + b.ImaginaryPart;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) {
            double realPart = a.RealPart - b.RealPart;
            double imaginaryPart = a.ImaginaryPart - b.ImaginaryPart;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) {
            double realPart = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
            double imaginaryPart = a.RealPart * b.ImaginaryPart + a.ImaginaryPart * b.RealPart;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b) {
            double divisor = b.RealPart * b.RealPart + b.ImaginaryPart * b.ImaginaryPart;
            if (divisor == 0)
                throw new DivideByZeroException();
            double realPart = (a.RealPart * b.RealPart + a.ImaginaryPart * b.ImaginaryPart) / divisor;
            double imaginaryPart = (a.RealPart * b.ImaginaryPart - a.ImaginaryPart * b.RealPart) / divisor;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString() {
            string sign = (ImaginaryPart >= 0) ? "+" : "-";
            return $"{RealPart} {sign} {Math.Abs(ImaginaryPart)}i";
        }

    }
}
