using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo
{
    class VMcrudpokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMcrudpokemon(INavigation navegacion)
        {
            Navigation = navegacion;
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
        public async Task VolverPagina()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS

        public ICommand Volver => new Command(async () => await VolverPagina());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
