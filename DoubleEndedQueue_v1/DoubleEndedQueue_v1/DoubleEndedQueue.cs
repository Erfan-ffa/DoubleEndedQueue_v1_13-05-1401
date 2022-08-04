using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue_v1
{
    public class DoubleEndedQueue
    {
        int[] array;
        int front = -1;
        int rear;

        public DoubleEndedQueue(int length)
        {
            array = new int[length];
            rear = length;
        }


        public bool IsEmpty(string arrayName)
        {
            bool result = false;
            switch (arrayName)
            {
                case "rear":
                    if (rear >= array.Length)
                        result = true;
                    break;
                case "front":
                    if (front == -1)
                        result = true;
                    break;
            }
            return result;
        }

        public bool IsFull()
        {
            if (front + 1 == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EnqueueFront(int pushItem)
        {
            if (!IsFull())
            {
                front++;
                array[front] = pushItem;
            }
            else
            {
                Console.WriteLine("arrya is full to push to the front");
            }
        }

        public void EnqueueBack(int item)
        {
            if (!IsFull())
            {
                rear--;
                array[rear] = item;
            }
            else
            {
                Console.WriteLine("array is full to push to the back");
            }
        }


        public void DequeueFront()
        {
            if (!IsEmpty("front"))
            {
                int result = array[front];
                Console.WriteLine(result);
                front--;
            }
            else
            {
                Console.WriteLine("array is empty to pop from front");
            }

        }

        public void DequeuBack()
        {
            if (!IsEmpty("rear"))
            {
                int result = array[rear];
                Console.WriteLine(result);
                rear++;
            }
            else
            {
                Console.WriteLine("array is emtpy to pop from back");
            }
        }

        public void PrintMembers()
        {
            if (!(rear == front))
            {
                for (int i = 0; i <= front; i++)
                {
                    Console.Write(array[i] + " ");
                }

                for (int i = rear; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

            }
            else
            {
                Console.WriteLine("array is emtpy to print");
            }
        }
    }
}
