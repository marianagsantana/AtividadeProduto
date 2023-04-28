using Controllers;
using Models;
using System.Windows.Forms;

namespace Views
{
    public class Armazem {
        public static void CadastrarArmazem()
        {
            Form ArmazemForm = new Form();
            ArmazemForm.Text = "Cadastrar Armazem";
            ArmazemForm.Width = 300;
            ArmazemForm.Height = 300;
            ArmazemForm.StartPosition = FormStartPosition.CenterScreen;
            ArmazemForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            ArmazemForm.MaximizeBox = false;
            ArmazemForm.MinimizeBox = false;
            ArmazemForm.ShowIcon = false;
            ArmazemForm.ShowInTaskbar = false;
            ArmazemForm.TopMost = true;
            ArmazemForm.FormClosed += (sender, e) => { ArmazemForm.Dispose(); };

            Label idLabel = new Label();
            idLabel.Text = "ID";
            idLabel.Top = 10;
            idLabel.Left = 10;
            idLabel.Width = 250;

            TextBox idTextBox = new TextBox();
            idTextBox.Top = 30;
            idTextBox.Left = 10;
            idTextBox.Width = 250;

            Label nomeLabel = new Label();
            nomeLabel.Text = "Nome";
            nomeLabel.Top = 60;
            nomeLabel.Left = 10;
            nomeLabel.Width = 250;

            TextBox nomeTextBox = new TextBox();
            nomeTextBox.Top = 80;
            nomeTextBox.Left = 10;
            nomeTextBox.Width = 250;
            
            Button cadastrarArmazem = new Button();
            cadastrarArmazem.Text = "Confirmar";
            cadastrarArmazem.Top = 100;
            cadastrarArmazem.Left = 10;
            cadastrarArmazem.Width = 135;
            cadastrarArmazem.Height = 20;
            cadastrarArmazem.Click += (sender, e) => {
                Controllers.Armazem.CadastrarArmazem(new Models.Armazem(int.Parse(idTextBox.Text), nomeTextBox.Text));
                ArmazemForm.Close();
                ListarArmazems();
            };
            
            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 100;
            voltarButton.Left = 155;
            voltarButton.Width = 105;
            voltarButton.Height = 20;

            ArmazemForm.Controls.Add(idLabel);
            ArmazemForm.Controls.Add(idTextBox);
            ArmazemForm.Controls.Add(nomeLabel);
            ArmazemForm.Controls.Add(nomeTextBox);
            ArmazemForm.Controls.Add(cadastrarArmazem);
            ArmazemForm.Controls.Add(voltarButton);
            ArmazemForm.ShowDialog();
        }

        public static void ListarArmazems()
        {
            Form ArmazemForm = new Form();
            ArmazemForm.Text = "Listar Armazems";
            ArmazemForm.Width = 500;
            ArmazemForm.Height = 500;
            ArmazemForm.StartPosition = FormStartPosition.CenterScreen;
            ArmazemForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            ArmazemForm.MaximizeBox = false;
            ArmazemForm.MinimizeBox = false;
            ArmazemForm.ShowIcon = false;
            ArmazemForm.ShowInTaskbar = false;
            ArmazemForm.TopMost = true;
            ArmazemForm.FormClosed += (sender, e) => { ArmazemForm.Dispose(); };

            ListView ArmazemsList = new ListView();
            ArmazemsList.Top = 10;
            ArmazemsList.Left = 10;
            ArmazemsList.Width = 450;
            ArmazemsList.Height = 400;
            ArmazemsList.View = View.Details;
            ArmazemsList.FullRowSelect = true;
            ArmazemsList.GridLines = true;
            ArmazemsList.MultiSelect = false;
            ArmazemsList.HideSelection = false;
            ArmazemsList.Columns.Add("ID", 50);
            ArmazemsList.Columns.Add("Nome", 350);

            foreach (Models.Armazem Armazem in Controllers.Armazem.ListarArmazems())
            {
                ListViewItem item = new ListViewItem(Armazem.id.ToString());
                item.SubItems.Add(Armazem.nome);
                ArmazemsList.Items.Add(item);
            }

            Button cadastrarArmazem = new Button();
            cadastrarArmazem.Text = "Cadastrar";
            cadastrarArmazem.Top = 420;
            cadastrarArmazem.Left = 10;
            cadastrarArmazem.Width = 110;
            cadastrarArmazem.Height = 20;
            cadastrarArmazem.Click += (sender, e) => {
                ArmazemForm.Close();
                CadastrarArmazem();
            };

            Button editarArmazem = new Button();
            editarArmazem.Text = "Editar";
            editarArmazem.Top = 420;
            editarArmazem.Left = 130;
            editarArmazem.Width = 110;
            editarArmazem.Height = 20;
            editarArmazem.Click += (sender, e) => {
                ArmazemForm.Close();
                EditarArmazem();
            };

            Button excluirArmazem = new Button();
            excluirArmazem.Text = "Excluir";
            excluirArmazem.Top = 420;
            excluirArmazem.Left = 250;
            excluirArmazem.Width = 110;
            excluirArmazem.Height = 20;
            excluirArmazem.Click += (sender, e) => {
                ExcluirArmazem();
                ArmazemForm.Close();
                ListarArmazems();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 420;
            voltarButton.Left = 370;
            voltarButton.Width = 110;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => {
                ArmazemForm.Close();
            };

            ArmazemForm.Controls.Add(ArmazemsList);
            ArmazemForm.Controls.Add(cadastrarArmazem);
            ArmazemForm.Controls.Add(editarArmazem);
            ArmazemForm.Controls.Add(excluirArmazem);
            ArmazemForm.Controls.Add(voltarButton);
            ArmazemForm.ShowDialog();

        }

        public static void ExcluirArmazem() {
            Form ArmazemForm = new Form();
            ArmazemForm.Text = "Excluir Armazem";
            ArmazemForm.Width = 300;
            ArmazemForm.Height = 300;
            ArmazemForm.StartPosition = FormStartPosition.CenterScreen;
            ArmazemForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            ArmazemForm.MaximizeBox = false;
            ArmazemForm.MinimizeBox = false;
            ArmazemForm.ShowIcon = false;
            ArmazemForm.ShowInTaskbar = false;
            ArmazemForm.TopMost = true;
            ArmazemForm.FormClosed += (sender, e) => { ArmazemForm.Dispose(); };

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
                Controllers.Armazem.RemoverArmazem(int.Parse(idTextBox.Text));
                ArmazemForm.Close();
                Views.Armazem.ListarArmazems();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 40;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { ArmazemForm.Close(); };

            ArmazemForm.Controls.Add(idLabel);
            ArmazemForm.Controls.Add(idTextBox);
            ArmazemForm.Controls.Add(cadastrarButton);
            ArmazemForm.Controls.Add(voltarButton);
            ArmazemForm.ShowDialog();
        }

        public static void EditarArmazem() {
            Form ArmazemForm = new Form();
            ArmazemForm.Text = "Editar Armazem";
            ArmazemForm.Width = 300;
            ArmazemForm.Height = 300;
            ArmazemForm.StartPosition = FormStartPosition.CenterScreen;
            ArmazemForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            ArmazemForm.MaximizeBox = false;
            ArmazemForm.MinimizeBox = false;
            ArmazemForm.ShowIcon = false;
            ArmazemForm.ShowInTaskbar = false;
            ArmazemForm.TopMost = true;
            ArmazemForm.FormClosed += (sender, e) => { ArmazemForm.Dispose(); };

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

            Button cadastrarButton = new Button();
            cadastrarButton.Text = "Confirmar";
            cadastrarButton.Top = 70;
            cadastrarButton.Left = 10;
            cadastrarButton.Width = 135;
            cadastrarButton.Height = 20;
            cadastrarButton.Click += (sender, e) => 
            {
                Controllers.Armazem.EditarArmazem(new Models.Armazem(int.Parse(idTextBox.Text), nomeTextBox.Text));
                ArmazemForm.Close();
                Views.Armazem.ListarArmazems();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 70;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { ArmazemForm.Close(); };

            ArmazemForm.Controls.Add(idLabel);
            ArmazemForm.Controls.Add(idTextBox);
            ArmazemForm.Controls.Add(nomeLabel);
            ArmazemForm.Controls.Add(nomeTextBox);
            ArmazemForm.Controls.Add(cadastrarButton);
            ArmazemForm.Controls.Add(voltarButton);
            ArmazemForm.ShowDialog();
        }
    }
}