using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un conjunto de platillos pedidos tanto por una mesa como para llevar.
    /// </summary>
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();

        public bool ParaLlevar { get; set; }

        public void AddToOrder(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public bool HasOrders()
        {
            return this.dishes.Count > 0;
        }

        public int Count
        {
            get { return this.dishes.Count; }
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in this.dishes)
            {
                total += dish.Price;
            }
            return total;
        }

        public void Clear()
        {
            this.dishes.Clear();
        }

        
    }
}