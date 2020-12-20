using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CompanyName.AppName.OrderProcessEngine;
using CompanyName.AppName.OrderProcessEngine.Product;
using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Rules;
using CompanyName.AppName.OrderProcessEngine.Actions;

namespace CompanyName.AppName.OrderProcessEngine.Tests
{
    [TestFixture]
    public class OrderTest
    {
        IProduct product;

        [Test]
        public void TestPhysicalProductOrder()
        {
            product = new Physical();
            var expected = new Dictionary<ActionID, bool>
            {
                { ActionID.GenerateCommissionPay, true },
                { ActionID.GeneratePackingSlip, true }
               
            };

            var order = new Order(product);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(order);
            Assert.AreEqual(expected, order.OrderAction);

        }

        [Test]
        public void TestBookOrder()
        {
            product = new Book();
            var expected = new Dictionary<ActionID, bool>
            {
                { ActionID.DuplicatePackingSlip, true },
                { ActionID.GeneratePackingSlip, true },
                { ActionID.GenerateCommissionPay, true }
            };

            var order = new Order(product);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(order);
            Assert.AreEqual(expected, order.OrderAction);

        }

        [Test]
        public void TestNewMembershipOrder()
        {
            product = new Membership(MembershipType.New);
            var expected = new Dictionary<ActionID, bool>
            {
                { ActionID.ActivateMembership, true },
                { ActionID.Email, true }
            };

            var order = new Order(product);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(order);
            Assert.AreEqual(expected, order.OrderAction);

        }

        [Test]
        public void TestUpgradeMembershipOrder()
        {
            product = new Membership(MembershipType.Upgrade);
            var expected = new Dictionary<ActionID, bool>
            {
                { ActionID.UpgradeMembership, true },
                { ActionID.Email, true }
            };

            var order = new Order(product);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(order);
            Assert.AreEqual(expected, order.OrderAction);

        }

        [Test]
        public void TestVideoOrder()
        {
            product = new Video();
            var expected = new Dictionary<ActionID, bool>
            {
                { ActionID.AddFreeVideo, true }

            };

            var order = new Order(product);
            var ruleEngine = new OrderRuleEngine();
            ruleEngine.Execute(order);
            Assert.AreEqual(expected, order.OrderAction);

        }
    }
}
