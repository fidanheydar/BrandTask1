using BrandTask1.DAL;
using BrandTask1.Models;


foreach (var item in GetAllBrands())
{
    Console.WriteLine(item);
}

void AddBrand()
{
   AppDbContext dbcontext = new AppDbContext();
    var newBrand = new Brand
    {
        Name = "Bmw"
    };
    dbcontext.Brands.Add(newBrand);
    dbcontext.SaveChanges();
}

List<Brand> GetAllBrands()
{
    AppDbContext dbcontext = new AppDbContext();
    return dbcontext.Brands.ToList();
}

void UpdateBrandName()
{
    AppDbContext dbcontext = new AppDbContext();
    var brand = dbcontext.Brands.First();
    brand.Name = "Porsche";
    dbcontext.SaveChanges();
}

void DeleteBrand()
{
    AppDbContext dbcontext = new AppDbContext();
    var brand = dbcontext.Brands.First();
    dbcontext.Brands.Remove(brand);
    dbcontext.SaveChanges();
}