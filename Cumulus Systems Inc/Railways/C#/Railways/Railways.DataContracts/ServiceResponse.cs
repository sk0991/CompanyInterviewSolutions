using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class ServiceResponse
    {
        [DataMember]
        public ServiceStatus ServiceStatus { get; set; }
    }

    [DataContract]
    public class ServiceStatus
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public Status Status { get; set; }
    }

    [DataContract]
    public enum Status
    {
        Success = 0,
        Warning = 1,
        Failure = 2
    }
}
