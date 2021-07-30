using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OptimaJet.Workflow;
using OptimaJet.Workflow.Core.Runtime;
using OptimaJet.Workflow.Core.Parser;
using WorkflowRuntime = OptimaJet.Workflow.Core.Runtime.WorkflowRuntime;

namespace Wassel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignerController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult API()
        {
            Stream filestream = null;
            var isPost = Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase);
            if (isPost && Request.Form.Files != null && Request.Form.Files.Count > 0)
                filestream = Request.Form.Files[0].OpenReadStream();

            var pars = new NameValueCollection();
            foreach (var q in Request.Query)
            {
                pars.Add(q.Key, q.Value.First());
            }


            if (isPost)
            {
                var parsKeys = pars.AllKeys;
                //foreach (var key in Request.Form.AllKeys)
                foreach (var key in Request.Form.Keys)
                {
                    if (!parsKeys.Contains(key))
                    {
                        pars.Add(key, Request.Form[key]);
                    }
                }
            }

            var res = getRuntime.DesignerAPI(pars, out bool hasError, filestream, true);

            if (pars["operation"].ToLower() == "downloadscheme" && !hasError)
                return File(Encoding.UTF8.GetBytes(res), "text/xml");
            if (pars["operation"].ToLower() == "downloadschemebpmn" && !hasError)
                return File(Encoding.UTF8.GetBytes(res), "text/xml");

            return Content(res);

        }

        private WorkflowRuntime getRuntime
        {
            get
            {
                //INIT YOUR RUNTIME HERE
                return Wassel.WorkflowInit.Runtime;
            }
        }
    }
}
