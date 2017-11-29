using System;

namespace Singleton
{
    public class Singleton
    {
        private Singleton instance; Object locker;

        private Singleton()
        {
            locker = new Object();
        }

        public Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }

        static void Main(string[] args)
        {

        }
    }
}
