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
using System.Windows.Shapes;

namespace WPFExemplo.Views
{
    /// <summary>
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnMensagem_Click(object sender, RoutedEventArgs e)
        {
            string mensagem = txtMensagem.Text;
            MessageBox.Show(mensagem, "WPF Exemplo");

            if (string.IsNullOrEmpty(txtMensagem.Text))
            {
                MessageBox.Show(mensagem, "WPF Exemplo");
            }


            //if (txtMensagem.Text.Equals(""))
            //{
            //    MessageBox.Show("Campo vazio!");
            //}
            //else
            //{
            //    MessageBox.Show(mensagem, "WPF Exemplo");
            //}

        }

        private void TxtMensagem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
