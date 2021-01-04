using AutoMapper;
using HumanManagement.Models.InputModels;
using HumanManagement.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Controllers
{
    public class CountryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICountryService _countryService;

        public CountryController(IMapper mapper, ICountryService countryService)
        {
            _mapper = mapper;
            _countryService = countryService;
        }

        public IActionResult CountryListing()
        {
            var countries = _countryService.GetAllCountries();
            List<CountryVM> country = _mapper.Map<List<CountrySM>, List<CountryVM>>(countries);
            return View(country);

        }

        public IActionResult CreateCountry()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateCountry(CountryCreateIM newCountry)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var country = _mapper.Map<CountryCreateIM, CountrySM>(newCountry);
            await _countryService.CreateCountryAsync(country);
            return RedirectToAction("CountryListing", "Country");
        }

        public async Task<IActionResult> CountryEdit(Guid id)
        {


            var country = await _countryService.GetCountryByIdAsync(id);
            var countryDetails = _mapper.Map<CountrySM, CountryEditIM>(country);

            return View(countryDetails);
        }

        [HttpPost]
        public async Task<IActionResult> CountryEdit(CountryEditIM countryInputModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var country = _mapper.Map<CountryEditIM, CountrySM>(countryInputModel);
            if (!(await _countryService.UpdateCountryAsync(country)))
            {
                return NotFound();
            }

            return RedirectToAction("CountryListing");
        }


        public async Task<IActionResult> CountryDelete(Guid id)
        {
            if (await _countryService.DeleteCountryAsync(id))
            {
                return RedirectToAction("CountryListing");
            }
            else
            {
                return NotFound();
            }
        }

    }
}
