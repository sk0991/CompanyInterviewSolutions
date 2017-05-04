using System;
using Railways.DataContracts;
using Railways.Entities;

namespace Railways
{
    public class TrainSearchManager : ITrainSearchManager
    {
        private ILocationResolver _locationResolver;

        public TrainSearchManager(ILocationResolver locationResolver)
        {
            this._locationResolver = locationResolver;
        }

        public TrainSearchRS GetTrains(TrainSearchRQ trainSearchRS)
        {


            throw new NotImplementedException();
        }
    }
}
