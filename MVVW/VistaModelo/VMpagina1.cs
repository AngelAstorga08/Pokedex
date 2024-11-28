using MVVW.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVW.VistaModelo 
{
    class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _Tipousuario;
        DateTime _Fecha;
        string _ResultadoFecha;

        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navegacion)
        {
            Navigation = navegacion;
            Fecha = DateTime.Now;
        }
        #endregion

        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public string Tipousuario
        {
            get { return _Tipousuario; }
            set { SetValue(ref _Tipousuario, value); }
        }
        public string SeleccionarTipousuario
        {
            get { return _Tipousuario; }
            set { SetProperty(ref _Tipousuario, value);
                Tipousuario = _Tipousuario;
            }
        }
        public DateTime Fecha 
        {
            get { return _Fecha; }
            set { SetProperty(ref _Fecha, value);
                ResultadoFecha = Fecha.ToString("dd/MM/yyyy");
            }
        }
        public string ResultadoFecha
        {
            get { return _ResultadoFecha; }
            set { SetProperty(ref _ResultadoFecha, value); 
            }
        }
        #endregion

        #region PROCESOS
        public async Task NavegarPagina()
        {
            await Navigation.PushAsync(new Pagina2());
        }
        public async Task VolverPagina()
        {
            await Navigation.PopAsync();
        }
        public void Sumar()
        {
            

            double n1 = 0;
            double n2 = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);

            double respuesta = 0;
            respuesta = n1 + n2;

            
            R = respuesta.ToString();
        }
        #endregion

        #region COMANDOS

        public ICommand NavegarPagina2 => new Command(async () => await NavegarPagina());

        public ICommand Volver => new Command(async () => await VolverPagina());

        public ICommand SumarNumeros => new Command(Sumar);
        #endregion
    }
}
