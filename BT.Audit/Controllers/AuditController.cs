using System.Collections.Generic;
using System.Web.Http;
using BT.Audit.DomainModel;

namespace AuditService.Controllers
{
    public class AuditController : ApiController
    {
		/// <summary>
		/// Search Audits
		/// </summary>
		/// <param name="category"></param>
		/// <returns></returns>
		[HttpGet]
	    public List<Audit> SearchAudits(string category)
	    {
			//TODO: Implement
		    return new List<Audit>(){ new Audit("Test")};
	    }
    }
}
