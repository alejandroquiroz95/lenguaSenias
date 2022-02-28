using lenguaSenias.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace lenguaSenias.ViewModels
{
    public class TipsViewModel : BaseViewModel
    {
        private bool _visibleVerMas;
        private string _textoBoton;
        public Command VerMasCommand {get; }
        public List<CarouselModel> CarruselTips { get; set; }
        public TipsViewModel()
        {
            _visibleVerMas = false;
            _textoBoton = "▲ Ver más";
            VerMasCommand = new Command(VerMas);
            CarruselTips = new List<CarouselModel>();
            Title = "Tips";
            CargarCarruselTips();
        }

        private void CargarCarruselTips()
        {
            for (int i = 1; i <= 6; i++)
            {
                CarruselTips.Add(new CarouselModel
                {
                    Id = i,
                    Imagen = "drawable/tips_0" + i + ".jpg"
                });
            }
        }

        private void VerMas(object obj)
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
            set { SetProperty(ref _textoBoton, value);  }
        }
    }
}
