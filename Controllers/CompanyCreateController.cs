
using Microsoft.AspNetCore.Mvc;
using SolidTest.Services;
using SolidTest.Models;

namespace SolidTest.Controllers;

public class CompanyCreateController : Controller
{
    private readonly ICompanyRepository _companyRepository;
    public CompanyCreateController(ICompanyRepository companyRepository){
        _companyRepository = companyRepository;
    }
    [HttpPost]
    [Route("api/company")]
    public IActionResult Create([FromBody] Company company){
        _companyRepository.Add(company);
        return Ok();
        
    }
}
