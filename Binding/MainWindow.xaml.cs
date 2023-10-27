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
using System.Drawing;
using System.Drawing.Text;

namespace Binding
{



    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var installedFontCollection = new InstalledFontCollection();
            foreach (var fontFamily in installedFontCollection.Families)
            {
                fontFamilyComboBox.Items.Add(fontFamily.Name);
            }
            
            
            var properties = typeof(System.Windows.Media.Brushes).GetProperties();
            foreach (var brushProp in properties)
            {
                backgroundComboBox.Items.Add(brushProp.Name);
                foregroundComboBox.Items.Add(brushProp.Name);
                frameColorComboBox.Items.Add(brushProp.Name);
            }

            var ali = Enum.GetValues(typeof(TextAlignment));
            foreach (var Aligment in ali)
            {
                textAlignmentComboBox.Items.Add(Aligment);
            }


            
        }

        private void fontSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            textBox.FontSize= fontSlider.Value;
        }


        private void RatioButtonNormal_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Normal;
        }

        private void RatioButtonNaklon_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }


        private void RatioButtonThin_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Thin;
        }

        private void RatioButtonNormals_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Normal;
        }

        private void RatioButtonBold_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold;
        }








        

        private void textAlignmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }



        private void backgroundComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void foregroundComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

        private void frameColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void fontFamilyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void fontSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
