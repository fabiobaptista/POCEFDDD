using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Application;

namespace POCEFDDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var serviceApp = new UserServiceApp();

                    //serviceApp.Save(new User("Fabio", "email@fabio.com"));

                    //var guid = Guid.Parse("4ef70a8b-ff05-4524-9386-21687dd39431");
                    //var userOld = context.Users.Single(_ => _.Id == guid);

                    //Console.WriteLine("{0} - {1}", userOld.Name, userOld.Email);
                    //Console.WriteLine("");

                    serviceApp.GetList().ToList().ForEach(x =>
                    {
                        //context.Users.Remove(x);
                        Console.WriteLine(x.Id + " " + x.Name);
                    });

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
