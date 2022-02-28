using lenguaSenias.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace lenguaSenias.ViewModels
{
    public class LessonsListViewModel : BaseViewModel
    {
        public List<ListModel> ListaNiveles { get; set; } 
        public LessonsListViewModel()
        {
            ListaNiveles = new List<ListModel>();
            CargarLista();
        }

        private void CargarLista()
        {
            ListaNiveles.Add(new ListModel
            {
                Id = 1,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Básico",
                Descripcion = "Si aún no sabes nada sobre lengua de señas este nivel es adecuado para ti."
            });

            ListaNiveles.Add(new ListModel
            {
                Id = 2,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Intermedio",
                Descripcion = "Si ya tienes conocimiento sobre lengua de señas este nivel es adecuado para ti."
            });

            ListaNiveles.Add(new ListModel
            {
                Id = 3,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Avanzado",
                Descripcion = "Si ya sabes sobre lengua de señas pero quieres aprender más este nivel es adecuado para ti."
            });
        }
    }
}
