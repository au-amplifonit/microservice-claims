using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fox.Microservices.Claims.Models;
using Fox.Microservices.Claims.Models.Entities;
using Fox.Microservices.Claims.Models.Entities.StoredProcedures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPITools.Models.Configuration;

namespace Fox.Microservices.Claims.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {

        private readonly IOptions<AppSettings> Settings;
        private readonly ClaimsContext DBContext;

        public ClaimsController(IOptions<AppSettings> ASettings, ClaimsContext ADBContext)
        {
            this.Settings = ASettings;
            DBContext = ADBContext;
        }

        [HttpGet("[action]/{id}")]
        public ActionResult<IEnumerable<ClaimInfoListItem>> Customer(string id)
        {
            List<ClaimInfoListItem> Result = new List<ClaimInfoListItem>();
            //IQueryable<p_CL_B_CLAIM_EXT_AUS_GetAll_Result> ClaimList = DBContext.Set<p_CL_B_CLAIM_EXT_AUS_GetAll_Result>().FromSql("EXECUTE [dbo].[p_CL_B_CLAIM_EXT_AUS_GetAll] @COMPANY_CODE = {0}, @DIVISION_CODE = {1}, @CLAIM_ID = NULL, @CUSTOMER_CODE = {2}", Settings.Value.CompanyCode, Settings.Value.DivisionCode, id).Take(Settings.Value.MaxQueryResult);
            IQueryable<p_CL_B_CLAIM_EXT_AUS_GetAll_Result> ClaimList = DBContext.p_CL_B_CLAIM_EXT_AUS_GetAll_Result.FromSql("EXECUTE [dbo].[p_CL_B_CLAIM_EXT_AUS_GetAll] @COMPANY_CODE = {0}, @DIVISION_CODE = {1}, @CLAIM_ID = NULL, @CUSTOMER_CODE = {2}", Settings.Value.CompanyCode, Settings.Value.DivisionCode, id).Take(Settings.Value.MaxQueryResult);

            foreach (p_CL_B_CLAIM_EXT_AUS_GetAll_Result Item in ClaimList)
            {
                ClaimInfoListItem ListItem = Result.FirstOrDefault(E => E.ClaimID == Item.CLAIM_ID);
                if (ListItem == null)
                {
                    ListItem = new ClaimInfoListItem(Item);
                    Result.Add(ListItem);
                }
                ListItem.DeviceList.Add(new ClaimDeviceInfoListItem(Item));
            }
            return Result;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        // GET api/values
        public ActionResult<IEnumerable<ClaimInfoListItem>> Get()
        {
            return null;
        }
        
        /*
        // GET api/values
        //[HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
        */
    }
}
