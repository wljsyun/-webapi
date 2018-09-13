using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private object list;

        public object ResultToJson { get; private set; }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return "取到了参数："+ name;
        }

        // POST api/values
        [HttpPost]
       public object SaveData(dynamic obj)
        {
            var strName = Convert.ToString(obj.NAME);
            //var oCharging = Newtonsoft.Json.JsonConvert.DeserializeObject<TbCharging>(Convert.ToString(obj.Charging));
            return strName;
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class TbCharging
        {
            internal string Id;
            internal object Name;
        }
    }

}
