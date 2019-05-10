using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjPrismMVVM.servico.Modelo;
using ProjPrismMVVM.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPrismMVVM.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Global

        INavigationService _navigationService;

        #endregion

        #region Binding
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        #endregion

        #region Command 
        public DelegateCommand ClickNavigationCommand { get; set; }

        private string c;
        public string CEP
        {
            get { return c; }
            set { SetProperty(ref c, value); }
        }

        private string r;
        public string RESULTADO
        {
            get { return r; }
            set { SetProperty(ref r, value); }
        }

        #endregion

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "MaingPage";

            ComandoClick = new DelegateCommand(ExecuteComandoClick);
        }

        private void ExecuteComandoClick()
        {
            _navigationService.NavigateAsync("MainPage");
        }

        private void ExecuteComandoClick()
        {
            string cep = CEP.Text();

            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = String.Format("Endereço: {2} de {3} {0},{1} ", end.localidade, end.uf, end.logradouro, end.bairro);
                    }

                    else
                    {
                        App.Current.MainPage.DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + cep, "OK");
                    }

                }
                catch (Exception e)
                {
                    App.Current.MainPage.DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if (cep.Length != 8)
            {
                App.Current.MainPage.DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");
                valido = false;
            }

            int NovoCEP = 0;

            if (!int.TryParse(cep, out NovoCEP))
            {
                App.Current.MainPage.DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por números.", "OK");
                valido = false;
            }

            return valido;
        }


    }
}
