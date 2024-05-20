using SolidTest.Models;

namespace SolidTest.Services;

public interface ICompanyRepository
{
    IEnumerable<Company> GetAll();
    Company GetById(int id);
    void Add(Company company);
    void Delete(int id);
    void Update(int id, Company company);
}