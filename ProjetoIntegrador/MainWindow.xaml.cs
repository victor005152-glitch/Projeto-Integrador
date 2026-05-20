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
        public MainWindow()
        {
            List<Estoque> ProdutoList = new List<Estoque>();
            ProdutoList.Add(new Estoque() { nome = "camisa", qnt = 1, codbarras = 123456789 });
            DGestoque.ItemsSource = ProdutoList;
            InitializeComponent();

            List<HistVendas> historico = new List<HistVendas>();
            historico.Add(new HistVendas() { Data = DateTime.Now.Date, Descricao = "Camiseta", Valor = 100.0, Qtd = 2, Cliente = "João Silva", CPF = 123456789, Codigo = 5001 });
            Historico1.ItemsSource = historico;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Historico1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HistVendas LinhaSelecionada = Historico1.SelectedItem as HistVendas;
            if (LinhaSelecionada != null)
            {
                MessageBox.Show($"NOTA FISCAL\n\n" + $"Data: {LinhaSelecionada.Data.ToShortDateString()}\n" + $"----------------------------------\n" + $"Produto: {LinhaSelecionada.Descricao}\n" + $"Quantidade: {LinhaSelecionada.Qtd}\n" + $"Valor Unitário: R$ {LinhaSelecionada.Valor}\n" + $"----------------------------------\n" + $"Cliente: {LinhaSelecionada.Cliente}\n" + $"CPF: {LinhaSelecionada.CPF}\n" + $"Código: {LinhaSelecionada.Codigo}",
     $"Cliente: {LinhaSelecionada.Cliente}\n" + "Sistema de Vendas", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
        public class HistVendas
        {
            public DateTime Data { get; set; }
            public string Descricao { get; set; }
            public double Valor { get; set; }
            public int Qtd { get; set; }
            public string Cliente { get; set; }
            public int CPF { get; set; }
            public int Codigo { get; set; }
        }
        public class Estoque
        {
            public string nome { get; set; }
            public int qnt { get; set; }
            public int codbarras { get; set; }

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
}