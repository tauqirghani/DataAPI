using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI.Controllers
{
    [Route("data/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class FilesController : ControllerBase
    {

        [HttpGet("{fileid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<File> GetByfileId(int fileid)
        {
            var file = new File
            {
                fileId = fileid,
                name = $"File {fileid}",
                fileNumber = "{fileid}-{fileid}}",
                status = "Open",
                totalSalesPrice = 200000.0,
                openDate = DateTime.Now,
                closeDate = DateTime.Now + new TimeSpan (2,30,0),
                transactionType = "Sale w/Mortgage"
            };
            return (file);
        }
    }
}