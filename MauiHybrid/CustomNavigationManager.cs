using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybrid
{
    public class CustomNavigationManager
    {
        private static NavigationManager _navigationManager;
        public CustomNavigationManager(NavigationManager MyNavigationManager)
        {
            _navigationManager = MyNavigationManager;
        }

        public static void Navigation(string url)
        {
            if (_navigationManager != null)
            {
                _navigationManager.NavigateTo(url);
            }
        }
    }
}
