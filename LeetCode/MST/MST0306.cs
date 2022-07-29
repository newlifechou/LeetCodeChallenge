using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    internal class MST0306
    {
    }
    /// <summary>
    /// 猫狗队列
    /// animal[0]=编号，animal[1]=动物类型
    /// </summary>
    public class AnimalShelf
    {
        private Queue<int[]> catQ;
        private Queue<int[]> dogQ;
        public AnimalShelf()
        {
            catQ = new Queue<int[]>();
            dogQ = new Queue<int[]>();
        }

        public void Enqueue(int[] animal)
        {
            if (animal[1] == 0)
            {
                catQ.Enqueue(animal);
            }
            else
            {
                dogQ.Enqueue(animal);
            }
        }

        public int[] DequeueAny()
        {
            if(dogQ.Count != 0 && catQ.Count != 0)
            {
                if (catQ.Peek()[0] < dogQ.Peek()[0])
                {
                    return DequeueCat();
                }
                else
                {
                    return DequeueDog();
                }
            }
            else if(dogQ.Count != 0)
            {
                return DequeueDog();
            }
            else if(catQ.Count != 0)
            {
                return DequeueCat();
            }
            else
            {
                return new int[] { -1, -1 };
            }
        }

        public int[] DequeueDog()
        {
            if(dogQ.Count == 0)
            {
                return new[] { -1, -1 };
            }
            else
            {
                return dogQ.Dequeue();
            }
        }

        public int[] DequeueCat()
        {
            if (catQ.Count == 0)
            {
                return new[] { -1, -1 };
            }
            else
            {
                return catQ.Dequeue();
            }
        }
    }
}
