using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVW.Conexion
{
    internal class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-ea465-default-rtdb.firebaseio.com/");
    }
}
