using Calculator.DemoOne;
using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace Calculator.DemoTwo
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            //todo:
            Console.WriteLine(string.Format("{0} 开始。", context.Bundle.SymbolicName));
            context.AddService<ICalculate>(new Calculator.DemoTwo.Impl.Calculator());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
            Console.WriteLine(string.Format("{0} 停止。", context.Bundle.SymbolicName));
        }
    }
}
