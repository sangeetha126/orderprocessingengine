using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Product;
using CompanyName.AppName.OrderProcessEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.AppName.OrderProcessingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Order");
            var bookProduct = new Book();
            var bookOrder = new Order(bookProduct);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(bookOrder);
            foreach (var item in bookOrder.OrderAction)
            {                
                Console.WriteLine("Action = {0}, IsCompleted = {1}", item.Key, item.Value);
            }
            

            Console.WriteLine("Membership Order");            
            var membership = new Membership(MembershipType.New);            
            var membershipOrder = new Order(membership);
            ruleEngine.Execute(membershipOrder);
            foreach (var item in membershipOrder.OrderAction)
            {
                Console.WriteLine("Action = {0}, IsCompleted = {1}", item.Key, item.Value);
            }            
            Console.ReadLine();


        }
    }
}
