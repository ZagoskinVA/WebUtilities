using Microsoft.AspNetCore.Mvc;

namespace WebUtilities.Services;

public static class JsonService
{
    public static JsonResult GetOkJson(object data)
    {
        return new JsonResult(new {isError = false, data, errorMessages = new List<string>()});
    }

    public static JsonResult GetErrorJson(object data, IEnumerable<string> errorMessages)
    {
        return new JsonResult(new {isError = true, data, errorMessages});
    }
}