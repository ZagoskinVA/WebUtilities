using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUtilities.Services
{
    public static class JsonService
    {
        public static JsonResult GetOkJson(object data)
        {
            return new JsonResult(new { isError = false, data = data, errorMessages = new List<string>() });
        }

        public static JsonResult GetErrorJson(object data, IEnumerable<string> errorMessages)
        {
            return new JsonResult(new { isError = true, data = data, errorMessages = errorMessages });
        }
    }
}
