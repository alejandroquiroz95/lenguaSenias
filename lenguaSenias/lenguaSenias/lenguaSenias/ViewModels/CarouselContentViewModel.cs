using lenguaSenias.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace lenguaSenias.ViewModels
{
    public class CarouselContentViewModel : BaseViewModel, IQueryAttributable, INotifyPropertyChanged
    {
        public Command VerMasCommand {get; }
        public List<CarouselModel> CarruselItems { get; set; }
        private bool _visibleVerMas;
        private string _textoBoton;
        private int idTip;
        private int idItem;
        private int idNavegacion;

        public CarouselContentViewModel()
        {
            _visibleVerMas = false;
            _textoBoton = "▲ Ver más";
            VerMasCommand = new Command(VerMas);
            CarruselItems = new List<CarouselModel>();
        }

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            if (query.Count != 0)
            {
                if (query.ContainsKey("idItem"))
                {
                    Title = "Vocales";
                    idItem = Int32.Parse((string)query["idItem"]);
                    CargarItems(idItem);
                    idNavegacion = 2;
                }
            }
            else
            {
                Title = "Tips";
                CargarTips();
            }
        }

        private void CargarTips()
        {
            for (int i = 1; i <= 6; i++)
            {
                CarruselItems.Add(new CarouselModel
                {
                    Id = i,
                    Imagen = "drawable/tips_0" + i + ".jpg"
                });
            }

            OnPropertyChanged("CarruselItems");
        }

        private void CargarItems(int idItem)
        {
            for (int i = 1; i <= 5; i++)
            {
                CarruselItems.Add(new CarouselModel
                {
                    Id = i,
                    Imagen = "drawable/vocal_0" + i + ".png"
                });
            }

            OnPropertyChanged("CarruselItems");
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
