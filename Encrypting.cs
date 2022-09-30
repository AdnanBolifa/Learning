using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnging
{
    
    public class Encrypting
    {
        int[] msg;
        int key;
        int form;
        public Encrypting(int[] msg, int key, int form)
        {
            this.msg = msg;
            this.key = key;
            this.form = form;
        }

        
        //left shift
        public int[] encrypt()
        {
            for (int i = 0; i < msg.Length; i++)
            {
                msg[i] <<= key;
            }
            return msg;
        }
        public int[] decrypt()
        {
            for (int i = 0; i < msg.Length; i++)
            {
                msg[i] >>= key;
            }
            return msg;
        }

        public void print()
        {
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(Convert.ToString(msg[i], toBase: form) + " ");
            }
            Console.WriteLine();
        }
        public void printinAscii()
        {
            string result = "";
            for (int i = 0; i < msg.Length; i++)
            {
                result += (char)msg[i];
            }
            Console.Write(result + " ");
            Console.WriteLine();
        }
    }
}












