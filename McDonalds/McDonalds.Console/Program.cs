using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL;
using McDonalds.BL.Products;

namespace McDonalds.CMD
{
    class Program
    {
        const int BIG_MAC_COMMAND = 1;
        const int BIG_TASTY_COMMAND = 2;
        const int BURGER_COMMAND = 3;
        const int CHEESE_BURGER_COMMAND = 4;
        const int CHEESE_BURGER_WITH_BACON_COMMAND = 5;
        const int DOUBLE_CHEESE_BURGER_COMMAND = 6;
        const int FILET_O_FISH_COMMAND = 7;
        const int MC_CHICKEN_COMMAND = 8;
        const int ROYAL_CHEESE_BURGER_COMMAND = 9;

        const int AMERICANO_COMMAND = 1;
        const int CAPPUCCINO_COMMAND = 2;
        const int ESPRESSO_COMMAND = 3;
        const int LATTE_COMMAND = 4;
        const int TEA_COMMAND = 5;
        const int COCA_COLA_COMMAND = 6;
        const int FANTA_COMMAND = 7;
        const int SPRITE_COMMAND = 8;
        const int ORANGE_JUICE_COMMAND = 9;

        const int PIE_WITH_CHERRY_COMMAND = 1;

        static void PrintProducts()
        {
            Console.WriteLine("Select your products: ");
            Console.WriteLine("");
            Console.WriteLine("1:Sandwiches ");
            Console.WriteLine("2:Drink ");
            Console.WriteLine("3:Other ");
                        
        }

        static void Sandwiches()
        {
            Console.WriteLine("");
            Console.WriteLine("1: BigMac");
            Console.WriteLine("2: BigTasty");
            Console.WriteLine("3: Burger");
            Console.WriteLine("4: CheeseBurger");
            Console.WriteLine("5: CheeseBurgerWithBacon");
            Console.WriteLine("6: DoubleCheeseBurger");
            Console.WriteLine("7: FiletOFish");
            Console.WriteLine("8: McChicken");
            Console.WriteLine("9: RoyalCheeseBurger");
        }

        static void Drink()
        {
            Console.WriteLine("");
            Console.WriteLine("1: Americano");
            Console.WriteLine("2: Cappuccino");
            Console.WriteLine("3: Espresso");
            Console.WriteLine("4: Latte");
            Console.WriteLine("5: Tea");
            Console.WriteLine("6: CocaCola");
            Console.WriteLine("7: Fanta");
            Console.WriteLine("8: Sprite");
            Console.WriteLine("9: OrangeJuice");
        }

        static void Other()
        {
            Console.WriteLine("");
            Console.WriteLine("1: PieWithCherry");
        }

        public static Product SelectSandwich()
        {
            Sandwiches();
            Console.WriteLine();
            Console.WriteLine("What do you want to add to your order?");
            Product selectedProduct = null;
            int addToOrderSandwiches = Convert.ToInt32(Console.ReadLine());
            switch (addToOrderSandwiches)
            {
                case BIG_MAC_COMMAND:
                    selectedProduct = new BL.Products.BigMac(25);
                    break;

                case BIG_TASTY_COMMAND:
                    selectedProduct = new BL.Products.BigTasty(68);
                    break;

                case BURGER_COMMAND:
                    selectedProduct = new BL.Products.Burger(20);
                    break;

                case CHEESE_BURGER_COMMAND:
                    selectedProduct = new BL.Products.CheeseBurger(22);
                    break;

                case CHEESE_BURGER_WITH_BACON_COMMAND:
                    selectedProduct = new BL.Products.CheeseBurgerWithBacon(23);
                    break;

                case DOUBLE_CHEESE_BURGER_COMMAND:
                    selectedProduct = new BL.Products.DoubleCheeseBurger(28);
                    break;

                case FILET_O_FISH_COMMAND:
                    selectedProduct = new BL.Products.FiletOFish(40);
                    break;

                case MC_CHICKEN_COMMAND:
                    selectedProduct = new BL.Products.McChicken(40);
                    break;

                case ROYAL_CHEESE_BURGER_COMMAND:
                    selectedProduct = new BL.Products.RoyalCheeseBurger(42);
                    break;
            }
            return selectedProduct;
        }

        public static Product SelectDrink()
        {
            Drink();
            Console.WriteLine();
            Console.WriteLine("What do you want to add to your order?");
            Product selectedProduct = null;
            int addToOrderDrink = Convert.ToInt32(Console.ReadLine());
            switch (addToOrderDrink)
            {
                case AMERICANO_COMMAND:
                    selectedProduct = new BL.Products.Americano(22);
                    break;

                case CAPPUCCINO_COMMAND:
                    selectedProduct = new BL.Products.Cappuccino(22);
                    break;

                case ESPRESSO_COMMAND:
                    selectedProduct = new BL.Products.Espresso(15);
                    break;

                case LATTE_COMMAND:
                    selectedProduct = new BL.Products.Latte(22);
                    break;

                case TEA_COMMAND:
                    selectedProduct = new BL.Products.Tea(20);
                    break;

                case COCA_COLA_COMMAND:
                    selectedProduct = new BL.Products.CocaCola(19);
                    break;

                case FANTA_COMMAND:
                    selectedProduct = new BL.Products.Fanta(19);
                    break;

                case SPRITE_COMMAND:
                    selectedProduct = new BL.Products.Sprite(19);
                    break;

                case ORANGE_JUICE_COMMAND:
                    selectedProduct = new BL.Products.OrangeJuice(24);
                    break;

            }
            return selectedProduct;
        }

        public static Product SelectOther()
        {
            Other();
            Console.WriteLine();
            Console.WriteLine("What do you want to add to your order?");
            Product selectedProduct = null;
            int addToOrderOther = Convert.ToInt32(Console.ReadLine());
            switch (addToOrderOther)
            {
                case PIE_WITH_CHERRY_COMMAND:
                    selectedProduct = new BL.Products.PieWithCherry(21);
                    break;
            }
            return selectedProduct;
        }
    


        static void Main(string[] args)
        {
            
            bool condition = true;
            Orders ordersManager = new BL.Orders();

            while (condition)
            {
                Console.WriteLine("Do you want to make order? yes or no");
                Console.WriteLine();
                string q = Console.ReadLine();

                if (q == "no")
                {
                    break;
                }
                Order order = new BL.Order();

                bool continueProductsAdding = true;

                while (continueProductsAdding)
                {
                    Console.WriteLine();
                    PrintProducts();
                    Console.WriteLine();
                    int product = Convert.ToInt32(Console.ReadLine());

                    if (product == 1)
                    {
                        Product selectedSandwich = SelectSandwich();
                        if (selectedSandwich != null)
                        {
                            order.Add(selectedSandwich);
                        }
                    }                    

                    if(product == 2)
                    {
                        Product selectedDrink = SelectDrink();
                        if(selectedDrink != null)
                        {
                            order.Add(selectedDrink);
                        }                                                
                    }

                    if (product == 3)
                    {
                        Product selectedOther = SelectOther();
                        if(selectedOther != null)
                        {
                            order.Add(selectedOther);
                        }
                        
                    }
                    
                }            

                
                

            }
        }
    }
}
