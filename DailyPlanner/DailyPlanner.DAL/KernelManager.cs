using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL
{
    public sealed class KernelManager
    {
        private static IKernel _kernel;

        public static IKernel Kernel
        {
            get
            {
                return _kernel;
            }
        }

        public static void Initialize()
        {
            if (_kernel == null)
            {
                _kernel = new StandardKernel(new EntityInject());
            }
        }
    }
}
