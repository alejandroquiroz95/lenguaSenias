using lenguaSenias.Models;
using lenguaSenias.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using Xamarin.Forms;

namespace lenguaSenias.ViewModels
{
    public class LessonsListViewModel : BaseViewModel, IQueryAttributable, INotifyPropertyChanged
    {
        public List<ListModel> ListaNiveles { get; set; }
        public List<ListModel> ListaCategorias { get; set; }
        public List<ListModel> ListaVocales { get; set; }
        private ListModel _seleccionListaN;
        private int idNivel;
        private int idCategoria;
        private int idNavegacion;

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            SeleccionListaN = null;
            if (query.Count != 0)
            {
                if (query.ContainsKey("idNivel"))
                {
                    Title = "Categorias";
                    idNivel = Int32.Parse((string)query["idNivel"]);
                    CargarCategorias(idNivel);
                    idNavegacion = 1;
                }

                if (query.ContainsKey("idCategoria"))
                {
                    Title = "Vocales";
                    idCategoria = Int32.Parse((string)query["idCategoria"]);
                    CargarVocales(idCategoria);
                    idNavegacion = 2;
                }
            }
            else
            {
                Title = "Niveles";
                CargarNiveles();
            }
        }

        public LessonsListViewModel()
        {
            ListaNiveles = new List<ListModel>();
            ListaCategorias = new List<ListModel>();
            ListaVocales = new List<ListModel>();
            idNivel = 0;
            idCategoria = 0;
            idNavegacion = 0;
        }

        private void CargarNiveles()
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

            OnPropertyChanged("ListaNiveles");
        }

        private void CargarCategorias(int id)
        {
            ListaCategorias.Add(new ListModel
            {
                Id = 1,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Vocales",
                Descripcion = "Selecciona para iniciar con las vocales."
            });

            ListaCategorias.Add(new ListModel
            {
                Id = 2,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Abecedario",
                Descripcion = "Selecciona para iniciar con el abecedario."
            });

            ListaCategorias.Add(new ListModel
            {
                Id = 3,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Números",
                Descripcion = "Selecciona para iniciar los números."
            });

            ListaCategorias.Add(new ListModel
            {
                Id = 4,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Colores",
                Descripcion = "Selecciona para iniciar los colores."
            });

            ListaCategorias.Add(new ListModel
            {
                Id = 5,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Días",
                Descripcion = "Selecciona para iniciar los días de la semana."
            });

            ListaCategorias.Add(new ListModel
            {
                Id = 6,
                Imagen = "drawable/basico_abecedario_abeja.jpg",
                Nombre = "Meses",
                Descripcion = "Selecciona para iniciar los meses del año."
            });

            ListaNiveles.Clear();
            ListaNiveles = new List<ListModel>(ListaCategorias);
            OnPropertyChanged("ListaNiveles");
        }

        private void CargarVocales(int id)
        {
            ListaVocales.Add(new ListModel
            {
                Id = 1,
                Imagen = "drawable/vocal_icono_01.png",
                Nombre = "A",
                Descripcion = "Vocal a."
            });

            ListaVocales.Add(new ListModel
            {
                Id = 2,
                Imagen = "drawable/vocal_icono_02.png",
                Nombre = "E",
                Descripcion = "Vocal e."
            });

            ListaVocales.Add(new ListModel
            {
                Id = 3,
                Imagen = "drawable/vocal_icono_03.png",
                Nombre = "I",
                Descripcion = "Vocal i."
            });

            ListaVocales.Add(new ListModel
            {
                Id = 4,
                Imagen = "drawable/vocal_icono_04.png",
                Nombre = "O",
                Descripcion = "Vocal o."
            });

            ListaVocales.Add(new ListModel
            {
                Id = 5,
                Imagen = "drawable/vocal_icono_05.png",
                Nombre = "U",
                Descripcion = "Vocal u."
            });

            ListaNiveles.Clear();
            ListaNiveles = new List<ListModel>(ListaVocales);
            OnPropertyChanged("ListaNiveles");
        }

        public ListModel SeleccionListaN
        {
            get { return _seleccionListaN; }
            set
            {
                SetProperty(ref _seleccionListaN, value);
                if (_seleccionListaN != null)
                {
                    switch (idNavegacion)
                    {
                        case 0:
                            Shell.Current.GoToAsync("LessonsListPage/LessonsListPage?idNivel=" + _seleccionListaN.Id);
                            break;
                        case 1:
                            Shell.Current.GoToAsync("LessonsListPage/LessonsListPage/LessonsListPage?idNivel=" + idNivel + "&idCategoria=" + _seleccionListaN.Id);
                            break;
                        case 2:
                            Shell.Current.GoToAsync("LessonsListPage/LessonsListPage/LessonsListPage/CorouselContentPage?idNivel=" + idNivel + "&idCategoria=" + idCategoria + "&idItem=" + _seleccionListaN.Id);
                            break;
                        default:
                           
                            break;
                    }
                }
                else
                {
                    _seleccionListaN = null;
                }
            }
        }
    }

}
