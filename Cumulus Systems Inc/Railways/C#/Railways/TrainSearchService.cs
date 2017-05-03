using Railways.DataContracts;
using Railways.Entities;

namespace Railways
{
    public class TrainSearchService : ITrainSearchService
    {
        private ITrainSearchManager serviceManager = InstanceManager.GetInstance<ITrainSearchManager>();

        public TrainSearchService()
        {

        }

        public TrainSearchRS GetTrains(TrainSearchRQ trainSearchRq)
        {
            bool result = trainSearchRq != null && trainSearchRq.Validate();

            if (!result)
                return null;

            return serviceManager.GetTrains(trainSearchRq);
        }
    }
}
