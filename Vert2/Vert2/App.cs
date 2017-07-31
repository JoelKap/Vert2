using Vert2.Helpers;
using Vert2.Interfaces;
using Vert2.Services;
using Vert2.Model;

namespace Vert2
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}