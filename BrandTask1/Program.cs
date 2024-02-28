using BrandTask1.DAL;
using BrandTask1.Models;

string opt;
do
{
    Console.WriteLine(" ***Menu*** ");
    Console.WriteLine("1.Create brand");
    Console.WriteLine("2.Get brand by Id");
    Console.WriteLine("3.Get all brands");
    Console.WriteLine("4.Update brand");
    Console.WriteLine("5.Delete brand");

    opt= Console.ReadLine();
    AppDbContext dbContext = new AppDbContext();
    string brName,brIdStr,prName,prIdStr;
    int brId,prId;
    double price;

    switch (opt)
    {
        case "1":
            do
            {
                Console.WriteLine("Enter the brand name:");
                brName = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(brName));
            var newBrand = new Brand
            {
                Name = brName,
            };
            dbContext.Brands.Add(newBrand);
            dbContext.SaveChanges();
            Console.WriteLine("Brand successfully created");
            break;
            case "2":
            do
            {
                Console.Write("Enter the brand Id ");
                brIdStr = Console.ReadLine();
            } while (!int.TryParse(brIdStr, out brId) || brId < 0);
            var brand = dbContext.Brands.Find(brId);
            if (brand != null) 
                Console.WriteLine(brand);
            else
                Console.WriteLine("Brand not found!");
            break;
            case "3":
            var brands = dbContext.Brands.ToList();
            foreach (var item in brands)
            {
                Console.WriteLine(item);
            }
            break;
            case "4":
            do
            {
                Console.Write("Enter the brand Id ");
                brIdStr = Console.ReadLine();
            } while (!int.TryParse(brIdStr, out brId) || brId < 0);
             brand = dbContext.Brands.Find(brId);
            if (brand != null)
            {
                do
                {
                    Console.Write("Enter the new brand name:");
                    brName = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(brName));
                brand.Name = brName;
                dbContext.SaveChanges();
                Console.WriteLine("Brand succesfully updated");
                break;
            }
            else
                Console.WriteLine("Brand not found!");
            break;
            case "5":
            do
            {
                Console.Write("Enter the brand Id ");
                brIdStr = Console.ReadLine();
            } while (!int.TryParse(brIdStr, out brId) || brId < 0);
            brand = dbContext.Brands.Find(brId);
            if (brand != null)
            {
                dbContext.Brands.Remove(brand);
                dbContext.SaveChanges();
                Console.WriteLine("Brand succesfully deleted");
            }
            else 
                Console.WriteLine("Brand not found!");
            break;

        default:
            break;
    }


} while (true);