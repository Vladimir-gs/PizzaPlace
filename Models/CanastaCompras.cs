using System.Collections.Generic;
using PizzaPlace.Models;

namespace PizzaPlace.Models
{
    public class CanastaCompras
    {
        public Clientes Clientes {get; set;} = new Clientes();
        public List<int> Pedidos {get; set;} =new List<int>();
        public bool Pagado {get; set;}
        public void Add(int pizzaId) => Pedidos.Add(pizzaId);
        public void RemoveAt(int pos) => Pedidos.RemoveAt(pos);
    }
}