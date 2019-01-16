using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class Otoparkımız
    {
        public CircularQueueAK c = new CircularQueueAK(50);
        public PriorityQueueAK p = new PriorityQueueAK(50);
        Random r = new Random();
        public Otoparkımız()
        {
            for (int i = 0; i < 50; i++)
            {
                Araba a = new Araba();
                a.ArabaNo = i + 1;
                a.IslemSuresi = r.Next(10, 300);
                c.Insert(a);
                p.Insert(a);

            }
        }
        public string FarklarıBul()
        {
            string temp = "";
            c.ToplamSure = 0;
            for (int i = 0; i < 50; i++)
            {
                p.toplamSure = 0;
                decimal CircularToplamSure = c.IslemTamamlamaSuresi(((Araba)c.Queue[i]).IslemSuresi);
                for (int j = 0; j < 50; j++)
                {
                    decimal PriorityToplamSure = p.IslemTamamlamaSuresi(((Araba)p.Queue[j]).IslemSuresi);
                    if (((Araba)p.Queue[j]).ArabaNo == i + 1)
                    {
                        if (CircularToplamSure > PriorityToplamSure)
                        {
                            temp += "Araba No:       " + ((Araba)p.Queue[j]).ArabaNo.ToString() +
                                Environment.NewLine + "İşlem Süresi:        " + ((Araba)p.Queue[j]).IslemSuresi.ToString() + "sn"+
                                Environment.NewLine + "Kazanç(Fark):        " + (CircularToplamSure - PriorityToplamSure).ToString() +
                                Environment.NewLine + "Kazanç(Yüzde):       " + String.Format("{0:0.00}", ((PriorityToplamSure * 100) / CircularToplamSure)) +
                                Environment.NewLine + Environment.NewLine;
                        }
                        break;
                    }
                }
            }
            return temp;
        }
    }
}