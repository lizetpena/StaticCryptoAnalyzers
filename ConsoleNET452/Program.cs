using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleNET452
{
    /// <summary>
    /// This console class is only meant to test the Microsoft.NetFramework.Analyzers nuget package to see if it detects the use of weak crypto
    /// algorithms.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var cipher = TripleDES.Create();            
            cipher.CreateEncryptor();

            var cipher2 = DES.Create();
            cipher2.CreateEncryptor();

            var hash = MD5.Create();
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes("string to hash"));

        }
    }
}
