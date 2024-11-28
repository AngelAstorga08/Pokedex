using MVVW.Modelo;
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
    class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> menuprincipal { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navegacion)
        {
            Navigation = navegacion;
            MenuPagina();
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
        //public async Task NavegarPagina()
        //{
        //    await Navigation.PopAsync();
        //}
        public async Task NavPagina(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, Datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("CRUD Pokemon"))
            {
                await Navigation.PushAsync(new CrudPokemon());
            }
        }
        public void MenuPagina()
        {
            menuprincipal = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina="Entry, Datepicker, Labels, Navegacion",
                    Icono="https://i.ibb.co/02HsH4m/buffalo.png"
                },
                new Mmenuprincipal
                {
                    Pagina="CollectionView, Sin enlace a base de datos, con taps",
                    Icono="https://i.ibb.co/KVKH0nd/flamingo.png"
                },
                new Mmenuprincipal
                {
                    Pagina="CRUD Pokemon",
                    Icono="https://i.ibb.co/bs5JDgh/crocodile.png"
                }
            };
        }
        #endregion

        #region COMANDOS

        //public ICommand Volver => new Command(async () => await NavegarPagina());

        public ICommand navcommand => new Command<Mmenuprincipal>(async (parametros) => await NavPagina(parametros));
        #endregion
    }
}
