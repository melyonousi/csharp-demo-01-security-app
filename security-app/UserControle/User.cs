using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_app
{
    static class User
    {
        public static string login;
        public static string nom;
        public static string email;
        public static DateTime dateCreation;
        public static DateTime dateExperation;

        public static int idRole;
        public static string role;
        public static List<string> preveliges = new List<string>();
        public static List<string> controles = new List<string>();
    }
}
