using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NLogApplication.Controllers
{
    public class ValuesController : ApiController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        // GET api/values
        public IEnumerable<string> Get()
        {
           
            try
            {

                logger.Info("Enter to the method Get values" + Environment.NewLine + DateTime.Now);

                int a = 10, b = 0, c;

                c = a / b;
               
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
           
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
