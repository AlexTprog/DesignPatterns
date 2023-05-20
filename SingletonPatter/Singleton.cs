using System.Globalization;
using System.Data;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPatter
{
    public class Singleton
    {
        private static Singleton? _singleton;

        private Singleton(){}

        public static Singleton GetInstance(){
            if(_singleton == null){
                _singleton = new Singleton();
            }            
            return _singleton;            
        }

    }
}