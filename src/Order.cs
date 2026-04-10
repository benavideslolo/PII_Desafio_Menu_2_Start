using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un conjunto de platillos pedidos tanto por una mesa como para llevar.
    /// </summary>
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();

        public bool ParaLlevar { get; set; } // Un bool que indica si la orden va a ser para llevar

        public void AddToOrder(Dish dish) // Metodo para agregar el plato a los pedidos
        {
            this.dishes.Add(dish);
        }

        public bool HasOrders() // Metodo para ver si hay platos en la orden, nos va a devolver true si tiene al menos uno.
        {
            return this.dishes.Count > 0; // Devuelve true si es > 0
        }

        public int Count // Cuenta la cantidad de platos que hay en una orden
         {
            get {return this.dishes.Count;}  
        }

        public double GetTotal()        //Metodo para poder conocer el precio total de la orden 
        {
            double total = 0;
            foreach (Dish dish in this.dishes)
            {
                total += dish.Price;
            }
            return total;
        }

        public void Clear() // Cuando la mesa queda libre se vacia la lista de platos 
        {
            this.dishes.Clear();
        }

        
    }
}