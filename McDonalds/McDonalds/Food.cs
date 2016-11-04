using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    abstract class Product
    {

        public double Price
        {
            get; set;
        }

        public int KCal
        {
            get; set;
        }

        public Product(double price, int kcal)
        {
            Price = price;
            KCal = kcal;
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            if(product == null)
            {
                return false;
            }

            return this.Price == product.Price && 
                   this.KCal == product.KCal;
        }

    }

    abstract class Drink : Product
    {
        public Drink(double price, int kcal)
            :base(price, kcal)
        {

        }

        public abstract bool IsHot();


    }

    class CocaCola : Drink
    {
        const int COCACOLA_KCAL = 56;
        public CocaCola(double price)
            :base(price, COCACOLA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            CocaCola cola = obj as CocaCola;
            if(cola == null)
            {
                return false;
            }
            return base.Equals(cola);
        }
    }

    class Fanta : Drink
    {
        const int FANTA_KCAL = 67;
        public Fanta(double price)
            :base(price, FANTA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return false;
        }
        public override bool Equals(object obj)
        {
            Fanta fanta = obj as Fanta;
            if(fanta == null)
            {
                return false;
            }
            return base.Equals(fanta);
        }
    }

    class Tea : Drink
    {
        const int TEA_KCAL = 9;
        public Tea(double price)
            :base(price, TEA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return true;
        }
    }

    abstract class Sandwich : Product
    {
        
        public Sandwich(double price, int kcal)
            :base(price, kcal)
        {

        }
        public virtual bool HasCheese()
        {
            return true;
        } 
    }

    class CheeseBurger : Sandwich
    {
        const int CHEESEBURGER_KCAL = 245;
        public CheeseBurger(double price)
            :base(price,CHEESEBURGER_KCAL)
        {

        }

    }

    class Burger : Sandwich
    {
        const int BURGER_KCAL = 197;
        public Burger(double price)
            :base(price,BURGER_KCAL)
        {

        }
        public override bool HasCheese()
        {
            return false;
        }
    }

    class AvailableFood
    {
        private List<Product> _food = new List<Product>();

        public void AddCocaCola(Product product)
        {
            _food.Add(product);
        }

        public void AddFanta(Product product)
        {
            _food.Add(product);
        }

        public void AddTea(Product product)
        {
            _food.Add(product);
        }

        public void AddCheeseBurger(Product product)
        {
            _food.Add(product);
        }

        public void AddBurger(Product product)
        {
            _food.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _food.Remove(product);
        }

        public override string ToString()
        {
            string result = "Available food:\n";
            _food.ForEach(i => result += i.ToString() + "\n");
            return result;
        }
    }

}
