using hsdc.dpt.Control.DTO.Creational.Builder;
using hsdc.dpt.Control.DTO.Creational.Builder.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class EOfficeDirector<T>
    {
        public T Construct(OfficeFormBuilder<T> builder)
        {
            builder.BuildMaster();
            builder.BuildDetails();
            return builder.GetResult();
        }
    }

    public class LeaveBuilder : OfficeFormBuilder<Leave>
    {
        private Leave dto = null;
        public void BuildMaster()
        {
            dto = new Leave();
        }

        public void BuildDetails()
        {
		  dto.LineItems = new List<LeaveDetail>();
        }

        public Leave GetResult()
        {
            return dto;
        }
    }

    public class ApplyExpenseBuilder : OfficeFormBuilder<ApplyExpense>
    {
        private ApplyExpense dto;
        public void BuildMaster()
        {
            dto = new ApplyExpense();
        }

        public void BuildDetails()
        {
            dto.LineItems = new List<ApplyExpenseDetail>();
        }

        public ApplyExpense GetResult()
        {
            return dto;
        }
    }

	// Request
	 public class RequestBuilder : OfficeFormBuilder<Request>
    {
        private Request dto = null;
        public void BuildMaster()
        {
            dto = new Request();
        }

        public void BuildDetails()
        {
		  dto.LineItems = new List<RequestDetail>();
        }

        public Request GetResult()
        {
            return dto;
        }
    }

}
