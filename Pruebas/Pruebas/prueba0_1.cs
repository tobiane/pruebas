using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class prueba0_1
    {
        public int Ancho { get; set; }
        public int Altura { get; set; }
        public Point LimiteSuperior { get; set; }
        public Point LimiteInferior { get; set; }

        public prueba0_1(int ancho, int altura, Point limiteSuperior, Point limiteInferior)
        {
            Ancho = ancho;
            Altura = altura;
            LimiteSuperior = limiteSuperior;
            LimiteInferior = limiteInferior;
            Init();
        }

        private void Init ()
        {
            Console.SetWindowSize(Ancho, Altura);
            Console.Title = "Prueba";
            Console.CursorVisible = false;
        }
        public void DibujarMarco()
        {
            for (int i = LimiteSuperior.X ;i <= LimiteInferior.X; i++ )
            {
                Console.SetCursorPosition(i, LimiteSuperior.Y);
                Console.Write("=");
                Console.SetCursorPosition(i, LimiteInferior.Y);
                Console.Write("=");
            }
            for (int i= LimiteSuperior.Y; i <= LimiteInferior.Y; i++)
            {
                Console.SetCursorPosition(LimiteSuperior.X, i);
                Console.Write("║");
                Console.SetCursorPosition(LimiteInferior.X, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(LimiteSuperior.X, LimiteSuperior.Y);
            Console.Write("╔");
            Console.SetCursorPosition(LimiteSuperior.X, LimiteInferior.Y);
            Console.Write("╚");
            Console.SetCursorPosition(LimiteInferior.X, LimiteSuperior.Y);
            Console.Write("╗");
            Console.SetCursorPosition(LimiteInferior.X, LimiteInferior.Y);
            Console.Write("╝");
        }

    }
}
