﻿using Microsoft.AspNetCore.Mvc;
using SGA.Application.Domain.Queries;
using SGA.Application.UI.Models;
using System.Linq;

namespace SGA.UI.Site.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IPetQuery _petQuery;

        public HomeController(IPetQuery petQuery)
        {
            _petQuery = petQuery;
        }

        public IActionResult Index()
        {
            return SafeResult(() => View(_petQuery.GetPetsNotAdopted().Select(x => (PetViewModel)x)), () => RedirectToAction(nameof(Index)));
        }
    }
}