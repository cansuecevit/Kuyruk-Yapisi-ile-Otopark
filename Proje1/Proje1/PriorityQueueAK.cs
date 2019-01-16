using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class PriorityQueueAK : Queue
    {
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public decimal toplamSure = 0;
        public PriorityQueueAK(int size)
        {
            this.size = size;
            Queue = new object [size];
        }public void Insert(Araba a)
        {
            if (count == size)
                throw new Exception("Kuyruk Dolu.");
            if (IsEmpty())
            {
                Queue[++front] = a;
                count++;
            }
            else
            {
                int i;
                Araba arb = (Araba)a;
                for (i = count - 1; i >= 0; i--)
                {
                    //Küçükten Büyüğe sıralama
                    if (arb.IslemSuresi < ((Araba)Queue[i]).IslemSuresi)
                        Queue[i + 1] = Queue[i];

                    else
                        break;
                }
                Queue[i + 1] = a;
                front++;
                count++;
            }
             }
        public bool IsEmpty()
        {
            return (count == 0);
        }

        public decimal IslemTamamlamaSuresi(decimal IslemSuresi)
        {
            return toplamSure += IslemSuresi;
        }

        public string listele()
        {
            string temp = " ";
            for (int i = 0; i < 50; i++)
            {
                temp += "Araba No:    " + ((Araba)Queue[i]).ArabaNo.ToString() + Environment.NewLine + "İşlem Süresi: "
                    + ((Araba)Queue[i]).IslemSuresi.ToString() + "sn." + Environment.NewLine + "İşinin Bitme Süresi: " +
                   IslemTamamlamaSuresi(((Araba)Queue[i]).IslemSuresi)+ "sn. " + Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }
        public decimal ortalamaITS()
        {
            return toplamSure / 50;
        }
        public object Peek()
        {
            return Queue[front];
        }
        public object Remove()
        {
            if(IsEmpty())
                throw new Exception("Kuyruk Boş.");
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

     


    }

}
