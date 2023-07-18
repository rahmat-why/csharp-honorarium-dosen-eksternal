using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace C__honorarium_dosen_eksternal
{
    public class ADTUser
    {
        private string id_user;
        private string nama;
        private string role;

        public ADTUser(string id_user, string nama, string role)
        {
            this.id_user = id_user;
            this.nama = nama;
            this.role = role;
        }

        public string getId_user() { 
            return id_user; 
        } 

        public string getNama() {
            return nama;
        }

        public string getRole()
        {
            return role;
        }
    }
}
