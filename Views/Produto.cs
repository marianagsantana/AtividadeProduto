using Controllers;
using Models;
using System.Windows.Forms;

namespace Views
{
    public class Produto
    {
        public static void CadastrarProduto()
        {
            Form produtoForm = new Form();
            produtoForm.Text = "Cadastrar Produto";
            produtoForm.Width = 300;
            produtoForm.Height = 300;
            produtoForm.StartPosition = FormStartPosition.CenterScreen;
            produtoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            produtoForm.MaximizeBox = false;
            produtoForm.MinimizeBox = false;
            produtoForm.ShowIcon = false;
            produtoForm.ShowInTaskbar = false;
            produtoForm.TopMost = true;
            produtoForm.FormClosed += (sender, e) => { produtoForm.Dispose(); };

            Label idLabel = new Label();
            idLabel.Text = "ID";
            idLabel.Top = 10;
            idLabel.Left = 10;
            idLabel.Width = 50;
            idLabel.Height = 20;

            TextBox idTextBox = new TextBox();
            idTextBox.Top = 10;
            idTextBox.Left = 60;
            idTextBox.Width = 200;
            idTextBox.Height = 20;

            Label nomeLabel = new Label();
            nomeLabel.Text = "Nome";
            nomeLabel.Top = 40;
            nomeLabel.Left = 10;
            nomeLabel.Width = 50;
            nomeLabel.Height = 20;

            TextBox nomeTextBox = new TextBox();
            nomeTextBox.Top = 40;
            nomeTextBox.Left = 60;
            nomeTextBox.Width = 200;
            nomeTextBox.Height = 20;

            Label precoLabel = new Label();
            precoLabel.Text = "Preço";
            precoLabel.Top = 70;
            precoLabel.Left = 10;
            precoLabel.Width = 50;
            precoLabel.Height = 20;

            TextBox precoTextBox = new TextBox();
            precoTextBox.Top = 70;
            precoTextBox.Left = 60;
            precoTextBox.Width = 200;
            precoTextBox.Height = 20;

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Confirmar";
            cadastrarButton.Top = 100;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 135;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => 
            {
                Controllers.Produto.CadastrarProduto(new Models.Produto(int.Parse(idTextBox.Text), nomeTextBox.Text, double.Parse(precoTextBox.Text)));
                produtoForm.Close();
                Views.Produto.ListarProdutos();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 100;
            voltarButton.Left = 135;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { produtoForm.Close(); };

            produtoForm.Controls.Add(idLabel);
            produtoForm.Controls.Add(idTextBox);
            produtoForm.Controls.Add(nomeLabel);
            produtoForm.Controls.Add(nomeTextBox);
            produtoForm.Controls.Add(precoLabel);
            produtoForm.Controls.Add(precoTextBox);
            produtoForm.Controls.Add(cadastrarButton);
            produtoForm.Controls.Add(voltarButton);
            produtoForm.ShowDialog();
        }
        public static void ListarProdutos()
        {
            Form produtoForm = new Form();
            produtoForm.Text = "Listar Produtos";
            produtoForm.Width = 500;
            produtoForm.Height = 500;
            produtoForm.StartPosition = FormStartPosition.CenterScreen;
            produtoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            produtoForm.MaximizeBox = false;
            produtoForm.MinimizeBox = false;
            produtoForm.ShowIcon = false;
            produtoForm.ShowInTaskbar = false;
            produtoForm.TopMost = true;
            produtoForm.FormClosed += (sender, e) => { produtoForm.Dispose(); };

            ListView produtosListView = new ListView();
            produtosListView.Top = 10;
            produtosListView.Left = 10;
            produtosListView.Width = 450;
            produtosListView.Height = 400;
            produtosListView.View = View.Details;
            produtosListView.Columns.Add("ID", 50);
            produtosListView.Columns.Add("Nome", 200);
            produtosListView.Columns.Add("Preço", 200);
            produtosListView.FullRowSelect = true;
            produtosListView.GridLines = true;
            produtosListView.MultiSelect = false;
            produtosListView.HideSelection = false;

            foreach (Models.Produto produto in Controllers.Produto.ListarProdutos())
            {
                ListViewItem item = new ListViewItem(produto.id.ToString());
                item.SubItems.Add(produto.nome);
                item.SubItems.Add(produto.preco.ToString());
                produtosListView.Items.Add(item);
            }

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Cadastrar";
            cadastrarButton.Top = 420;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 120;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => 
            {
                produtoForm.Close();
                produtoForm.Dispose();
                Views.Produto.CadastrarProduto();
            };
            
            Button alterarButton = new Button();
            alterarButton.Text = "Alterar";
            alterarButton.Top = 420;
            alterarButton.Left = 120;
            alterarButton.Width = 120;
            alterarButton.Height = 20;
            alterarButton.Click += (sender, e) => 
            {
                produtoForm.Close();
                produtoForm.Dispose();
                Views.Produto.AlterarProduto();
            };

            Button excluirButton = new Button();
            excluirButton.Text = "Excluir";
            excluirButton.Top = 420;
            excluirButton.Left = 240;
            excluirButton.Width = 120;
            excluirButton.Height = 20;
            excluirButton.Click += (sender, e) => 
            {
                produtoForm.Close();
                produtoForm.Dispose();
                Views.Produto.ExcluirProduto();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 420;
            voltarButton.Left = 360;
            voltarButton.Width = 120;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { produtoForm.Close(); };

            produtoForm.Controls.Add(produtosListView);
            produtoForm.Controls.Add(cadastrarButton);
            produtoForm.Controls.Add(alterarButton);
            produtoForm.Controls.Add(excluirButton);
            produtoForm.Controls.Add(voltarButton);
            produtoForm.ShowDialog();
        }

        public static void AlterarProduto()
        {
            Form produtoForm = new Form();
            produtoForm.Text = "Alterar Produto";
            produtoForm.Width = 300;
            produtoForm.Height = 300;
            produtoForm.StartPosition = FormStartPosition.CenterScreen;
            produtoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            produtoForm.MaximizeBox = false;
            produtoForm.MinimizeBox = false;
            produtoForm.ShowIcon = false;
            produtoForm.ShowInTaskbar = false;
            produtoForm.TopMost = true;
            produtoForm.FormClosed += (sender, e) => { produtoForm.Dispose(); };

            Label idLabel = new Label();
            idLabel.Text = "ID";
            idLabel.Top = 10;
            idLabel.Left = 10;
            idLabel.Width = 50;
            idLabel.Height = 20;

            TextBox idTextBox = new TextBox();
            idTextBox.Top = 10;
            idTextBox.Left = 60;
            idTextBox.Width = 200;
            idTextBox.Height = 20;

            Label nomeLabel = new Label();
            nomeLabel.Text = "Nome";
            nomeLabel.Top = 40;
            nomeLabel.Left = 10;
            nomeLabel.Width = 50;
            nomeLabel.Height = 20;

            TextBox nomeTextBox = new TextBox();
            nomeTextBox.Top = 40;
            nomeTextBox.Left = 60;
            nomeTextBox.Width = 200;
            nomeTextBox.Height = 20;

            Label precoLabel = new Label();
            precoLabel.Text = "Preço";
            precoLabel.Top = 70;
            precoLabel.Left = 10;
            precoLabel.Width = 50;
            precoLabel.Height = 20;

            TextBox precoTextBox = new TextBox();
            precoTextBox.Top = 70;
            precoTextBox.Left = 60;
            precoTextBox.Width = 200;
            precoTextBox.Height = 20;

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Confirmar";
            cadastrarButton.Top = 100;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 135;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => 
            {
                Controllers.Produto.EditarProduto(new Models.Produto(int.Parse(idTextBox.Text), nomeTextBox.Text, double.Parse(precoTextBox.Text)));
                produtoForm.Close();
                Views.Produto.ListarProdutos();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 100;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { produtoForm.Close(); };

            produtoForm.Controls.Add(idLabel);
            produtoForm.Controls.Add(idTextBox);
            produtoForm.Controls.Add(nomeLabel);
            produtoForm.Controls.Add(nomeTextBox);
            produtoForm.Controls.Add(precoLabel);
            produtoForm.Controls.Add(precoTextBox);
            produtoForm.Controls.Add(cadastrarButton);
            produtoForm.Controls.Add(voltarButton);
            produtoForm.ShowDialog();
        }

        public static void ExcluirProduto()
        {
            Form produtoForm = new Form();
            produtoForm.Text = "Excluir Produto";
            produtoForm.Width = 300;
            produtoForm.Height = 300;
            produtoForm.StartPosition = FormStartPosition.CenterScreen;
            produtoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            produtoForm.MaximizeBox = false;
            produtoForm.MinimizeBox = false;
            produtoForm.ShowIcon = false;
            produtoForm.ShowInTaskbar = false;
            produtoForm.TopMost = true;
            produtoForm.FormClosed += (sender, e) => { produtoForm.Dispose(); };

            Label idLabel = new Label();
            idLabel.Text = "ID";
            idLabel.Top = 10;
            idLabel.Left = 10;
            idLabel.Width = 50;
            idLabel.Height = 20;

            TextBox idTextBox = new TextBox();
            idTextBox.Top = 10;
            idTextBox.Left = 60;
            idTextBox.Width = 200;
            idTextBox.Height = 20;

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Confirmar";
            cadastrarButton.Top = 40;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 135;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => 
            {
                Controllers.Produto.RemoverProduto(int.Parse(idTextBox.Text));
                produtoForm.Close();
                Views.Produto.ListarProdutos();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 40;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { produtoForm.Close(); };

            produtoForm.Controls.Add(idLabel);
            produtoForm.Controls.Add(idTextBox);
            produtoForm.Controls.Add(cadastrarButton);
            produtoForm.Controls.Add(voltarButton);
            produtoForm.ShowDialog();
        }
    }
}