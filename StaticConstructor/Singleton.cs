using System;
using System.Threading;

namespace StaticConstructor
{
    public class Singleton{
        private static Singleton _singleton;
        static Singleton(){
            _singleton = new Singleton();
        }
        private readonly String _name;
        private Singleton(){
            _name = $"ID #{ThreadId}";
        }
        public override String ToString() => _name;
        public static Singleton Create() {
            Console.WriteLine($"Create on thread id: {ThreadId}");
            return _singleton;
        }
        private static Int32 ThreadId => Thread.CurrentThread.ManagedThreadId;
    }
}