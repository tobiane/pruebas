using Pruebas;
using System.Drawing;

prueba0_1 ventana;
Nave nave;
bool jugar = true;




void Iniciar()
{
    prueba0_1 ventana = new prueba0_1(170, 45, new Point(5, 5), new Point(165, 40));
    ventana.DibujarMarco();
    nave = new Nave(new Point(80,30),ventana);
    nave.Dibujar();
}

void Game()
{
    while (jugar)
    {
        nave.Mover(2);
    }
}

Iniciar();
Game();
Console.ReadKey();
