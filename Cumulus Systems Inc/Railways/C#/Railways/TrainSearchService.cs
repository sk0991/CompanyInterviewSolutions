using Railways.DataContracts;
using Railways.Entities;

namespace Railways
{
    public class TrainSearchService : ITrainSearchService
    {
        private ITrainSearchManager _serviceManager;

        public TrainSearchService()
        {
            _serviceManager = InstanceManager.GetInstance<ITrainSearchManager>();
        }

        public TrainSearchRS GetTrains(TrainSearchRQ trainSearchRq)
        {
            bool result = trainSearchRq != null && trainSearchRq.Validate();

            if (!result)
                return null;

            return _serviceManager.GetTrains(trainSearchRq);
        }
    }
}