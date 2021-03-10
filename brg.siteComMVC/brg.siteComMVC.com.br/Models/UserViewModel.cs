using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brg.siteComMVC.com.br.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public double Salary { get; set; }
        public string CPF { get; set; }

        public UserViewModel(Guid id, string firstName, string lastName, string email, string phone, string address,string country, double salary, string cPF)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            country = country;
            Salary = salary;
            CPF = cPF;
        }
    }
}
