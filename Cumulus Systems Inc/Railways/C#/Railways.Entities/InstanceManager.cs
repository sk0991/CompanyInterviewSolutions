using System;
using StructureMap;

namespace Railways.Entities
{
    public static class InstanceManager
    {
        private static IContainer _container;

        static InstanceManager()
        {
            _container = new Container(x =>
                            {
                                x.For<ITrainSearchManager>().Use<TrainSearchManager>().Singleton();
                            }
                        );
        }

        public static T GetInstance<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
