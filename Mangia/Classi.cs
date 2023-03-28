using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Mangia
{
    public interface IMangia
    {
        void Mangia();
    }
    public class Persona : IMangia
    {
        public void Mangia()
        {
            Console.WriteLine("La persona mangia");
        }
    }
    public class Alfiere : IMangia
    {
        public void Mangia()
        {
            Console.WriteLine("L'alfiere mangia");
        }
    }
}
