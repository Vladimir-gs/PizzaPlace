using System.Collections.Generic;
using PizzaPlace.Models;

namespace PizzaPlace.Models
{
    public class CanastaCompras
    {
        public Clientes Clientes {get; set;} = new Clientes();
        public List<int> Otros {get; set;} =new List<int>();
        public bool Pagado {get; set;}
    }
}