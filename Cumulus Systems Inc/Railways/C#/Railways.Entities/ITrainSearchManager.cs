using Railways.DataContracts;

namespace Railways
{
    public interface ITrainSearchManager
    {
        TrainSearchRS GetTrains(TrainSearchRQ trainSearchRS);
    }
}
