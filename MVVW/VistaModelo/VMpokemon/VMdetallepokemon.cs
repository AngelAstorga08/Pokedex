using MVVW.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo
{
    class VMdetallepokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mpokemon pokemon {  get; set; }
        string _objcolorfondo;
        string _objcolorpoder;
        string _objnombre;
        string _objnro;
        string _objpoder;
        string _objicono;
        #endregion

        #region CONSTRUCTOR
        public VMdetallepokemon(INavigation navegacion, Mpokemon parametrosTrae)
        {
            Navigation = navegacion;
            pokemon = parametrosTrae;
            _objcolorfondo = pokemon.Colorfondo;
            _objcolorpoder = pokemon.Colorpoder;
            _objnombre = pokemon.Nombre;
            _objnro = pokemon.Nroorden;
            _objpoder = pokemon.Poder;
            _objicono = pokemon.Icono;

        }
        #endregion

        #region OBJETOS
        public string ColorFondo
        {
            get { return _objcolorfondo; }
            set { SetValue(ref _objcolorfondo, value);
                OnPropertyChanged(nameof(ColorFondo));   }

        }

        public string ColorPoder
        {
            get { return _objcolorpoder; }
            set { SetValue(ref _objcolorpoder, value);
            OnPropertyChanged(nameof(ColorPoder));  }
        }

        public string Nombre
        {
            get { return _objnombre; }
            set { SetValue(ref _objnombre, value); }
        }

        public string Numero
        {
            get { return _objnro; }
            set { SetValue(ref _objnro, value); }
        }

        public string Poder
        {
            get { return _objpoder; }
            set { SetValue(ref _objpoder, value); }
        }

        public string Icono
        {
            get { return _objicono; }
            set { SetValue(ref _objicono, value); }
        }
        #endregion

        #region PROCESOS
        public async Task NavegarPagina()
        {
            await Navigation.PopAsync();
        }
        public async Task ProcesoAsyncrono()
        {
        }

        #endregion

        #region COMANDOS
        public ICommand Volver => new Command(async () => await NavegarPagina());

        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());

        #endregion
    }
}
