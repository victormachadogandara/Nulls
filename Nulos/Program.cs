﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro miCarro = new Carro();
            miCarro.Marca = "Tsuru";
            miCarro.Kilometraje = 10000;

            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("Kilometraje: " + miCarro.Kilometraje);

            miCarro.DueñoCarro = new Dueño();
            miCarro.DueñoCarro.Nombre = "Pedro";

            miCarro.DueñoCarro = null;

            if (miCarro.DueñoCarro != null)
            {
                Console.WriteLine("Dueño: " + miCarro.DueñoCarro.Nombre);
            }
            else
            {
                Console.WriteLine("Dueño: Not Found");
            }
            Console.ReadLine();

        }
    }
}