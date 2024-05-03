using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Nave
    {
        public float Vida { get; set; }
        public Point Posicion { get; set; }
        public prueba0_1 VentanaC { get; set; }
        public List<Point> PosicionesNave { get; set; }


        public Nave(Point posicion, prueba0_1 ventana)
         
        {
            Posicion = posicion;
            VentanaC = ventana;
            Vida = 100;
            PosicionesNave = new List<Point>();
        }
        public void Dibujar()
        {
            int x = Posicion.X;
            int y = Posicion.Y;

            Console.SetCursorPosition(x + 3, y);
            Console.Write("I");

            PosicionesNave.Clear();

            PosicionesNave.Add(new Point(x + 3, y));
        }
        public void Borrar()
        {
            foreach (Point item in PosicionesNave)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(" ");
            }
        } 
        public void Teclado(ref Point distancia, int velocidad)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if(tecla.Key == ConsoleKey.W)
                distancia = new Point(0, -1);
            if (tecla.Key == ConsoleKey.S)
                distancia = new Point(0, 1);
            if (tecla.Key == ConsoleKey.D)
                distancia = new Point(1, 0);
            if (tecla.Key == ConsoleKey.A)
                distancia = new Point(-1, 0);

            distancia.X *= velocidad;
            distancia.Y *= velocidad;
            Posicion = new Point(Posicion.X + distancia.X, Posicion.Y + distancia.Y);
        }

        public void Mover(int velocidad)
        {
            if (Console.KeyAvailable)
            {
                Borrar();
                Point distancia = new Point();
                Teclado(ref distancia, velocidad);

                Dibujar();
            }
        }
    }
}
