using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ProjetoIntegrador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Estoque> ProdutoList = new List<Estoque>();

        public MainWindow()
        {
            List<Estoque> ProdutoList = new List<Estoque>();
            ProdutoList.Add(new Estoque() { nome = "camisa", qnt = 1, codbarras = 123456789 });
            DGestoque.ItemsSource = ProdutoList;
            InitializeComponent();

            // PRODUTOS
            ProdutoList.Add(new Estoque()
            {
                nome = "camisa",
                qnt = 1,
                codbarras = 123456789
            });

            DGestoque.ItemsSource = ProdutoList;

            // HISTÓRICO
            List<HistVendas> historico = new List<HistVendas>();

            historico.Add(new HistVendas()
            {
                Data = DateTime.Now.Date,
                Descricao = "Camiseta",
                Valor = 100.0,
                Qtd = 2,
                Cliente = "João Silva",
                CPF = "123456789",
                Codigo = 5001
            });

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

        // BOTÃO NOTA FISCAL
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HistVendas LinhaSelecionada = Historico1.SelectedItem as HistVendas;

            if (LinhaSelecionada != null)
            {
<<<<<<< HEAD
                MessageBox.Show($"NOTA FISCAL\n\n" + $"Data: {LinhaSelecionada.Data.ToShortDateString()}\n" + $"----------------------------------\n" + $"Produto: {LinhaSelecionada.Descricao}\n" + $"Quantidade: {LinhaSelecionada.Qtd}\n" + $"Valor Unitário: R$ {LinhaSelecionada.Valor}\n" + $"----------------------------------\n" + $"Cliente: {LinhaSelecionada.Cliente}\n" + $"CPF: {LinhaSelecionada.CPF}\n" + $"Código: {LinhaSelecionada.Codigo}",
     $"Cliente: {LinhaSelecionada.Cliente}\n" + "Sistema de Vendas", MessageBoxButton.OK, MessageBoxImage.Information);
=======
                MessageBox.Show(
                    $"NOTA FISCAL\n\n" +
                    $"Data: {LinhaSelecionada.Data.ToShortDateString()}\n" +
                    $"----------------------------------\n" +
                    $"Produto: {LinhaSelecionada.Descricao}\n" +
                    $"Quantidade: {LinhaSelecionada.Qtd}\n" +
                    $"Valor Unitário: R$ {LinhaSelecionada.Valor}\n" +
                    $"----------------------------------\n" +
                    $"Cliente: {LinhaSelecionada.Cliente}\n" +
                    $"CPF: {LinhaSelecionada.CPF}\n" +
                    $"Código: {LinhaSelecionada.Codigo}",
>>>>>>> e4952ec6c9105d5ddf09c1cea5432ae73ab1cfbb

                    "Sistema de Vendas",

                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
            }
            else
            {
                MessageBox.Show("Selecione uma venda");
            }
        }
<<<<<<< HEAD
=======

        // BOTÃO MOSTRAR PRODUTO
        private void Cad_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoqueSelecionado = DGestoque.SelectedItem as Estoque;

            if (estoqueSelecionado != null)
            {
                MessageBox.Show(
                    $"Produto: {estoqueSelecionado.nome}\n" +
                    $"Quantidade: {estoqueSelecionado.qnt}\n" +
                    $"Código de Barras: {estoqueSelecionado.codbarras}"
                );
            }
            else
            {
                MessageBox.Show("Selecione um item");
            }
        }

        // BOTÃO EXCLUIR
        private void Exc_Click(object sender, RoutedEventArgs e)
        {
            Estoque estoqueSelecionado = DGestoque.SelectedItem as Estoque;

            if (estoqueSelecionado != null)
            {
                ProdutoList.Remove(estoqueSelecionado);
                DGestoque.Items.Refresh();

                MessageBox.Show("Produto removido");
            }
            else
            {
                MessageBox.Show("Selecione um item");
            }
        }

        // CLASSE HISTÓRICO
>>>>>>> e4952ec6c9105d5ddf09c1cea5432ae73ab1cfbb
        public class HistVendas
        {
            public DateTime Data { get; set; }
            public string Descricao { get; set; }
            public double Valor { get; set; }
            public int Qtd { get; set; }
            public string Cliente { get; set; }
<<<<<<< HEAD
            public int CPF { get; set; }
            public int Codigo { get; set; }
        }
=======
            public string CPF { get; set; }
            public int Codigo { get; set; }
        }

        // CLASSE ESTOQUE
>>>>>>> e4952ec6c9105d5ddf09c1cea5432ae73ab1cfbb
        public class Estoque
        {
            public string nome { get; set; }
            public int qnt { get; set; }
            public int codbarras { get; set; }
<<<<<<< HEAD

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

=======
>>>>>>> e4952ec6c9105d5ddf09c1cea5432ae73ab1cfbb
        }
    }
}