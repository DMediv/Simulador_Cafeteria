using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Cafeteria.Bebidas
{
    internal class Bebidas
    {
        private string Nombre;
        private string Tamaño;
        private double Precio;


        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string tamaño
        {
            get { return Tamaño; }
            set { Tamaño = value; }
        }

        public double precio
        {
            get { return Precio; }
            set
            {
                if (value > 0)
                {
                    Precio = value;
                }
                else
                {
                    Precio = -1;
                }
            }
        }

        public Bebidas()
        {
            nombre = "";
            tamaño = "";
            precio = 0;


        }
        public Bebidas(string nombre, string tamaño, double precio)
        {

            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        //Metod para aplicar descuento
        public void AplicarDescuento(double porcentaje)
        {
            double descuento = precio * (porcentaje / 100);
            precio = precio - descuento;
        }

        //Metodo preparar bebidas
        public void Preparar()
        {
            Console.WriteLine("Preparando un " + nombre + " tamaño " + tamaño + " con un precio de: $" + precio);
        }

        //Metodo para mosntrar 
        public void MostrarDescripcion()
        {
            Console.WriteLine("Esto es un " + nombre + " de tamaño " + tamaño + " con un precio de $" + precio);
        }


        static void Main(string[] args)
        {
            // Variables temporales
            string nombre;
            string tamaño;
            double precio;

            // ===== BEBIDA 1 =====
            Console.WriteLine("Ingrese los datos de la bebida 1");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Tamaño: ");
            tamaño = Console.ReadLine();

            Console.Write("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());

            Bebidas bebida1 = new Bebidas(nombre, tamaño, precio);

            // ===== BEBIDA 2 =====
            Console.WriteLine("\nIngrese los datos de la bebida 2");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Tamaño: ");
            tamaño = Console.ReadLine();

            Console.Write("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());

            Bebidas bebida2 = new Bebidas(nombre, tamaño, precio);

            // ===== BEBIDA 3 =====
            Console.WriteLine("\nIngrese los datos de la bebida 3");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Tamaño: ");
            tamaño = Console.ReadLine();

            Console.Write("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());

            Bebidas bebida3 = new Bebidas(nombre, tamaño, precio);

            // Aplicar descuento a la bebida 1
            bebida1.AplicarDescuento(10);

            // Preparar bebidas
            bebida1.Preparar();
            bebida2.Preparar();
            bebida3.Preparar();

            // Mostrar descripciones
            Console.WriteLine("--- DESCRIPCIÓN DE BEBIDAS ---");

            bebida1.MostrarDescripcion();
            bebida2.MostrarDescripcion();
            bebida3.MostrarDescripcion();

        }
    }
}
