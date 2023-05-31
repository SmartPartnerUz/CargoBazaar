// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// --------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace CargoBazaar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]

        public string Get() => "CargoBazar is running...";
    }
}
