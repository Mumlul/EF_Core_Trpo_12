using EF_Core.Models.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models
{
    public class UserProfile:ObservableObject
    {
        #region Private
        int _id;
        string _avatarlurl;
        int phone;
        DateTime _birthday;
        string _bio;
        int _userId;
        User _user;
        #endregion

        public int Id { get => _id;  set { _id = value; SetProperty(ref _id, value); } }
        public string Avaterlurl { get =>_avatarlurl;  set { _avatarlurl = value; SetProperty(ref _avatarlurl, value); } }
        public int Phone { get => phone; set { phone = value; SetProperty(ref phone, value); } }
        public DateTime BirthDay { get => _birthday; set { _birthday = value; SetProperty(ref _birthday, value); } }
        public string BIO { get =>_bio;  set { _bio = value; SetProperty(ref _bio, value); } }
        public User User { get => _user; set { _user = value; SetProperty(ref _user, value); } }
        public int UserId { get => _userId; set { _userId = value;SetProperty(ref _userId, value); } } 
    }
}
