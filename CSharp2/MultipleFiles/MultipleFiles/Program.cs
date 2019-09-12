using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFiles
{
    public class Estudiante
    {
        bool IsRegistry = false;
        List<int> list = new List<int>()
        {
            132133,2332321,321333
        };
        public void registrarEstudiante()
        {
            string name = "Juan";
            int ci = 654465654;
            if (ControlEstudiante(ci))
                Console.WriteLine("Esta registrado");
            else
                Console.WriteLine("No esta registrado");
        }

        public bool ControlEstudiante(int ci)
        {
            foreach (var item in list)
            {
                if (item.Equals(ci))
                { 
                    IsRegistry = true;
                }
            }
            return IsRegistry;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e = new Estudiante();
            e.registrarEstudiante();
            
            Console.ReadKey();
        }
    }
}
