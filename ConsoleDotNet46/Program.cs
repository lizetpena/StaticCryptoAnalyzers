﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleDotNet46
{
    /// <summary>
    /// This Program class is only meant to test the Microsoft.NetFramework.Analyzers and the FxCop nuget packages
    /// This Nuget packages detect the use of weak crypto
    /// algorithms.
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cipher = TripleDES.Create();
            cipher.CreateEncryptor();

            var cipher2 = DES.Create();
            cipher2.CreateEncryptor();

            var hash = MD5.Create();
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes("string to hash"));

        }
    }
}
