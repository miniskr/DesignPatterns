using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    class SingletonPattern
    {
    }

    class SingleThread_Singleton
    {
        private static SingleThread_Singleton instance = null;
        private SingleThread_Singleton() { }
        public static SingleThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleThread_Singleton();
                }
                return instance;
            }
        }
    }

    class MultiThread_Singleton
    {
        private static volatile MultiThread_Singleton instance = null;
        private static readonly object lockHelper = new object();
        private MultiThread_Singleton() { }
        public static MultiThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new MultiThread_Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }

    class Static_Singleton
    {
        public static readonly Static_Singleton instance = new Static_Singleton();
        private Static_Singleton() { }
    }
}
