using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignPattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            SingletonObject singleton= SingletonObject.GetSingleton();
            singleton.showMessage();
        }
    }
}
