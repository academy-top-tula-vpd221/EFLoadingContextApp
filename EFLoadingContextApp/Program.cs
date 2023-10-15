using EFEntityRelationsApp;
using EFModrelCreateApp;
using Microsoft.EntityFrameworkCore;


// EXPLICIT LOADING

//using(ApplicationContext context = new ApplicationContext())
//{
//    Country? country = context.Countries.FirstOrDefault(c => c.Title == "Russia");
//    Company? company = context.Companies.FirstOrDefault();

//    if(company is not null)
//    {
//        context.Employees
//               .Where(e => e.CompanyId == company.Id)
//               .Load();

//        Console.WriteLine($"Company: {company.Title}");
//        foreach(var employee in context.Employees.Local)
//            Console.WriteLine($"\t{employee.Name}");


//        //context.Entry(company)
//        //       .Collection(c => c.Employees)
//        //       .Load();

//        //var employees = company.Employees;




//        //foreach(var cnt in context.Countries)
//        //{
//        //    Console.WriteLine($"Country: {cnt.Title}");
//        //}

//        //foreach (var c in context.Cities)
//        //{
//        //    Console.WriteLine($"Country: {c.Title}");
//        //}

//        //foreach (var p in context.Positions)
//        //{
//        //    Console.WriteLine($"Country: {p.Title}");
//        //}
//    }

//    //Company? company2 = context.Companies.FirstOrDefault(c => c.Id == 2);

//    //context.Employees
//    //       .Where(e => e.CompanyId == company2.Id)
//    //       .Load();
//    //Console.WriteLine($"Company: {company2.Title}");
//    //foreach (var employee in company2.Employees)
//    //    Console.WriteLine($"\t{employee.Name}");
//}



// LAZY LOADING
using (ApplicationContext context = new ApplicationContext())
{
    var employees = context.Employees.ToList();

    foreach (var e in employees)
    {
        Console.WriteLine($"Name: {e.Name}, Age: {e.Age}");
        Console.WriteLine($"Position: {e?.Position?.Title}");
        Console.WriteLine($"Company: {e?.Company?.Title}, Country: {e?.Company?.Country?.Title}, City: {e?.Company?.Country?.Capital?.Title}");
    }
}