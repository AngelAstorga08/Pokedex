using MVVW.Datos;
using MVVW.Modelo;
using MVVW.Vistas.Pokemon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo
{
    class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mpokemon> _Listapokemon;
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navegacion)
        {
            Navigation = navegacion;
            Mostrarpokemon();
        }
        #endregion

        #region OBJETOS
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }
        #endregion

        #region PROCESOS
        public async Task Mostrarpokemon() 
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.Mostrarpokemon();
        }
  
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }

        public async Task Iradetalle(Mpokemon parametros)
        {
            await Navigation.PushAsync(new Detallepokemon(parametros));
        }
        #endregion

        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        //public ICommand Iraregistrocommand()
        //{
        //   return new Command(async () => await Iraregistro());
        //}

        public ICommand Iradetallecommand => new Command<Mpokemon>(async (parametros) => await Iradetalle(parametros));
        #endregion
    }
}
