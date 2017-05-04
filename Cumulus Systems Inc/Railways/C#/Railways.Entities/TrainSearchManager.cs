using System;
using Railways.DataContracts;
using Railways.Entities;

namespace Railways
{
    public class TrainSearchManager : ITrainSearchManager
    {
        public TrainSearchRS GetTrains(TrainSearchRQ trainSearchRS)
        {
            trainSearchRS.SearchCriteria.Source.Resolve();
            trainSearchRS.SearchCriteria.Destination.Resolve();

            throw new NotImplementedException();
        }
    }
}
