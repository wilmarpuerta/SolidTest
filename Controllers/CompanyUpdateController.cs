
using Microsoft.AspNetCore.Mvc;
using SolidTest.Services;
using SolidTest.Models;

namespace SolidTest.Controllers
{
    public class CompanyUpdateController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyUpdateController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpPut("{id}")]
        [Route("api/company/{id}/update")]
        public string Update(int id, [FromBody] Company company){
            
            return "Falta Actualizar";
        }
    }
}