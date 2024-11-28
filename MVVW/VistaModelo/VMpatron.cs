using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo
{
    class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMpatron(INavigation navegacion)
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
        public async Task ProcesoAsyncrono() 
        {
        }
        public void ProcesoSimple() 
        {
        }
        #endregion

        #region COMANDOS

        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
      
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
