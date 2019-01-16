using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
   public  class CircularQueueAK:Queue
    {
        public object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public decimal ToplamSure = 0;

        public CircularQueueAK(int size)
        {
            this.size = size;
            Queue = new object[size];
        }

        public void Insert(Araba a)
        {
            if (count == size)
                throw new Exception("Kuyruk dolu.");
            if (front == -1)
                front = 0;
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = a;
            }
            else
                Queue[++rear] = a;
                count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public decimal IslemTamamlamaSuresi(decimal IslemSuresi)
        {
            return ToplamSure += IslemSuresi;
        }

        public string listele()
        {
            string temp = "";
            for (int i = 0;i<50; i++)
            {
                temp += "Araba No:   " + ((Araba)Queue[i]).ArabaNo.ToString() + Environment.NewLine + "İşlem Süresi:  "
                      + ((Araba)Queue[i]).IslemSuresi.ToString() + "sn." + Environment.NewLine + "İşinin bitme Süresi:  "
                      + IslemTamamlamaSuresi(((Araba)Queue[i]).IslemSuresi) + " sn." + Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }

        public decimal ortalamaITS()
        {
            return ToplamSure / 50;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Kuyruk boş.");
            object temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1)
                front = 0;
            else
                front++;
                count--;
            return temp;

        }


    }
}
