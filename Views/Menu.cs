using Models;
using Controllers;
using System.Windows.Forms;

namespace Views
{
    public class Menu
    {
        public static void ProgramMenu()
        {
            Form menuForm = new Form();
            menuForm.Text = "Menu";
            menuForm.Width = 300;
            menuForm.Height = 300;
            menuForm.StartPosition = FormStartPosition.CenterScreen;
            menuForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            menuForm.MaximizeBox = false;
            menuForm.MinimizeBox = false;
            menuForm.ShowIcon = false;
            menuForm.ShowInTaskbar = false;
            menuForm.TopMost = true;
            menuForm.FormClosed += (sender, e) => { menuForm.Dispose(); };

            Button cadastrarProdutoButton = new Button();
            cadastrarProdutoButton.Text = "Produto";
            cadastrarProdutoButton.Top = 10;
            cadastrarProdutoButton.Left = 10;
            cadastrarProdutoButton.Width = 250;
            cadastrarProdutoButton.Click += (sender, e) => { Produto.ListarProdutos(); };
            
            Button sairButton = new Button();
            sairButton.Text = "Sair";
            sairButton.Top = 40;
            sairButton.Left = 10;
            sairButton.Width = 250;
            sairButton.Click += (sender, e) => { menuForm.Close(); };
            menuForm.Controls.Add(sairButton);
            menuForm.Controls.Add(cadastrarProdutoButton);
            menuForm.ShowDialog();
        }
    }
}