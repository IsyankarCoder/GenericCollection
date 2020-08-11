using System;
using System.Collections.Generic;
using GenericCollectionList;
using GlobalCollection;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bebişimm!");

            GenericCollection<Employee> gc =new GenericCollection<Employee>();
            for(int i = 0;i<=1000;i++){
                Employee emp =new Employee();
                emp.Id=i;
                emp.Name=i.ToString()+" -Employee";
                emp.Salary= new Random().Next();
                gc.Add(emp);
            }
            //// Doldurdk listeyi ,şimdi filtreleyek kafamıza göre
            
            //Extension yazabiluduk , 998 den sonra ki 999 ve 1000 inci çalışanları listeleycez.
            IEnumerable<Employee> emplist = gc.FilterList(gc,((x,index)=>{return x.Id>int.Parse(index);}),"990");
            foreach(Employee e in emplist){
                Console.WriteLine(e.Name + Environment.NewLine);
            }
 
            Console.ReadLine();




        }
    }
}
