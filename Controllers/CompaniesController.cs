
using Microsoft.AspNetCore.Mvc;
using SolidTest.Services;
using SolidTest.Models;

namespace SolidTest.Controllers;

public class CompaniesController : Controller
{
    private readonly ICompanyRepository _companyRepository;
    public CompaniesController(ICompanyRepository companyRepository){
        _companyRepository = companyRepository;
    }
    
    [HttpGet]
    [Route("api/company")]
    public IEnumerable<Company> GetUsers(){
        return _companyRepository.GetAll();
    }
    [HttpGet]
    [Route("api/company/{id}")]
    public Company Details(int id){
        return _companyRepository.GetById(id);
    }
}
