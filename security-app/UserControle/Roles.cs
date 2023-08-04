using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_app
{
    class Roles
    {
        public Roles()
        {

        }

        public Roles(int id,string name)
        {
            this.nomRole = name;
            this.idRole = id;
        }

        public int idRole { get; set;}
        public string nomRole { get; set; }
    }
}
