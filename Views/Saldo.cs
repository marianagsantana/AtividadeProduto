using Controllers;
using Models;
using System.Windows.Forms;

namespace Views
{
    public class Saldo {
        public static void ListarSaldo() {
            Form saldoForm = new Form();
            saldoForm.Text = "Saldo";
            saldoForm.Width = 500;
            saldoForm.Height = 500;
            saldoForm.StartPosition = FormStartPosition.CenterScreen;
            saldoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            saldoForm.MaximizeBox = false;
            saldoForm.MinimizeBox = false;
            saldoForm.ShowIcon = false;
            saldoForm.ShowInTaskbar = false;
            saldoForm.TopMost = true;
            saldoForm.FormClosed += (sender, e) => { saldoForm.Dispose(); };

            ListView saldoListView = new ListView();
            saldoListView.Top = 10;
            saldoListView.Left = 10;
            saldoListView.Width = 450;
            saldoListView.Height = 350;
            saldoListView.View = View.Details;
            saldoListView.Columns.Add("Id", 50);
            saldoListView.Columns.Add("Produto", 100);
            saldoListView.Columns.Add("Armazem", 100);
            saldoListView.Columns.Add("Quantidade", 100);

            foreach (Models.Saldo saldo in Controllers.Saldo.ListarSaldos()) {
                ListViewItem item = new ListViewItem(saldo.id.ToString());
                List<Models.Produto> produto = Controllers.Produto.ListarProduto(saldo.ProdutoId);
                item.SubItems.Add(produto[0].nome);
                List<Models.Armazem> Armazem = Controllers.Armazem.ListarArmazem(saldo.ProdutoId);
                item.SubItems.Add(Armazem[0].nome);
                item.SubItems.Add(saldo.quantidade.ToString());
                saldoListView.Items.Add(item);
            }

            Button cadastrarSaldoButton = new Button();
            cadastrarSaldoButton.Text = "Cadastrar";
            cadastrarSaldoButton.Top = 370;
            cadastrarSaldoButton.Left = 10;
            cadastrarSaldoButton.Width = 110;
            cadastrarSaldoButton.Height = 20;
            cadastrarSaldoButton.Click += (sender, e) => {
                saldoForm.Close();
                CadastrarSaldo();
            };

            Button editarSaldoButton = new Button();
            editarSaldoButton.Text = "Editar";
            editarSaldoButton.Top = 370;
            editarSaldoButton.Left = 130;
            editarSaldoButton.Width = 110;
            editarSaldoButton.Height = 20;
            editarSaldoButton.Click += (sender, e) => {
                saldoForm.Close();
                EditarSaldo();
            };

            Button excluirSaldoButton = new Button();
            excluirSaldoButton.Text = "Excluir";
            excluirSaldoButton.Top = 370;
            excluirSaldoButton.Left = 250;
            excluirSaldoButton.Width = 110;
            excluirSaldoButton.Height = 20;
            excluirSaldoButton.Click += (sender, e) => {
                saldoForm.Close();
                ExcluirSaldo();
            };

            Button sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Top = 370;
            sairButton.Left = 370;
            sairButton.Width = 90;
            sairButton.Height = 20;
            sairButton.Click += (sender, e) => {
                saldoForm.Close();
            };

            saldoForm.Controls.Add(cadastrarSaldoButton);
            saldoForm.Controls.Add(editarSaldoButton);
            saldoForm.Controls.Add(excluirSaldoButton);
            saldoForm.Controls.Add(saldoListView);
            saldoForm.Controls.Add(sairButton);
            saldoForm.ShowDialog();

        }

        public static void CadastrarSaldo() {
            Form saldoForm = new Form();
            saldoForm.Text = "Cadastrar Saldo";
            saldoForm.Width = 500;
            saldoForm.Height = 500;
            saldoForm.StartPosition = FormStartPosition.CenterScreen;
            saldoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            saldoForm.MaximizeBox = false;
            saldoForm.MinimizeBox = false;
            saldoForm.ShowIcon = false;
            saldoForm.ShowInTaskbar = false;
            saldoForm.TopMost = true;
            saldoForm.FormClosed += (sender, e) => { saldoForm.Dispose(); };

            Label saldoLabel = new Label();
            saldoLabel.Text = "ID";
            saldoLabel.Top = 10;
            saldoLabel.Left = 10;
            saldoLabel.Width = 100;
            saldoLabel.Height = 20;

            TextBox saldoTextBox = new TextBox();
            saldoTextBox.Top = 10;
            saldoTextBox.Left = 110;
            saldoTextBox.Width = 350;
            saldoTextBox.Height = 20;

            Label produtoLabel = new Label();
            produtoLabel.Text = "Produto";
            produtoLabel.Top = 40;
            produtoLabel.Left = 10;
            produtoLabel.Width = 100;
            produtoLabel.Height = 20;

            TextBox produtoTextBox = new TextBox();
            produtoTextBox.Top = 40;
            produtoTextBox.Left = 110;
            produtoTextBox.Width = 350;
            produtoTextBox.Height = 20;

            Label ArmazemLabel = new Label();
            ArmazemLabel.Text = "Armazem";
            ArmazemLabel.Top = 70;
            ArmazemLabel.Left = 10;
            ArmazemLabel.Width = 100;
            ArmazemLabel.Height = 20;

            TextBox ArmazemTextBox = new TextBox();
            ArmazemTextBox.Top = 70;
            ArmazemTextBox.Left = 110;
            ArmazemTextBox.Width = 350;
            ArmazemTextBox.Height = 20;

            Label quantidadeLabel = new Label();
            quantidadeLabel.Text = "Quantidade";
            quantidadeLabel.Top = 100;
            quantidadeLabel.Left = 10;
            quantidadeLabel.Width = 100;
            quantidadeLabel.Height = 20;

            TextBox quantidadeTextBox = new TextBox();
            quantidadeTextBox.Top = 100;
            quantidadeTextBox.Left = 110;
            quantidadeTextBox.Width = 350;
            quantidadeTextBox.Height = 20;

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Cadastrar";
            cadastrarButton.Top = 130;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 110;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => {
                Controllers.Saldo.CadastrarSaldo(new Models.Saldo(int.Parse(saldoTextBox.Text), int.Parse(produtoTextBox.Text), int.Parse(ArmazemTextBox.Text), int.Parse(quantidadeTextBox.Text)));
                saldoForm.Close();
                ListarSaldo();
            };

            Button sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Top = 130;
            sairButton.Left = 370;
            sairButton.Width = 90;
            sairButton.Height = 20;
            sairButton.Click += (sender, e) => {
                saldoForm.Close();
            };

            saldoForm.Controls.Add(saldoLabel);
            saldoForm.Controls.Add(saldoTextBox);
            saldoForm.Controls.Add(produtoLabel);
            saldoForm.Controls.Add(produtoTextBox);
            saldoForm.Controls.Add(ArmazemLabel);
            saldoForm.Controls.Add(ArmazemTextBox);
            saldoForm.Controls.Add(quantidadeLabel);
            saldoForm.Controls.Add(quantidadeTextBox);
            saldoForm.Controls.Add(cadastrarButton);
            saldoForm.Controls.Add(sairButton);
            saldoForm.ShowDialog();
        }

        public static void EditarSaldo() {
            Form saldoForm = new Form();
            saldoForm.Text = "Editar Saldo";
            saldoForm.Width = 500;
            saldoForm.Height = 500;
            saldoForm.StartPosition = FormStartPosition.CenterScreen;
            saldoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            saldoForm.MaximizeBox = false;
            saldoForm.MinimizeBox = false;
            saldoForm.ShowIcon = false;
            saldoForm.ShowInTaskbar = false;
            saldoForm.TopMost = true;
            saldoForm.FormClosed += (sender, e) => { saldoForm.Dispose(); };

            Label saldoLabel = new Label();
            saldoLabel.Text = "ID";
            saldoLabel.Top = 10;
            saldoLabel.Left = 10;
            saldoLabel.Width = 100;
            saldoLabel.Height = 20;

            TextBox saldoTextBox = new TextBox();
            saldoTextBox.Top = 10;
            saldoTextBox.Left = 110;
            saldoTextBox.Width = 350;
            saldoTextBox.Height = 20;

            Label produtoLabel = new Label();
            produtoLabel.Text = "Produto";
            produtoLabel.Top = 40;
            produtoLabel.Left = 10;
            produtoLabel.Width = 100;
            produtoLabel.Height = 20;

            TextBox produtoTextBox = new TextBox();
            produtoTextBox.Top = 40;
            produtoTextBox.Left = 110;
            produtoTextBox.Width = 350;
            produtoTextBox.Height = 20;

            Label ArmazemLabel = new Label();
            ArmazemLabel.Text = "Armazem";
            ArmazemLabel.Top = 70;
            ArmazemLabel.Left = 10;
            ArmazemLabel.Width = 100;
            ArmazemLabel.Height = 20;

            TextBox ArmazemTextBox = new TextBox();
            ArmazemTextBox.Top = 70;
            ArmazemTextBox.Left = 110;
            ArmazemTextBox.Width = 350;
            ArmazemTextBox.Height = 20;

            Label quantidadeLabel = new Label();
            quantidadeLabel.Text = "Quantidade";
            quantidadeLabel.Top = 100;
            quantidadeLabel.Left = 10;
            quantidadeLabel.Width = 100;
            quantidadeLabel.Height = 20;

            TextBox quantidadeTextBox = new TextBox();
            quantidadeTextBox.Top = 100;
            quantidadeTextBox.Left = 110;
            quantidadeTextBox.Width = 350;
            quantidadeTextBox.Height = 20;

            Button editarButton = new Button();
            editarButton.Text = "Editar";
            editarButton.Top = 130;
            editarButton.Left = 10;
            editarButton.Width = 110;
            editarButton.Height = 20;
            editarButton.Click += (sender, e) => {
                Controllers.Saldo.EditarSaldo(new Models.Saldo(int.Parse(saldoTextBox.Text), int.Parse(produtoTextBox.Text), int.Parse(ArmazemTextBox.Text), int.Parse(quantidadeTextBox.Text)));
                saldoForm.Close();
                ListarSaldo();
            };

            Button sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Top = 130;
            sairButton.Left = 370;
            sairButton.Width = 90;
            sairButton.Height = 20;
            sairButton.Click += (sender, e) => {
                saldoForm.Close();
            };

            saldoForm.Controls.Add(saldoLabel);
            saldoForm.Controls.Add(saldoTextBox);
            saldoForm.Controls.Add(produtoLabel);
            saldoForm.Controls.Add(produtoTextBox);
            saldoForm.Controls.Add(ArmazemLabel);
            saldoForm.Controls.Add(ArmazemTextBox);
            saldoForm.Controls.Add(quantidadeLabel);
            saldoForm.Controls.Add(quantidadeTextBox);
            saldoForm.Controls.Add(editarButton);
            saldoForm.Controls.Add(sairButton);
            saldoForm.ShowDialog();
        }

        public static void ExcluirSaldo() {
            Form saldoForm = new Form();
            saldoForm.Text = "Excluir Saldo";
            saldoForm.Width = 500;
            saldoForm.Height = 500;
            saldoForm.StartPosition = FormStartPosition.CenterScreen;
            saldoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            saldoForm.MaximizeBox = false;
            saldoForm.MinimizeBox = false;
            saldoForm.ShowIcon = false;
            saldoForm.ShowInTaskbar = false;
            saldoForm.TopMost = true;
            saldoForm.FormClosed += (sender, e) => { saldoForm.Dispose(); };

            Label saldoLabel = new Label();
            saldoLabel.Text = "ID";
            saldoLabel.Top = 10;
            saldoLabel.Left = 10;
            saldoLabel.Width = 100;
            saldoLabel.Height = 20;

            TextBox saldoTextBox = new TextBox();
            saldoTextBox.Top = 10;
            saldoTextBox.Left = 110;
            saldoTextBox.Width = 350;
            saldoTextBox.Height = 20;

            Button excluirButton = new Button();
            excluirButton.Text = "Confirmar";
            excluirButton.Top = 40;
            excluirButton.Left = 10;
            excluirButton.Width = 110;
            excluirButton.Height = 20;
            excluirButton.Click += (sender, e) => {
                Controllers.Saldo.RemoverSaldo(int.Parse(saldoTextBox.Text));
                saldoForm.Close();
                ListarSaldo();
            };

            Button sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Top = 40;
            sairButton.Left = 370;
            sairButton.Width = 90;
            sairButton.Height = 20;
            sairButton.Click += (sender, e) => {
                saldoForm.Close();
            };

            saldoForm.Controls.Add(saldoLabel);
            saldoForm.Controls.Add(saldoTextBox);
            saldoForm.Controls.Add(excluirButton);
            saldoForm.Controls.Add(sairButton);
            saldoForm.ShowDialog();
        }
    }
}