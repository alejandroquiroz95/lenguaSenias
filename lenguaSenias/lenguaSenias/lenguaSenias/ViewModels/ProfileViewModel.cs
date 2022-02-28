using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace lenguaSenias.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        private string _textoBoton;
        private bool _visibleVerMas;
        public Command VerMasCommand { get; }
        public Command VerImagenCommand { get; }

        public ProfileViewModel()
        {
            _visibleVerMas = false;
            _textoBoton = "▲ Ver más";
            Title = "Perfil";
            VerMasCommand = new Command(VerMasClicked);
        }

        private void VerMasClicked(object obj)
        {
            if (VisibleVerMas)
            {
                VisibleVerMas = false;
                TextoBoton = "▲ Ver más";
            }
            else
            {
                VisibleVerMas = true;
                TextoBoton = "▼ Ver menos";
            }
        }

        public bool VisibleVerMas
        {
            get { return _visibleVerMas; }
            set { SetProperty(ref _visibleVerMas, value); }
        }

        public string TextoBoton
        {
            get { return _textoBoton; }
            set { SetProperty(ref _textoBoton, value); }
        }
    }
}
