using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class MyPageName : ContentPage
    {
        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public MyPageName(List<Pessoa> listaNome)
        {
            InitializeComponent();
            ListaNome.ItemsSource = listaNome;
        }
    }
}
