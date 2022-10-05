using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria.Models
{
    //CLASSE PIZZA
    public class Pizza
    {
        public int id { get; set; }

        //[Required(ErrorM)]
        public string Nome { get; set; }
        public string Description { get; set; }
        public string Pic { get; set; }
        public float Price { get; set; }

        //COSTRUTTORE VUOTO
        public Pizza()
        {

        }

        //COSTRUTTORE
        public Pizza(string nome, string description, string pic, float price)
        {
            Nome = nome;
            Description = description;
            Pic = pic;
            Price = price;
        }
    }
}
