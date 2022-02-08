using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionnary
{
    public struct Search
    {
        public void search(){

            List<string> mylist = new List<string>();
            mylist.Add("Hot dog");
            mylist.Add("Merguez");
            // mylist.Add("Your Word");

            string userResponse = Console.ReadLine();
            for (int i = 0; i < mylist.Count; i++)
            {
                string name = mylist[i];
                if (userResponse == name)
                {

                    //Console.WriteLine(name);
                    Console.WriteLine("The Word " + name + " has been exist");
                    return;
                }
                else if (userResponse != name)
                {
                    Console.WriteLine("The Word " + userResponse + " has not been exist, please add this to the list");
                    return;
                }
            }
        }


    }
}
