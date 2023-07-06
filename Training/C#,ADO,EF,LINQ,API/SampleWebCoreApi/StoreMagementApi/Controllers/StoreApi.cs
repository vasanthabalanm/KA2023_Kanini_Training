using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StoreMagementApi.Models;
using StoreMagementApi.Services.StoreServices;
using System;
using System.Net.NetworkInformation;


namespace StoreMagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreApi : ControllerBase
    {
        private readonly IStoreAdmin _StoreService;
        public StoreApi(IStoreAdmin StoreService)
        {
            _StoreService = StoreService;

        }
        [HttpGet]
        //select
        public async Task<ActionResult<List<StoreManagement>>> GetProductDetails()
        {
            return await _StoreService.GetProductDetails();
        }
        /*[HttpPost]
        public async Task<ActionResult<List<StoreManagement?>>> InsertProductDetails()
        {
            return await _StoreService.InsertProductDetails();
        }*/
    }
}
