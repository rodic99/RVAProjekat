using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServiceContracts.PatientServiceContracts
{
    [ServiceContract]
    public interface IRetrievePatients
    {
        [OperationContract]
        List<Patient> RetrievePatients();
    }
}
