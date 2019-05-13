using System;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton[] singletons = new Singleton[6];
            Parallel.For(0, singletons.Length, i => singletons[i] = Singleton.Create());
            foreach(var singleton in singletons){
                Console.WriteLine(singleton);
            }
        }
    }
}
