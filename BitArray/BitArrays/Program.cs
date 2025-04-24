using System;
using System.Collections;


//basic operations





namespace BitArrays {
    public class Program    
{

        public static string BitArrayToString(BitArray bitArray)
        {
            char[] chars = new char[bitArray.Length];
           for(int i = 0; i < bitArray.Length; i++)
            {
                chars[i] = bitArray[i] ? '1' : '0';
            }
           return new string(chars);
        }
        static void Main(string[] args)
        {
            //create a bitarray with 10 bits, all initialized to false
            BitArray bits1 = new BitArray(10);

            Console.WriteLine($"bits1 content: {BitArrayToString(bits1)}");

            for (int i = 0; i < bits1.Length; i++)
            {
                bool bitVal = bits1[i];
                Console.WriteLine($"Bit at {i}: {bitVal}");
            }
            //create a bitarray from an array of booleans
            bool[] initialValues = { true, false, true, true, false };
            BitArray bits2 = new BitArray(initialValues);

            Console.WriteLine($"\nbits2 content: {BitArrayToString(bits2)}");

            for (int i = 0; i < bits2.Length; i++)
            {
                bool bitVal = bits2[i];
                Console.WriteLine($"Bit at {i}: {bitVal}");
            }

            //create a bit array from a byte array
            byte[] byteArray = { 0xAA, 0x55 };//10101010,01010101
            BitArray bits3 = new BitArray(byteArray);

            Console.WriteLine($"\nbits3 content: {BitArrayToString(bits3)}");

            for (int i = 0; i < bits3.Length; i++)
            {
                bool bitVal = bits3[i];
                Console.WriteLine($"Bit at {i}: {bitVal}");
            }
        

            //Basic operations
            BitArray bits4= new BitArray(8);

            bits4.Set(2, true);
            bits4.Set(5, true);
            bits4[7]=true;
            bits4[3]=false;

            Console.WriteLine($"\nbits4 content: {BitArrayToString(bits4)}");

            for (int i = 0; i < bits4.Length; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at {i}: {bitVal}");
            }
            bits4.SetAll(true);//setting all bits to true
            bits4.SetAll(false);//setting al bits to false

            Console.ReadKey();
        }
} }


