using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL_App.model {
    internal class User {
        public string username { get; set; }
        public string password { get; set; }
        public string privilegija { get; set; }

        public User(string username, string password, string privilegija) {
            this.username = username;
            this.password = password;
            this.privilegija = privilegija;
        }
    }
}
