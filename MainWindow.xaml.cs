using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("7");
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("8");
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("9");
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("4");
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("5");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("6");
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("1");
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("2");
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("3");
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("0");
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(Environment.NewLine + Calculator.Solve(Display.Text));
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(" + ");
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(" - ");
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(" * ");
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Display.Undo();
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(".");
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(" / ");
        }

        private void Left_Paranthesis_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText("( ");
        }

        private void Right_Paranthesis_Click(object sender, RoutedEventArgs e)
        {
            Display.AppendText(" )");
        }

        private void Clear_All_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }
    }
}
