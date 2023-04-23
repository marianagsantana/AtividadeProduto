using Controllers;
using Models;
using System.Windows.Forms;

namespace Views
{
    public class Almoxerifado {
        public static void CadastrarAlmoxerifado()
        {
            Form almoxerifadoForm = new Form();
            almoxerifadoForm.Text = "Cadastrar Almoxerifado";
            almoxerifadoForm.Width = 300;
            almoxerifadoForm.Height = 300;
            almoxerifadoForm.StartPosition = FormStartPosition.CenterScreen;
            almoxerifadoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            almoxerifadoForm.MaximizeBox = false;
            almoxerifadoForm.MinimizeBox = false;
            almoxerifadoForm.ShowIcon = false;
            almoxerifadoForm.ShowInTaskbar = false;
            almoxerifadoForm.TopMost = true;
            almoxerifadoForm.FormClosed += (sender, e) => { almoxerifadoForm.Dispose(); };

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
            
            Button cadastrarAlmoxerifado = new Button();
            cadastrarAlmoxerifado.Text = "Confirmar";
            cadastrarAlmoxerifado.Top = 100;
            cadastrarAlmoxerifado.Left = 10;
            cadastrarAlmoxerifado.Width = 135;
            cadastrarAlmoxerifado.Height = 20;
            cadastrarAlmoxerifado.Click += (sender, e) => {
                Controllers.Almoxerifado.CadastrarAlmoxerifado(new Models.Almoxerifado(int.Parse(idTextBox.Text), nomeTextBox.Text));
                almoxerifadoForm.Close();
                ListarAlmoxerifados();
            };
            
            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 100;
            voltarButton.Left = 155;
            voltarButton.Width = 105;
            voltarButton.Height = 20;

            almoxerifadoForm.Controls.Add(idLabel);
            almoxerifadoForm.Controls.Add(idTextBox);
            almoxerifadoForm.Controls.Add(nomeLabel);
            almoxerifadoForm.Controls.Add(nomeTextBox);
            almoxerifadoForm.Controls.Add(cadastrarAlmoxerifado);
            almoxerifadoForm.Controls.Add(voltarButton);
            almoxerifadoForm.ShowDialog();
        }

        public static void ListarAlmoxerifados()
        {
            Form almoxerifadoForm = new Form();
            almoxerifadoForm.Text = "Listar Almoxerifados";
            almoxerifadoForm.Width = 500;
            almoxerifadoForm.Height = 500;
            almoxerifadoForm.StartPosition = FormStartPosition.CenterScreen;
            almoxerifadoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            almoxerifadoForm.MaximizeBox = false;
            almoxerifadoForm.MinimizeBox = false;
            almoxerifadoForm.ShowIcon = false;
            almoxerifadoForm.ShowInTaskbar = false;
            almoxerifadoForm.TopMost = true;
            almoxerifadoForm.FormClosed += (sender, e) => { almoxerifadoForm.Dispose(); };

            ListView almoxerifadosList = new ListView();
            almoxerifadosList.Top = 10;
            almoxerifadosList.Left = 10;
            almoxerifadosList.Width = 450;
            almoxerifadosList.Height = 400;
            almoxerifadosList.View = View.Details;
            almoxerifadosList.FullRowSelect = true;
            almoxerifadosList.GridLines = true;
            almoxerifadosList.MultiSelect = false;
            almoxerifadosList.HideSelection = false;
            almoxerifadosList.Columns.Add("ID", 50);
            almoxerifadosList.Columns.Add("Nome", 350);

            foreach (Models.Almoxerifado almoxerifado in Controllers.Almoxerifado.ListarAlmoxerifados())
            {
                ListViewItem item = new ListViewItem(almoxerifado.id.ToString());
                item.SubItems.Add(almoxerifado.nome);
                almoxerifadosList.Items.Add(item);
            }

            Button cadastrarAlmoxerifado = new Button();
            cadastrarAlmoxerifado.Text = "Cadastrar";
            cadastrarAlmoxerifado.Top = 420;
            cadastrarAlmoxerifado.Left = 10;
            cadastrarAlmoxerifado.Width = 110;
            cadastrarAlmoxerifado.Height = 20;
            cadastrarAlmoxerifado.Click += (sender, e) => {
                almoxerifadoForm.Close();
                CadastrarAlmoxerifado();
            };

            Button editarAlmoxerifado = new Button();
            editarAlmoxerifado.Text = "Editar";
            editarAlmoxerifado.Top = 420;
            editarAlmoxerifado.Left = 130;
            editarAlmoxerifado.Width = 110;
            editarAlmoxerifado.Height = 20;
            editarAlmoxerifado.Click += (sender, e) => {
                almoxerifadoForm.Close();
                EditarAlmoxerifado();
            };

            Button excluirAlmoxerifado = new Button();
            excluirAlmoxerifado.Text = "Excluir";
            excluirAlmoxerifado.Top = 420;
            excluirAlmoxerifado.Left = 250;
            excluirAlmoxerifado.Width = 110;
            excluirAlmoxerifado.Height = 20;
            excluirAlmoxerifado.Click += (sender, e) => {
                ExcluirAlmoxerifado();
                almoxerifadoForm.Close();
                ListarAlmoxerifados();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 420;
            voltarButton.Left = 370;
            voltarButton.Width = 110;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => {
                almoxerifadoForm.Close();
            };

            almoxerifadoForm.Controls.Add(almoxerifadosList);
            almoxerifadoForm.Controls.Add(cadastrarAlmoxerifado);
            almoxerifadoForm.Controls.Add(editarAlmoxerifado);
            almoxerifadoForm.Controls.Add(excluirAlmoxerifado);
            almoxerifadoForm.Controls.Add(voltarButton);
            almoxerifadoForm.ShowDialog();

        }

        public static void ExcluirAlmoxerifado() {
            Form almoxerifadoForm = new Form();
            almoxerifadoForm.Text = "Excluir Almoferidaxo";
            almoxerifadoForm.Width = 300;
            almoxerifadoForm.Height = 300;
            almoxerifadoForm.StartPosition = FormStartPosition.CenterScreen;
            almoxerifadoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            almoxerifadoForm.MaximizeBox = false;
            almoxerifadoForm.MinimizeBox = false;
            almoxerifadoForm.ShowIcon = false;
            almoxerifadoForm.ShowInTaskbar = false;
            almoxerifadoForm.TopMost = true;
            almoxerifadoForm.FormClosed += (sender, e) => { almoxerifadoForm.Dispose(); };

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
                Controllers.Almoxerifado.RemoverAlmoxerifado(int.Parse(idTextBox.Text));
                almoxerifadoForm.Close();
                Views.Almoxerifado.ListarAlmoxerifados();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 40;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { almoxerifadoForm.Close(); };

            almoxerifadoForm.Controls.Add(idLabel);
            almoxerifadoForm.Controls.Add(idTextBox);
            almoxerifadoForm.Controls.Add(cadastrarButton);
            almoxerifadoForm.Controls.Add(voltarButton);
            almoxerifadoForm.ShowDialog();
        }

        public static void EditarAlmoxerifado() {
            Form almoxerifadoForm = new Form();
            almoxerifadoForm.Text = "Editar Almoferidaxo";
            almoxerifadoForm.Width = 300;
            almoxerifadoForm.Height = 300;
            almoxerifadoForm.StartPosition = FormStartPosition.CenterScreen;
            almoxerifadoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            almoxerifadoForm.MaximizeBox = false;
            almoxerifadoForm.MinimizeBox = false;
            almoxerifadoForm.ShowIcon = false;
            almoxerifadoForm.ShowInTaskbar = false;
            almoxerifadoForm.TopMost = true;
            almoxerifadoForm.FormClosed += (sender, e) => { almoxerifadoForm.Dispose(); };

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
                Controllers.Almoxerifado.EditarAlmoxerifado(new Models.Almoxerifado(int.Parse(idTextBox.Text), nomeTextBox.Text));
                almoxerifadoForm.Close();
                Views.Almoxerifado.ListarAlmoxerifados();
            };

            Button voltarButton = new Button();
            voltarButton.Text = "Voltar";
            voltarButton.Top = 70;
            voltarButton.Left = 155;
            voltarButton.Width = 135;
            voltarButton.Height = 20;
            voltarButton.Click += (sender, e) => { almoxerifadoForm.Close(); };

            almoxerifadoForm.Controls.Add(idLabel);
            almoxerifadoForm.Controls.Add(idTextBox);
            almoxerifadoForm.Controls.Add(nomeLabel);
            almoxerifadoForm.Controls.Add(nomeTextBox);
            almoxerifadoForm.Controls.Add(cadastrarButton);
            almoxerifadoForm.Controls.Add(voltarButton);
            almoxerifadoForm.ShowDialog();
        }
    }
}