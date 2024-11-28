using System;
using System.Collections.Generic;
using System.Text;
using MVVW.Modelo;
using MVVW.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace MVVW.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(parametros);        
        }
       
        public async Task<ObservableCollection<Mpokemon>> Mostrarpokemon() 
        {
            var data = Cconexion.firebase.Child("Pokemon").AsObservable<Mpokemon>().AsObservableCollection();
            return data;
        }
    }
            //return (await Cconexion.firebase.Child("Pokemon").OnceAsync<Mpokemon>()).Select(item => new Mpokemon
            //{
            //    Idpokemon = item.Key,
            //    Nombre = item.Object.Nombre,
            //    Colorfondo = item.Object.Colorfondo,
            //    Colorpoder = item.Object.Colorpoder,
            //    Icono = item.Object.Icono,
            //    Nroorden = item.Object.Nroorden,
            //    Poder = item.Object.Poder
            //}).ToList();
}