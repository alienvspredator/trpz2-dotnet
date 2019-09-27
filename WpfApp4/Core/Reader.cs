using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Core
{
    public class Reader : Person
    {
        public Reader(string name, string surname) : base(name, surname)
        {

        }

        private readonly int profileImageId = 0;

        public string ImageSource
        {
            get => $"pack://application:,,,/dynamic_assets/profile_images/{profileImageId}.png";
        }
    }
}
