using System.ServiceModel;
using Railways.DataContracts;

namespace Railways
{
    [ServiceContract]
    public interface ITrainSearchService
    {
        [OperationContract]
        TrainSearchRS GetData(TrainSearchRQ trainSearchRq);
    }
}
