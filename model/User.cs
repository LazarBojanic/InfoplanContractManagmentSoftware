using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL_App.model {
    public class User {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string privilegija { get; set; }

        public User(int id, string username, string password, string privilegija) {
            this.id = id;
            this.username = username;
            this.password = password;
            this.privilegija = privilegija;
        }
    }
}
