using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestInterpreter
    {
        [TestMethod]
        public void TestMethod_Interpreter()
        {
            InterpretContext context = new InterpretContext();
            ArrayList list = new ArrayList();
            
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }
}
