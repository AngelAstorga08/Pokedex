using MVVW.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo
{
    class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navegacion)
        {
            Navigation = navegacion;
            Mostrarusuarios();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task NavegarPagina()
        {
            await Navigation.PopAsync();
        }
        public async Task Alerta(string parametros)
        {
            await DisplayAlert("Titulo", parametros, "Aceptar");
        }
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Frank",
                    Imagen="https://i.ibb.co/02HsH4m/buffalo.png"
                },
                new Musuarios
                {
                    Nombre="Juan",
                    Imagen="https://i.ibb.co/KVKH0nd/flamingo.png"
                },
                new Musuarios
                {
                    Nombre="Ernesto",
                    Imagen="https://i.ibb.co/bs5JDgh/crocodile.png"
                }
            };
        }
        #endregion
        
        #region COMANDOS

        public ICommand Volver => new Command(async () => await NavegarPagina());

        public ICommand Alertacommand => new Command<string>(async (parametros) => await Alerta(parametros));
        #endregion
    }
}
