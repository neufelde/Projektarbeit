namespace Klassenarbeitgenerator
{
    using Microsoft.Win32;
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
    

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(this);
        }

        private void btn_NeueAufgabeAnlegen_Click(object sender, RoutedEventArgs e)
        {
            this.StartTab.Visibility = Visibility.Collapsed;
            this.KlassenarbeitGenerierenTab.Visibility = Visibility.Collapsed;
            this.AufgabeAnlegenTab.Visibility = Visibility.Visible;
            this.AufgabeAnlegenTab.Focus();

        }

        private void btn_KlassenarbeitGenerieren_Click(object sender, RoutedEventArgs e)
        {
            this.StartTab.Visibility = Visibility.Collapsed;
            this.AufgabeAnlegenTab.Visibility = Visibility.Collapsed;
            this.KlassenarbeitGenerierenTab.Visibility = Visibility.Visible;
            this.KlassenarbeitGenerierenTab.Focus();
        }

        private void btn_GrafikAuswaehlen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.bmp;*.gif;*.tiff)|*.png;*.jpeg;*.bmp;*.gif;*.tiff|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                this.GrafikpfadTextBox.Text = openFileDialog.FileName;
            }
                
        }
    }
}
