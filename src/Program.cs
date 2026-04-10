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
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);
            Menu menu = new Menu();
            menu.AddDish(burger);
            menu.AddDish(salad);
            Table oneTable = new Table(1);
            Waiter waiter = new Waiter("John");
            waiter.AssignTable(oneTable);
            oneTable.Ocupy();
            waiter.TakeOrder(oneTable, burger);
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
                $"y la atiende: {waiter.Name}");
            Console.WriteLine(
                $"Total de la mesa {oneTable.Number}: ${oneTable.GetTotal():F2}");
            oneTable.Free();
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
            Order deliveryOrder = new Order();
            deliveryOrder.ParaLlevar = true;
            waiter.Delivery(deliveryOrder, burger);
            waiter.Delivery(deliveryOrder, salad);
            Console.WriteLine(
                $"\nEs para llevar: {deliveryOrder.ParaLlevar}");
            Console.WriteLine(
                $"Total de la orden para llevar: ${deliveryOrder.GetTotal():F2}");
        }
    }
}