using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class MyPageName : ContentPage
    {
        public MyPageName(List<Pessoa> listaNome)
        {
            InitializeComponent();
            ListaNome.ItemsSource = listaNome;
        }
    }
}
