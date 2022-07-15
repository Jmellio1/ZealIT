// See https://aka.ms/new-console-template for more information
/*
 
 
Warning this is a recreation of what I think the test was asking me. Might not be completely right.
But I'm testing for an error that happens when ABC gets entered in that order via time stamp
NOTE I’m using .NET 6.0
Let me know if you have any questions 

 
 */
using System.Collections.Generic;

public class employee
{


    /*
     
     
     
     Note I don’t remember the properties for the test fully but I do know it had a 
    name the grade that cause the issue and a time stamp.
     
     */




    public string emp { get; set; }
    public char feild { get; set; }
    public DateTime timeStamp { get; set; }
}
public class Checking
{
    public static List<employee>? ErrorEmp(List<employee> employeesList)
    {
        List<employee> sortedList = employeesList.OrderBy(x => x.emp).ThenBy(x => x.timeStamp).ThenBy(x => x.feild).ToList();
        List<employee> returnList=new List<employee>();
        // sortedList.ForEach(x => Console.WriteLine(x.emp + " "+x.feild +" "+ x.timeStamp));
        for (int i = 1; i < sortedList.Count; i++)
        {
            if (sortedList[i - 1].feild == 'A' && sortedList[i-1].emp.CompareTo(sortedList[i].emp)>=0 && sortedList[i].feild == 'B')
            {
                try {
                    if (sortedList[i+1].feild == 'C' && sortedList[i + 1].emp.CompareTo(sortedList[i].emp) >= 0)
                    {
                        returnList.Add(sortedList[i-1]);
                        returnList.Add(sortedList[i]);
                        returnList.Add(sortedList[i+1]);
                    }
                }
                catch { }
            }
           /* if (sortedList[i-1].emp.CompareTo(sortedList[i].emp) >= 0)
            {
                Console.WriteLine(sortedList[i].emp);
            }*/
        }
        return returnList;
    }
}
public class addingPeople{
    /*
     
     
Note I don’t remember the sample data so I remade it 
     
     
     */




    public static List<employee> addPeople()
    {
        List<employee> employees = new List<employee>
    {
        new employee {emp= "Mark",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:00 AM") },
   new employee {emp= "Josh",feild='C', timeStamp= DateTime.Parse("	07/15/2022 1:10 AM") },
        new employee {emp= "Mark",feild='C', timeStamp= DateTime.Parse("	07/15/2022 1:10 AM") },
        new employee {emp= "JIM",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:05 AM") },
        new employee {emp= "JIM",feild='B', timeStamp= DateTime.Parse("	07/15/2022 1:00 AM") },
        new employee {emp= "JIM",feild='C', timeStamp= DateTime.Parse("	07/15/2022 1:10 AM") },
         new employee {emp= "ASH",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:00 AM") },
        new employee {emp= "ASH",feild='B', timeStamp= DateTime.Parse("	07/15/2022 1:05 AM") },
      
        new employee {emp= "ASH",feild='D', timeStamp= DateTime.Parse("	07/15/2022 1:09 AM") },
        new employee {emp= "ASH",feild='C', timeStamp= DateTime.Parse("	07/15/2022 1:10 AM") },
             new employee {emp= "Mark",feild='B', timeStamp= DateTime.Parse("	07/15/2022 1:05 AM") },
        new employee {emp= "JO",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:07 AM") },
        new employee {emp= "KIM",feild='B', timeStamp= DateTime.Parse("	07/15/2022 1:01 AM") },
        new employee {emp= "Josh",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:00 AM") },
        new employee {emp= "Josh",feild='B', timeStamp= DateTime.Parse("	07/15/2022 1:05 AM") },
        
         new employee {emp= "Josh",feild='A', timeStamp= DateTime.Parse("	07/15/2022 1:02 AM") },
           new employee {emp= "ASH",feild='C', timeStamp= DateTime.Parse("	07/15/2022 1:10 AM") },
    };
        return employees;
    }
   

    
}

public class solution
{
  public static void Main(string[] args)
    {
        // Not sure what the main method was doing in the test
        List<employee> employees = addingPeople.addPeople();
       List<employee> done= Checking.ErrorEmp(employees);
        Console.WriteLine(done);
    }
}