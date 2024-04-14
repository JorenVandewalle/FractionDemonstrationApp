using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FractionLibrary;


namespace WpfFractionCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            leftNumerator.TextChanged += Fraction_TextChanged;
            leftDenominater.TextChanged += Fraction_TextChanged;
            rightNumerator.TextChanged += Fraction_TextChanged;
            rightDenominater.TextChanged += Fraction_TextChanged;
            specialNumerator.TextChanged += Fraction_TextChanged;
            specialDenominater.TextChanged += Fraction_TextChanged;
        }

        private void Fraction_TextChanged(object sender, TextChangedEventArgs e)
        {
            giveValue();
            giveSpecialValue();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            operation.Text = "+";
            fullRows.Visibility = Visibility.Visible;
            specialRows.Visibility = Visibility.Hidden;
            giveValue();
            giveSpecialValue();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            operation.Text = "-";
            fullRows.Visibility = Visibility.Visible;
            specialRows.Visibility = Visibility.Hidden;
            giveValue();
            giveSpecialValue();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation.Text = "*";
            fullRows.Visibility = Visibility.Visible;
            specialRows.Visibility = Visibility.Hidden;
            giveValue();
            giveSpecialValue();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation.Text = "/";
            fullRows.Visibility = Visibility.Visible;
            specialRows.Visibility = Visibility.Hidden;
            giveValue();
            giveSpecialValue();
        }

        private void Reciprocal_Click(object sender, RoutedEventArgs e)
        {
            operationSpecial.Text = "1/F";
            fullRows.Visibility = Visibility.Hidden;
            specialRows.Visibility = Visibility.Visible;
            giveValue();
            giveSpecialValue();
        }

        private void Invert_Click(object sender, RoutedEventArgs e)
        {
            operationSpecial.Text = "-F";
            fullRows.Visibility = Visibility.Hidden;
            specialRows.Visibility = Visibility.Visible;
            giveValue();
            giveSpecialValue();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            this.Hide();
            aboutWindow.Show();
        }

        private Fraction leftFraction = new Fraction();
        private Fraction rightFraction = new Fraction();
        private Fraction resultFraction = new Fraction();

        private Fraction specialFraction = new Fraction();
        private Fraction resultSpecialFraction = new Fraction();

        public void giveValue()
        {
            if (!string.IsNullOrEmpty(leftNumerator.Text) && !string.IsNullOrEmpty(leftDenominater.Text) &&
            !string.IsNullOrEmpty(rightNumerator.Text) && !string.IsNullOrEmpty(rightDenominater.Text))
            {
                if (!int.TryParse(leftNumerator.Text, out int _) || !int.TryParse(leftDenominater.Text, out int _)) return;

                leftFraction.Numerator = int.Parse(leftNumerator.Text);
                leftFraction.Denominator = int.Parse(leftDenominater.Text);

                if (!int.TryParse(rightDenominater.Text, out int _) || !int.TryParse(rightNumerator.Text, out int _)) return;   

                rightFraction.Numerator = int.Parse(rightNumerator.Text);
                rightFraction.Denominator = int.Parse(rightDenominater.Text);



                if (leftDenominater.Text == "0")
                {
                    leftDenominater.Text = "1";
                    MessageBox.Show("Denominator can't be 0! It has changed to 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (rightDenominater.Text == "0")
                {
                    rightDenominater.Text = "1";
                    MessageBox.Show("Denominator can't be 0! It has changed to 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (operation.Text == "+")
                {
                    resultFraction = leftFraction.Add(rightFraction).Simplify();
                }
                if (operation.Text == "-")
                {
                    resultFraction = leftFraction.Subtract(rightFraction).Simplify();

                }
                if (operation.Text == "*")
                {
                    resultFraction = leftFraction.Multiply(rightFraction).Simplify();

                }
                if (operation.Text == "/")
                {
                    if (rightNumerator.Text == "0")
                    {
                        rightNumerator.Text = "1";
                        MessageBox.Show("Cannot divide by zero! It has changed to 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    resultFraction = leftFraction.Divide(rightFraction).Simplify();

                }
                resultNumerator.Text = resultFraction.Numerator.ToString();
                resultDenominater.Text = resultFraction.Denominator.ToString();

                resultDouble.Text = resultFraction.Result().ToString();
            }
        }

        public void giveSpecialValue()
        {
            if (!string.IsNullOrEmpty(specialNumerator.Text) && !string.IsNullOrEmpty(specialDenominater.Text))
            {
                if (!int.TryParse(specialNumerator.Text, out int _) || !int.TryParse(specialDenominater.Text, out int _)) return;

                specialFraction.Numerator = int.Parse(specialNumerator.Text);
                specialFraction.Denominator = int.Parse(specialDenominater.Text);


                if (operationSpecial.Text == "1/F")
                {
                    resultSpecialFraction = specialFraction.Reciprocal();
                }
                if (operationSpecial.Text == "-F")
                {
                    resultSpecialFraction = specialFraction.Invert();
                }

                resultSpecialNumerator.Text = resultSpecialFraction.Numerator.ToString();
                resultSpecialDenominater.Text = resultSpecialFraction.Denominator.ToString();
            }
        }
    }
}