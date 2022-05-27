using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYProje
{
    //Youtube Mucit Yazılım Kanalı Veri Yapıları ders videolarından yararlanılmıştır.
    public class StackIslemler:StackADT
    {
        public override void Push(object item)
        {
            Node yeni = new Node(item);

            if (top == null)
            {
                top = yeni;
            }
            else
            {
                yeni.Next = top;
                top = yeni;
            }
        }

        public override void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack boş!");
            }
            else if (top.Next == null)
            {
                top = null;
            }
            else
            {
                top=top.Next;
            }
        }

        public string print()
        {
            string bilgi = "";
            Node temp = top;
            while(temp!=null)
            {
                bilgi += "-->" + temp.Data;
                temp= temp.Next;
            }
            return bilgi;
        }
    }
}
