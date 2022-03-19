using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2.Singleton
{
    class MenuFormSingleton
    {
        private static readonly Lazy<MenuFormSingleton> _instance = new Lazy<MenuFormSingleton>(() => new MenuFormSingleton(Color.White));

        public static MenuFormSingleton Instance
        {
            get { return _instance.Value; }
        }

        public Color Color { get; private set; }


        private MenuFormSingleton(Color color)
        {
            Color = color;
        }


    }
}
