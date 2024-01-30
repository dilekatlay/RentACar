using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : IBrandDal
{
    private readonly RentACarContext _context;
    public EfBrandDal(RentACarContext context)
    {
        _context = context;
    }

    public Brand Add(Brand entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        _context.Brands.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public Brand Delete(Brand entity, bool isSoftDelete = true)
    {
        entity.DeletedAt = DateTime.UtcNow;
        if (!isSoftDelete)

            _context.Brands.Remove(entity);

        _context.SaveChanges();

        return entity;
    }

    public Brand? Get(Func<Brand, bool> predicate)
    {
        Brand? brand = _context.Brands.FirstOrDefault(predicate);

        return brand;
    }

    public IList<Brand> GetList(Func<Brand, bool>? predicate = null)
    {
        IQueryable<Brand> query = _context.Set<Brand>();
        if (predicate != null)
            query = query.Where(predicate).AsQueryable();
        return query.ToList();
    }

    public Brand Update(Brand entity)
    {
        entity.UpdateAt = DateTime.UtcNow;
        _context.Brands.Update(entity);
        _context.SaveChanges();
        return entity;
    }
}