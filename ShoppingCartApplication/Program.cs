namespace ShoppingCartApplication
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }

        public void run()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            ProductGenerator productGenerator = new ProductGenerator();
            productGenerator.InitializeProducts();

            GroceryStore groceryStore = new GroceryStore(productGenerator);
            ClothingStore clothingStore = new ClothingStore(productGenerator);
            ElectronicsStore electronicsStore = new ElectronicsStore(productGenerator);
            while (true)
            {
                Console.WriteLine("Welcome to Sameh Mall");
                Console.WriteLine("Select action:");
                Console.WriteLine("1 - Food");
                Console.WriteLine("2 - Clothing");
                Console.WriteLine("3 - Electronics");
                Console.WriteLine("4 - Random");
                Console.WriteLine("5 - Your Cart");
                Console.WriteLine("6 - End the shopping");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDisplaying food items:");
                        groceryStore.DisplayItems();
                        Console.WriteLine("\nEnter the number of the product to add it to your cart:\n");
                        groceryStore.UpdateItems(shoppingCart);
                        break;
                    case 2:
                        Console.WriteLine("\nDisplaying clothing items:");
                        clothingStore.DisplayItems();
                        Console.WriteLine("\nEnter the number of the product to add it to your cart:\n");
                        clothingStore.UpdateItems(shoppingCart);
                        break;
                    case 3:
                        Console.WriteLine("\nDisplaying electronics items:");
                        electronicsStore.DisplayItems();
                        Console.WriteLine("\nEnter the number of the product to add it to your cart:\n");
                        electronicsStore.UpdateItems(shoppingCart);
                        break;
                    case 4:
                        Console.WriteLine("\nDisplaying random items:\n");
                        var product = productGenerator.RandomItemes(); 
                        shoppingCart.AddItems(product);
                        Console.WriteLine($"{product.Name} has been added to your cart.\n");
                        break;
                    case 5:
                        Console.WriteLine("\nDisplaying your cart items:");
                        shoppingCart.ViewItems();
                        shoppingCart.CalculateTotal();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for your shopping!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
                        break;
                }
            }
        }
    }
}