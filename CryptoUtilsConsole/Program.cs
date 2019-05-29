using CryptoUtilsConsole.AsymmetricCrypto;
using CryptoUtilsConsole.hashing;
using CryptoUtilsConsole.symmetric_crypto;
using System;
using System.Diagnostics;

namespace CryptoUtilsConsole
{
    public enum CryptoOperation
    {
        ENCRYPT,
        DECRYPT
    };

    class Program
    {
       
        static void Main(string[] args)
        {
            double AesTicks = 0;
            double DesTicks = 0;
            double RsTicks = 0;
            Stopwatch AesTime;
            Stopwatch DesTime;
            Stopwatch RsTime;

            // WARNING
            // the below code is only meant to indicate you where the snippets you are looking
            // for are, if you run this code as is, the app crashes because it will not find a the hardcoded
            // file path to encrypt Hashing



            //HmacMD5Demos.LaunchDemo();
            //HmacSHA1Demos.LaunchDemo();
            //Md5Demos.LaunchDemo();
            //Sha1Demos.LaunchDemo();
            //Sha256Demos.LaunchDemo();
            //Sha512Demos.LaunchDemo();

            // Symmetric crypto
//******************AES TIMER***********************
            AesTime = Stopwatch.StartNew();

            AESDemos.LaunchDemo();

            AesTime.Stop();

            AesTicks = AesTime.ElapsedTicks;

           Console.WriteLine("AES Algorithm RunTime:   " + AesTicks/100 + "nanoseconds");

            //******************DES TIMER***********************
            DesTime = Stopwatch.StartNew();

            DESDemos.LaunchDemo();

            DesTime.Stop();

            DesTicks = DesTime.ElapsedTicks;

            Console.WriteLine("DES Algorithm RunTime:   " + DesTicks / 100 + "nanoseconds");

            // DESDemos.LaunchFileDemo();

            //TripleDESDemos.LaunchDemo();


            
            // Asymmetric crypto

            RsTime = Stopwatch.StartNew();

            RSACspDemo.LaunchDemo();

            RsTime.Stop();

            RsTicks = RsTime.ElapsedTicks;

            Console.WriteLine("RSA Algorithm RunTime:   " + RsTicks / 100 + "nanoseconds");

            Console.ReadLine();

            //RsaFileDemo.LaunchDemo();
            //RsaInMemoryDemo.LaunchDemo();
        }
    }
}