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

namespace Projeto_Escola_Rafael
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeFantasia.Focus();
        }

        private void txtNomeFantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtRazaoSocial.Focus();
        }

        private void BtSair(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtCnpj.Focus();
        }

        private void txtCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtInscricaoEstadual.Focus();
        }

        private void txtInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtResponsavel.Focus();
        }

        private void txtResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtTelefoneDoResponsavel.Focus();
        }

        private void txtTelefoneDoResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                dpDataDeCriacao.Focus();
        }

        private void Bt_avancar_Click(object sender, RoutedEventArgs e)
        {
            txtBairro.Focus();
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtRua.Focus();
        }

        private void txtRua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtNumero.Focus();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtCep.Focus();
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txtComplemento.Focus();
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                cbEstado.Focus();
        }

        private void Bt_salvar(object sender, RoutedEventArgs e)
        {
            string tipo;

            if (tipo1.IsChecked == true)
                tipo = "Publica";

            else
                tipo = "Privada";

            MessageBox.Show($"dados de cadastro da escola: \n \n Nome Fantasia: {txtNomeFantasia.Text}\n\n Razão Social: {txtRazaoSocial.Text}\n\n CNPJ: {txtCnpj.Text}\n\n  Inscrição Estadual: {txtInscricaoEstadual.Text}\n\n Responsavel: {txtResponsavel.Text}\n\n Telefone do Responsavel: {txtTelefoneDoResponsavel.Text}\n\n Data de Cração: {dpDataDeCriacao.Text}\n\n Tipo: {tipo} \n\n Dados de Endereço: \n\n Bairro: {txtBairro.Text}\n\n Rua: {txtRua.Text}\n\n Numero: {txtNumero.Text}\n\n CEP: {txtCep.Text}\n\n Complemento: {txtComplemento.Text}\n\n Estado: {cbEstado.Text}");
        }
    }
}
