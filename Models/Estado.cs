namespace PizzaPlace.Models
{
    public class Estado
    {
        public Menu Menu { get;} = new Menu();
        public CanastaCompras Canasta {get;} = new CanastaCompras();
        public UI UI {get; set;} = new UI();

    }
}