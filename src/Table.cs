namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa física en el restaurante.
    /// SRP: solo tiene razones de cambio relacionadas con la mesa (ocupación,
    /// número). La lógica de pedidos vive en Order.
    /// </summary>
    public class Table
    {
        private Order order = new Order();

        public int Number { get; set; }
        public bool IsOccupied { get; set; }

        public Table(int number)
        {
            this.Number = number;
        }

        public void Ocupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.AddToOrder(dish);
        }

        public bool HasOrders()
        {
            return this.order.HasOrders();
        }

        /// <summary>
        /// Delega el cálculo del total a Order (Expert).
        /// </summary>
        public double GetTotal()
        {
            return this.order.GetTotal();
        }
    }
}