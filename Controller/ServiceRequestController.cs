using Hostel_Management_System.Model;
using System.Collections.Generic;

namespace Hostel_Management_System.Controller
{
    public class ServiceRequestController
    {
        public List<ServiceRequestModel> GetAllServiceRequests()
        {
            return ServiceRequestModel.GetAllServiceRequests();
        }

        public ServiceRequestModel GetServiceRequestById(int id)
        {
            return ServiceRequestModel.GetServiceRequestById(id);
        }

        public bool AddServiceRequest(ServiceRequestModel request)
        {
            return ServiceRequestModel.AddServiceRequest(request);
        }

        public bool UpdateServiceRequest(ServiceRequestModel request)
        {
            return ServiceRequestModel.UpdateServiceRequest(request);
        }
    }
}