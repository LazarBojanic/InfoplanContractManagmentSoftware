using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL_App.model {
    public class UgovorFile {
        public int id { get; set; }
        public String uGuid { get; set; }
        public String fajlPutanja { get; set; }
        public UgovorFile(int id, string uGuid, string fajlPutanja) {
            this.id = id;
            this.uGuid = uGuid;
            this.fajlPutanja = fajlPutanja;
        }
    }
}
