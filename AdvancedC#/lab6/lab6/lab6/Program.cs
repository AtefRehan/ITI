using Microsoft.VisualBasic;

namespace lab6;

class Program
{
    static void Main(string[] args)
    {

        List<String> L1 = new List<string>();
        L1.Add("ahmed");
        L1.Add("Ali");
        L1.Add("Atef");
        L1.Add("menna");
        L1.Add("sara");
        
        HashSet<Person> persons= new HashSet<Person>();
        persons.Add(new Person(1, "Atef", 26));
        persons.Add(new Person(3, "Ahmed", 30));
        persons.Add(new Person(3, "sara", 22));
        
        

        foreach (var item in persons)
        {
            Console.WriteLine(item);
            
        }


        var newlist =L1.FindAll(S => S.Length > 3 && S.Length < 10);
        var newlist2 =L1.FindAll(S => S.StartsWith('s'));




        



        foreach (var item in newlist2)
        {
            Console.WriteLine(item);
            
        }
        
        //Predicate<string> containsAhPredicate = ContainsAh;

        var filteredList = L1.FindAll(ContainsAh);
        
        foreach (var item in filteredList)
        {
            Console.WriteLine(item);
        }
    }

    static bool ContainsAh(string s)
    {
        return s.Contains("ah");
    }


    
    
  
}

        


    