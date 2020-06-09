using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicalInterpreter
{
    [TestClass]
    public class TestForLogicalExpressions
    {
        [TestMethod]
        public void TestMethod1()
        {
            Context context = new Context("0 && 0 || !0 ^ 0"); // 1

            List<Expression> tree = new List<Expression>();
            tree.Add(new NotExpression());
            tree.Add(new AndExpression());
            tree.Add(new XorExpression());
            tree.Add(new OrExpression());
            tree.Add(new ConvertExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.AreEqual(context.Output, true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Context context = new Context("0 && 0 || !1 ^ 0"); // 0

            List<Expression> tree = new List<Expression>();
            tree.Add(new NotExpression());
            tree.Add(new AndExpression());
            tree.Add(new XorExpression());
            tree.Add(new OrExpression());
            tree.Add(new ConvertExpression());

            
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.AreEqual(context.Output, false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Context context = new Context("1 && 1 || !1 ^ 1"); // 1

            List<Expression> tree = new List<Expression>();
            tree.Add(new NotExpression());
            tree.Add(new AndExpression());
            tree.Add(new XorExpression());
            tree.Add(new OrExpression());
            tree.Add(new ConvertExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.AreEqual(context.Output, true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Context context = new Context("1 && 1 || !0 ^ 1"); // 1

            List<Expression> tree = new List<Expression>();
            tree.Add(new NotExpression());
            tree.Add(new AndExpression());
            tree.Add(new XorExpression());
            tree.Add(new OrExpression());
            tree.Add(new ConvertExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.AreEqual(context.Output, true);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Context context = new Context("!1 ^ 1 ^ 1 ^ 1 ^ 1"); // 0
            List<Expression> tree = new List<Expression>();
            tree.Add(new NotExpression());
            tree.Add(new AndExpression());
            tree.Add(new XorExpression());
            tree.Add(new OrExpression());
            tree.Add(new ConvertExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Assert.AreEqual(context.Output, false);
        }
    }
}
