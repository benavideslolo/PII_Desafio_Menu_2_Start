namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa física en el restaurante.
    /// </summary>
    public class Table
    {
        private Order order = new Order(); // Una orden por mesa

        public int Number { get; set; } // Un numero para identificar a cada mesa
        public bool IsOccupied { get; set; } // Estado de la mesa (ocupada, descupada)

        public Table(int number) // Asigna numero de mesa
        {
            this.Number = number;
        }

        public void Ocupy() // Mesa ocupada
        {
            this.IsOccupied = true;
        }

        public void Free() // Mesa libre y vacía la orden
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish) // Delega a order tras agregar un plato a la orden de la mesa
        {
            this.order.AddToOrder(dish);
        }

        public bool HasOrders() // Si hay al menos un plato devuelve true
        {
            return this.order.HasOrders();
        }
        public double GetTotal() // Devuelve el precio total de la orden
        {
            return this.order.GetTotal();
        }
    }
}