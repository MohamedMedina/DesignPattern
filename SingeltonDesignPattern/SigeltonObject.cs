using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignPattern
{
  public  class SingletonObject
    {
        // the whole concept in this creational design pattern is to make sharable object within the program and this could be done
        // By defining  private static instance  beside public method to get this instsnce and making the constructor private.

        private static SingletonObject singletonObject = new SingletonObject();

        private SingletonObject()
        {

        }
        public static SingletonObject  GetSingleton()
        {
            return singletonObject;
        }
        public void showMessage()
        {
            Console.WriteLine("hello singleton");
        }
    }
}
