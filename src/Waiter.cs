using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();

        public string Name { get; set; } // Nombre del mozo

        public Waiter(string name) // Recibe el nombre del mozo y lo asigna
        {
            this.Name = name;
        }

        public void AssignTable(Table table) // Agrega la mesa asignada a una lista con las mesas que le corresponden a cada mozo
        {
            this.assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish) // El mozo toma el pedido
        {
            table.AddToOrder(dish);
        }

        public void Delivery(Order order, Dish dish) // Se delega a order el pedido para llevar 
        {
            order.AddToOrder(dish);                  
        }
    }
}