using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace RK_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                txtBoxOutput.Text = "";
                string InputText = txtBoxInput.Text;

                int GlasCount = 0;
                foreach (char c in InputText.ToLower())
                {
                    if ("aeiou".Contains(c))
                    {
                        GlasCount++;
                    }
                }

                string[] words = InputText.Split(new char[] { ' ', '.', ',', '!', '?' });
                string longestWord = "";
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                txtBoxOutput.Text = "Количество гласных: " + GlasCount + " Самое длинное слово: " + longestWord;
            }
            catch(Exception ex) 
            {
                txtBoxOutput.Text = ex.Message;
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
