using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_ex2 {
    class Program {
        static void Main(string[] args) {

            // Create Inventory, add things to it.
            Inventory obj = new Inventory(5);
            addInventory(obj); // adds 5 items to inventory.

            // Create Holding Bag
            var bagOfHolding = new BagOfHolding(5);

            // Add 'Bag' to inventory
            obj.add(bagOfHolding);

            // Add things to Bag.
            addToBag(bagOfHolding);

            // Print Inventory Data.
            printInventoryTotal(obj);
            printWeightTotal(obj);
            Console.Read();
        }
        public static void addInventory(Inventory x) {
            x.add(new sword());
            x.add(new potion());
            x.add(new wand());
            x.add(new cloak());
            x.add(new hammer());
        }
        public static void addToBag(BagOfHolding x) {
            x.add(new sword());
            x.add(new potion());
            x.add(new wand());
            x.add(new cloak());
            x.add(new hammer());
        }
        public static void printInventoryTotal(Inventory x) {
            Console.WriteLine("\n");
            Console.WriteLine("Total Number of Items in" +
                                $" Inventory: {x.totalItems}");
        }
        public static void printWeightTotal(Inventory x) {
            Console.WriteLine($"The Total Weight is: {x.totalWeight()} pounds");
        }
    
    }

    interface IContainer {
        // IContainer Interface
        void add(Item x);
        int totalCount();
        double totalWeight();
    }
    abstract class Item {
        // Abstract BASE class
        double cost, weight;

        public string costToString(int x) {
            string amount = x.ToString("C2");

            return amount;
        }
        public void setCost(int x) { cost = x; }
        public double getCost() { return cost; }
        public void setWeight(int x) { weight = x; }
        public double getWeight() { return weight; }
    }
    class Inventory : IContainer {
        // Inventory Class
        public int totalItems = 0;
        public double Weight = 0;

        public Inventory(int x) {
            // Constructor
            totalItems = x;
        }
        public void add(Item x) {
            // Add Item to Container
            // totalItems = totalItems + 1;
            Weight = totalWeight() + x.getWeight();
        }
        public int totalCount() {
            // Calculate recursively
            return totalItems;
        }
        public double totalWeight() {
            // Calculate recursively
            return Weight;
            
        }
        public int getTotalItems() { return totalItems; }
    }
    class BagOfHolding : Item, IContainer {
        // BagOfHolding Class
        int size, weight ;
        public BagOfHolding(int x) {
            // Constructor
            size = x;
            weight = 0;
        }

        public void add(Item x) {
            // Add Item to Container
            totalCount();
            totalWeight();
        }
        public int totalCount() {
            // Calculate recursively
            return size; // filler
        }
        public double totalWeight() {
            // Calculate recursively
            return weight; // Filler
        }
    }
    
}