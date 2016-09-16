using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning
{
    public class DatabaseExceptions : Exception
    {
        public DatabaseExceptions()
        {
        }

        public DatabaseExceptions(string msg) : base(msg)
        {
            Console.Write(msg);
        }

        public DatabaseExceptions(string msg, Exception inner) : base(msg, inner)
        {
            Console.Write(msg + inner);
        }
    }
   
}
