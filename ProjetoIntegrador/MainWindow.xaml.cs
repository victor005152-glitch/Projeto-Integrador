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

namespace ProjetoIntegrador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<Estoque> ProdutoList = new List<Estoque>();
        public MainWindow()
        {
            InitializeComponent();

            ProdutoList.Add(new Estoque() { nome = "camisa", qnt = 1, codbarras = 123456789 });
            DGestoque.ItemsSource = ProdutoList;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public class Estoque
        {
            public string nome { get; set; }
            public int qnt {  get; set; }
            public int codbarras { get; set; }

        }

        private void Cad_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoqueSelecionado = DGestoque.SelectedItem as Estoque;

            if (estoqueSelecionado != null)
            {
                MessageBox.Show($"{estoqueSelecionado.nome}, {estoqueSelecionado.qnt}, {estoqueSelecionado.codbarras}");
               
            }
            else
            {
                MessageBox.Show("Selecioen uma item");
            }
        }

        private void Exc_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoqueSelecionado = DGestoque.SelectedItem as Estoque;

            if (estoqueSelecionado != null)
            {
                ProdutoList.Remove(estoqueSelecionado);
                DGestoque.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Selecioen uma item");
            }
        }
    }

}