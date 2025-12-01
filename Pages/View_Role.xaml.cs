using EF_Core.Models;
using EF_Core.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_Core.Pages
{
    /// <summary>
    /// Логика взаимодействия для View_Role.xaml
    /// </summary>
    public partial class View_Role : Page
    {
        public RoleService _service = new();
        public Role _role = new ();
        public Role? current { get; set; } = null;
        private bool isEdit = false;

        public View_Role(Role? role=null)
        {
            InitializeComponent();

           if(current != null)
           {
                _service.LoadRelation(current, "Users");
                _role = current;
                isEdit = true;
           }

            DataContext = _role;
        }

        private void Select_Role(object sender,RoutedEventArgs e)
        {
            if (current != null)
            {
                _service.LoadRelation(current, "Users");
                _role = current;
                isEdit = true;
            }
            else
            {
                MessageBox.Show("bomboclat");
            }
        }


    }
}
