﻿namespace Learnging
{
    class Program
    {
        public static void Main()
        {
            //!Hello,Girls!
            int[] msg = {    0b_00100001, 0b_01001000, 0b_01100101, 0b_01101100, 0b_01101100,
                             0b_01101111, 0b_00101100, 0b_00100000, 0b_01000111, 0b_01101001,
                             0b_01110010, 0b_01101100, 0b_01110011, 0b_00100001 };
                             
            //!Correct, You nailed it!
            int[] msg2 = {  0b_00100001, 0b_01000011, 0b_01101111, 0b_01110010, 0b_01110010,
                            0b_01100101, 0b_01100011, 0b_01110100, 0b_00101100, 0b_00100000,
                            0b_01011001, 0b_01101111, 0b_01110101, 0b_00100000, 0b_01101110,
                            0b_01100001, 0b_01101001, 0b_01101100, 0b_01100101, 0b_01100100,
                            0b_00100000, 0b_01101001, 0b_01110100, 0b_00100001 };

            Encrypting encrypting = new Encrypting(msg2, 4);

            Console.WriteLine("--- MESSAGE ----");
            encrypting.print();
            Console.WriteLine("--- ENCRYPTED ----");
            encrypting.encrypt();
            encrypting.print();
            Console.WriteLine("--- DECRYPTED ----");
            encrypting.decrypt();
            encrypting.print();
        }
    }
}
    
