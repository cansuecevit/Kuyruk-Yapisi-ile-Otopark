using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public interface Queue
    {
        void Insert(Araba a);
        object Remove();
        object Peek();
        Boolean IsEmpty();
        decimal IslemTamamlamaSuresi(decimal IslemSuresi);
        decimal ortalamaITS();
        string listele();
    }
}
