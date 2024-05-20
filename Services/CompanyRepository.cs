using SolidTest.Data;
using SolidTest.Models;
using SolidTest.Services;

namespace SolidTest.Services;

public class CompanyRepository : ICompanyRepository
{
    private readonly BaseContext _context;

    public CompanyRepository(BaseContext context)
    {
        _context = context;
    }
    public void Add(Company company)
    {
        _context.Companies.Add(company);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var company = _context.Companies.Find(id);
        _context.Companies.Remove(company);
        _context.SaveChanges();
    }

    public IEnumerable<Company> GetAll()
    {
        return _context.Companies.ToList();
    }

    public Company GetById(int id)
    {
        return _context.Companies.Find(id);
    }

    public void Update(int id, Company company)
    {
        var companyUpdate = _context.Companies.Find(id);
        _context.Companies.Update(companyUpdate);
        _context.SaveChanges();
    }
}