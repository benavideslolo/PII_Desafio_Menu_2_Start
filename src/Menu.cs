using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish) // Agrega plato al menu
        {
            this.dishes.Add(dish);
        }

        public void RemoveDish(Dish dish) // Quita plato del menu
        {
            this.dishes.Remove(dish);
        }

        public Dish GetDishByName(string name) // Busca un plato por nombre en el menu, si no lo encuentra nos devuelvo null
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }

            return null;
        }
    }
}