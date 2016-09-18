using Railways.DataContracts;

namespace Railways
{
    public class TrainSearchService : ITrainSearchService
    {
        public TrainSearchRS GetData(TrainSearchRQ trainSearchRq)
        {
            bool result = trainSearchRq != null && trainSearchRq.Validate();

            if (!result)
                return null;
        }
    }
}
