using Microsoft.AspNetCore.Mvc;
using System;

namespace TestApiJWT.Controllers
{
    public class ReturnMethods : ControllerBase
    {
        public ActionResult ReturnData(Object data, string message)
        {
            return Ok(new { courses = data, status = true, code = 200, msg = message });
        }
    }
}