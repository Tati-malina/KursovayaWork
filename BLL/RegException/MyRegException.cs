using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class MyRegException : Exception
    {
        public MyRegException(string key) { throw new Exception($"перевірте коректність вводу даних поля \"{key}\""); }
    }
}
