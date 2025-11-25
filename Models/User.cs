using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models
{
    public class User/*:INotifyPropertyChanged*/
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public DateTime CreatedAt { get; set; }

        /*private int id;
        private string? login;
        private string? name;
        private string? email;
        private string? password;
        private DateTime createdat;

        public int Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Login { get=>login??"_"; set {  login = value; OnPropertyChanged(); } }
        public string Name { get=>name ?? "_"; set {  name = value; OnPropertyChanged(); } }
        public string Email { get=>email ?? "_"; set {  email = value; OnPropertyChanged(); } }
        public string Password { get=>password ?? "_"; set {  password = value; OnPropertyChanged(); } }
        public DateTime CreatedAt { get=>createdat; set {  createdat = value; OnPropertyChanged(); } }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
