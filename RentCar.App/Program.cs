using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.App
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Bootstrap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<Layout>());
        }

        private static void Bootstrap()
        {
            container = new Container(c => {
                //c.AddRegistry<RentCarRegistry>();
                c.ForConcreteType<Layout>();
            });
        }
    }
}
