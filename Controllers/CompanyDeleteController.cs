
using Microsoft.AspNetCore.Mvc;
using SolidTest.Services;

namespace SolidTest.Controllers
{
    public class CompanyDeleteController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyDeleteController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

         [HttpDelete("{id}")]
        [Route("api/company/{id}")]

        public IActionResult Delete(int id){
            _companyRepository.Delete(id);
            return Ok();
        }
        
    }
}