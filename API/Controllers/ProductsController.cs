using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using API.DTO;
using AutoMapper;
using API.Helpers;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepo<Product> _repo;
        private readonly IMapper _mapper;

        public ProductsController(IGenericRepo<Product> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProductList<ProductDTO>>> GetProducts()
        {
            var products = await _repo.ListAllAsync();

            var data = _mapper
                .Map<IReadOnlyList<Product>, IReadOnlyList<ProductDTO>>(products);
            
            return Ok(new ProductList<ProductDTO>(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var product = await _repo.GetByIdAsync(id);

            return _mapper.Map<ProductDTO>(product);
        }
    }
}
