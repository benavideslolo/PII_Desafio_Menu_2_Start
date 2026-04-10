using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto del entrada al programa.
        /// </summary>
        public static void Main()
        {
            Dish burger = new Dish("Burger", 5.99, false); // Crea un plato con nombre, precio y tipo (vegetariano o no)
            Dish salad = new Dish("Salad", 4.99, true); // ""
            Menu menu = new Menu(); // Crea el menu
            menu.AddDish(burger); // Agrega plato al menu 
            menu.AddDish(salad); // ""
            Table oneTable = new Table(1); // Crea el numero de la mesa
            Waiter waiter = new Waiter("John"); // Crea el mozo
            waiter.AssignTable(oneTable); // Asigna mesa al mozo
            oneTable.Ocupy(); // La mesa pasa a estar ocupada
            waiter.TakeOrder(oneTable, burger); // Toma el pedido 
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +  // Imprime por consola si la mesa esta ocupada (true false)
                $"y la atiende: {waiter.Name}"); 
            Console.WriteLine(
                $"Total de la mesa {oneTable.Number}: ${oneTable.GetTotal():F2}"); // Imprime por consola el precio de la mesa
            oneTable.Free(); // Libera la mesa
            Console.WriteLine( 
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}"); // Cambia el estado de la mesa y pasa a estar libre
            Order deliveryOrder = new Order(); // Crea una orden para llevar
            deliveryOrder.ParaLlevar = true; // Asigna la orden a delvery 
            waiter.Delivery(deliveryOrder, burger); // Se agregan platos a la orden
            waiter.Delivery(deliveryOrder, salad); // ""
            Console.WriteLine(
                $"\nEs para llevar: {deliveryOrder.ParaLlevar}"); // Imprime por consola si la orden es para llevar (true false)
            Console.WriteLine(
                $"Total de la orden para llevar: ${deliveryOrder.GetTotal():F2}"); // Imprime por consola el precio final de la orden
        }
    }
}