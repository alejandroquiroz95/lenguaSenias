using lenguaSenias.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lenguaSenias.ViewModels
{
    public class LessonsViewModel : BaseViewModel
    {
        private string _textoBoton;
        private bool _visibleVerMas;
        public List<CarouselModel> CarruselAbecedario { get; set; }
        public Command VerMasCommand { get; }

        public LessonsViewModel()
        {
            CarruselAbecedario = new List<CarouselModel>();
            VerMasCommand = new Command(VerMasClicked);
            _visibleVerMas = false;
            _textoBoton = "▲ Ver más";
            Title = "Lecciones";
            CargarCarruselAbc();
            
        }

        private void CargarCarruselAbc()
        {
            for (int i = 1; i <= 5; i++)
            {
                CarruselAbecedario.Add(new CarouselModel
                {
                    Id = i,
                    Imagen = "drawable/basico_abecedario_abeja.jpg",
                    Nombre = "A"
                });
            }
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
