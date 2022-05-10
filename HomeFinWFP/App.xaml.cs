using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HomeFinWFP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void GetSomething()
        {
            HomeFinCommonTypes.User user = new HomeFinCommonTypes.User();
            user.FirstName = "Osnielky";
        }

    }
}
