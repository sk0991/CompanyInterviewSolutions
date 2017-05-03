using System;
using Railways.DataContracts;
using Railways.Entities;

namespace Railways
{
    public class TrainSearchManager : ITrainSearchManager
    {
        private ILocationResolver locationResolver = InstanceManager.GetInstance<ILocationResolver>();
        public TrainSearchManager()
        {

        }

        public TrainSearchRS GetTrains(TrainSearchRQ trainSearchRS)
        {
            throw new NotImplementedException();
        }
    }
}
