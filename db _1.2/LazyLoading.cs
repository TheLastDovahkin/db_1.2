using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace db__1._2
{
    public class LazyLoading
    {
        private readonly AppContext _context;

        public LazyLoading(AppContext context)
        {
            _context = context;
        }

        public async Task LoadThreeTablesAsync()
        {
            var loadThreeTables = await _context.Titles
                .Select(x => new
                {
                    Title = x.NameOfTitle,
                    Employee = x.Employees.Select(v => v.FirstName),
                    Office = x.Employees.Select(c => c.OfficeId)
                })
                .ToListAsync();

            Console.WriteLine("___FirstTask___");
            foreach (var item in loadThreeTables)
            {
                Console.WriteLine($"Title: {item.Title} -Emplloyee: {item.Employee} -Office {item.Office}");
            }
        }

        public async Task DateDiffAsync()
        {
            var diff = await _context.Employees
                .Select(z => new
                {
                    z.FirstName,
                    z.HiredDate,
                    Exp = DateTime.Now.Year - z.HiredDate.Year
                })
                .ToListAsync();
            Console.WriteLine("___Second Task___");
            foreach (var item in diff)
            {
                Console.WriteLine(item);
            }
        }

        public async Task ChangeEntityAsync()
        {
            Console.WriteLine("___Third task___");
            var changeEntity = await _context.Clients.FirstOrDefaultAsync(z => z.ClientId == 11);
            changeEntity.FirstName = "Raven";
            var changeEntity1 = await _context.Clients.FirstOrDefaultAsync(x => x.ClientId == 12);
            changeEntity1.DateOfBirth = DateTime.UtcNow;
           
            _context.SaveChanges();
        }

        public async Task AddEntityAsync()
        {
            Console.WriteLine("___Fourth Task___");
            var addEntityEmployeeProject = await _context.EmployeeProjects.AddAsync(new Entitites.EmployeeProject
            {
              Rate = 1000,
              StartDate = new DateTime(1999, 11, 11),
              ProjectId = 1,
              Employee = new Entitites.Employee
              {
                  FirstName = "Hello",
                  LastName = "There",
                  HiredDate = new DateTime(1999, 11, 10),
                  DateOfBirth = new DateTime(1999, 04, 07),
                  TitleId = 3,
                  OfficeId = 1,
              }
            });


            _context.SaveChanges();
        }

        public async Task DeleteEntityAsync()
        {
            Console.WriteLine("___Fifth Task___");
            var deleteEntity = await _context.Employees.FirstOrDefaultAsync();
            _context.Remove(deleteEntity);

            _context.SaveChanges();
        }

        public async Task GroupRoleEmployeeAsync()
        {
            Console.WriteLine("___Sixth Task___");
            var groupRoleEmployee = await _context.Employees
                .Where(w => !w.Title.NameOfTitle.Contains("A"))
                .GroupBy(z => z.Title.NameOfTitle)
                .Select(s => s.Key)
                .ToListAsync();

            foreach (var item in groupRoleEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
