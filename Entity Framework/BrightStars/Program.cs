
using BrightStars;
using BrightStars.Models;
using System.Transactions;

ApplicationDbContext context = new ApplicationDbContext();
Department department;
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

//for (; ; )
//{
//    department = new Department();
//    Console.Write("Enter Department Name :");
//    department.Name = Console.ReadLine();
//    // Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

//    Console.Write("Enter description :");
//    department.Description = Console.ReadLine();
//    // Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

//    context.departments.Add(department);
//    context.SaveChanges();
//}
//List<Department> allDepartments = context.departments.ToList();
//foreach( var dept in allDepartments )
//{
//    Console.WriteLine(dept.ToString());
//}
//// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
//int firstNo = 175000;
//Console.WriteLine(firstNo.ToString());

// LINQ 
bool DoesContainDev(Department dept)
{
    return dept.Description.Contains("Dev");
}
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
//(Department dept) { return dept.Description.Contains("Dev"); }
//List<Department> devDepartments = context.departments.Where(dept=>dept.Description.Contains("Dev")).ToList();

//Console.WriteLine("Dev Departments : ");
//foreach (var dept in devDepartments)
//{
//    Console.WriteLine(dept.ToString());
//}
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

//Department deptId5 = context.departments.First(dept => dept.Id == 5);
//Console.WriteLine("\n" + nameof(deptId5) + ":");
//Console.WriteLine(deptId5.ToString());

//Department deptId27 = context.departments.FirstOrDefault(dept => dept.Id == 27);
//// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

Department firstDevDept = context.departments.FirstOrDefault(dept => dept.Description.Contains("Dev"));
Console.WriteLine("\n"+nameof(firstDevDept)+" : " +firstDevDept.ToString());
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

//Department lastDevDept = context.departments.LastOrDefault(dept => dept.Description.Contains("Dev"));
//Console.WriteLine("\n"+nameof(lastDevDept)+" : " +lastDevDept.ToString());
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

Department singleId3Dept = context.departments.SingleOrDefault(dept=>dept.Id==3);
Console.WriteLine("\n" + nameof(singleId3Dept) + " : " + singleId3Dept.ToString());

//Department singleDevDept = context.departments.SingleOrDefault(dept => dept.Description.Contains("Dev"));
//Console.WriteLine("\n" + nameof(singleDevDept)+" : "+singleDevDept.ToString());

//List<Department> devDepartments = context.departments.OrderBy(dept => dept.Name).ToList();
//// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
//Console.WriteLine("All Departments Ordered By Name : ");
//foreach (var dept in devDepartments)
//{
//    Console.WriteLine(dept.ToString());
//}
//// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
//List<Department> alldevDepartments = context.departments.OrderByDescending(dept => dept.Name).ToList();

//Console.WriteLine("All Departments Ordered By Descending Name : ");
//foreach (var dept in devDepartments)
//{
//    Console.WriteLine(dept.ToString());
//}
//// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
//Department lastDevDept = context.departments.OrderBy(dept=>dept.Name).Last(dept => dept.Name.Contains("Dev"));
//Console.WriteLine("\n" + nameof(lastDevDept) + " : " + lastDevDept.ToString());

//Department lastOrDefualtDevDept = context.departments.OrderBy(dept => dept.Name).LastOrDefault(dept => dept.Name.Contains("Dev"));
//Console.WriteLine("\n"+nameof(lastOrDefualtDevDept)+" : " +lastOrDefualtDevDept.ToString());
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

Department mobDevDept = context.departments.FirstOrDefault(dept => dept.Id == 2);
mobDevDept.Name = "MD";
mobDevDept.Description = "Mobile Development Dept.";
context.departments.Update(mobDevDept);
context.SaveChanges();
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

Console.WriteLine("Department Updated Successfully");
// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4

Department deptId4 = context.departments.FirstOrDefault(dept=>dept.Id == 4);
context.departments.Remove(deptId4);
context.SaveChanges();

// Asmaa El Sayed Mohamed Ahmed  *  Fayoum University  *  CS and AI  *  CS  *  Level 4
Console.WriteLine("Department Deleted Successfully");
