using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cqrsMediatR.Commands;
using cqrsMediatR.Models;
using cqrsMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cqrsMediatR.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ISender _sender;

        public ProductController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProduct()
        {
            var products = await _sender.Send(new GetAllProductsQuery());

            return Ok(products);
        }


        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
            await _sender.Send(new AddProductCommand(product));
            return Ok();
        }

        [Route("getById/{id}")]
        [HttpGet]
        public async Task<ActionResult> GetProductById(int id)
        {
            var p = await _sender.Send(new GetProductById(id));
            return Ok(p);
        }
    }
}

