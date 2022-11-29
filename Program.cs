using System;
/***
 * 
 *  @author Jordi Matorrales
 * 
 */
class Juego_bombScape
{
    static void Main(String[] args)
    {
        // Preguntar tamaño tablero (tamaño minimo)
        // preguntar si quiere visualizar notificaciones
        //crear clase jugador (vidas)

        Player player = new Player();
        Table table = new Table();
        try
        {
            Console.WriteLine("Buenos dias jugador! \nIntroduzca su nombre de usuario:");

            String name = Console.ReadLine();

            Console.WriteLine($"Nombre aceptado. \nBienvenido jugador {name}!");
            player.namePlayer = name;

            Console.WriteLine("");

            Console.WriteLine("Tamaño por defecto del tablero 7x7");
            //int size = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("indique la dificultad del juego");
            Console.WriteLine("1. Facil (4-bombas / 3-vidas) \n2. Medio (6-bombas / 2-vidas) \n3. Dificil (8-bombas / 1-vidas)");
            int dificultad = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Creando tablero\n ");
            table.createTable(7, 4);
            table.viewTable();

        }
        catch(Exception e) { /*todo: crear un trow log*/ }
        finally 
        {
            player.deletePlayer();
            table.deleteTable();
        }
    }
}
