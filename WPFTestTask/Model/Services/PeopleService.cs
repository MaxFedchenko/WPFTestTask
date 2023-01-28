using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPFTestTask.Model;

namespace WPFTestTask.Model.Services
{
    class PeopleService : IPeopleService
    {
        public ObservableCollection<Person> GetPeople() 
        {
            return new ObservableCollection<Person>
            {
                new Person { FirstName="Name1", LastName = "LastName1", Address="Address1", Country="Country1", PhoneNumber="+111 11 111 1111", Age = 31 },
                new Person { FirstName="Name2", LastName = "LastName2", Address="Address2", Country="Country2", PhoneNumber="+222 22 222 2222", Age = 32 },
                new Person { FirstName="Name3", LastName = "LastName3", Address="Address3", Country="Country3", PhoneNumber="+333 33 333 3331", Age = 33 },
                new Person { FirstName="Name4", LastName = "LastName4", Address="Address4", Country="Country4", PhoneNumber="+444 44 444 4444", Age = 34 },
                new Person { FirstName="Name5", LastName = "LastName5", Address="Address5", Country="Country5", PhoneNumber="+555 55 555 5555", Age = 35 },
                new Person { FirstName="Name6", LastName = "LastName6", Address="Address6", Country="Country6", PhoneNumber="+666 66 666 6666", Age = 36 },
                new Person { FirstName="Name7", LastName = "LastName7", Address="Address7", Country="Country7", PhoneNumber="+777 77 777 7777", Age = 37 },
                new Person { FirstName="Name8", LastName = "LastName8", Address="Address8", Country="Country8", PhoneNumber="+888 88 888 8888", Age = 38 },
                new Person { FirstName="Name9", LastName = "LastName9", Address="Address9", Country="Country9", PhoneNumber="+999 99 999 9999", Age = 39 },
                new Person { FirstName="Name10",LastName = "LastName10", Address="Address10", Country="Country10", PhoneNumber="+000 00 000 0000", Age = 40 }
            };
        }
    }
}
