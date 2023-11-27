using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary
    {
        public void newDictionary(){
            //Creating a dictionary
            Dictionary <string, string> Mimi=new Dictionary<string, string>()
            {
                {"Name","Kelvin Ngeiywa"},          //Initializing an array
                {"Email","kellyngeiywa@gmail.com"}
            };

            Mimi.Add("Profession","Software Engineer"); //Adding key/value pairs to dictionary

            // Console.WriteLine($"{Mimi["Name"]}");  //Accessing elements inside a dictionary using key
            // Console.WriteLine($"{Mimi["Email"]}");
            // Console.WriteLine($"{Mimi["Profession"]}");
            Mimi["Email"]="ngeiywakelvin@gmail.com";  //changing an element in a dictionary
            Mimi.Remove("Profession");              //Removing an element from dictionary

            // foreach(KeyValuePair<string, string> item in Mimi ) //Looping through a dictionary
            // {
            //     Console.WriteLine($"{item.Key}: {item.Value}");
                
            // }

            foreach(var key in Mimi.Keys){
                Console.WriteLine($"{key}: {Mimi[key]}");
                
            }

            Console.WriteLine(Mimi.ContainsKey("Email"));
            Console.WriteLine(Mimi.ContainsValue("Kelvin Ngeiywa"));
            
            
            
            
            
        }
    }
}