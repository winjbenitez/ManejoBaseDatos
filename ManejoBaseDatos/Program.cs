using System;

namespace ManejoBaseDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            conectandonos();
        }
        public static void conectandonos()
        {
            string cadenaConexion = @"Server=.\MSSQLSERVER2022; DataBase=Instituto X; User=sa;Password=;";
        }
    }
}
