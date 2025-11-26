using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EF_Core.Models.Protocols;

namespace EF_Core.Models
{
    public class User:ObservableObject
    {
        /*public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }*/

        /*public DateTime CreatedAt { get; set; }*/

        private int id;
        private string? login;
        private string? name;
        private string? email;
        private string? password;
        private DateTime createdat;

        public int Id { get => id; set { id = value; SetProperty(ref id, value); } }
        public string Login { get => login ?? "_"; set { login = value; SetProperty(ref login, value); } }
        public string Name { get => name ?? "_"; set { name = value; SetProperty(ref name, value); } }
        public string Email { get => email ?? "_"; set { email = value; SetProperty(ref email, value); } }
        public string Password { get => password ?? "_"; set { password = value; SetProperty(ref password, value); } }
        public DateTime CreatedAt { get => createdat; set { createdat = value; SetProperty(ref createdat, value); } }


    }
}
