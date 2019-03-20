using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ListaPessoaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> listaNome = new List<Pessoa>();

        void SaveList(object sender, System.EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = label_nome.Text;
            pessoa.sobrenome = label_sobrenome.Text;

            listaNome.Add(pessoa);

            label_nome.Text = string.Empty;
            label_sobrenome.Text = string.Empty;
        }

        void ShowList(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPageName(listaNome));
        }


        public MainPage()
        {
            InitializeComponent();
        }
    }
}
