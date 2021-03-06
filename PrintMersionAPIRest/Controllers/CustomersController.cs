﻿using Microsoft.AspNetCore.Mvc;
using PrintMersion.Core.Entities;
using PrintMersion.Core.Interfaces;

namespace PrintMersion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : GenericController<Customer>
    {
        public CustomersController(IRepository<Customer> repository, IService<Customer> service) : base(repository, service)
        {

        }
    }
}