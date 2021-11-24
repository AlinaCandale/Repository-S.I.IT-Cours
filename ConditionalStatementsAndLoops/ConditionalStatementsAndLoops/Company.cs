using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class Company
    {
        string companyName;
        string companyAdress;
        string companyPhone;
        string companyFax;
        string companyWebSite;
        public Manager manager = new Manager();

        public string CompanyName 
        {
            get => companyName; 
            set => companyName = value; 
        }
        public string CompanyAdress
        {
            get { return companyAdress; }
            set { companyAdress = value; }
        }
        public string CompanyPhone
        {
            get { return companyPhone; }
            set { companyPhone = value; }
        }
        public string CompanyFax
        {
            get { return companyFax; }
            set { companyFax = value; }
        }
        public string CompanyWebSite
        {
            get { return companyWebSite; }
            set { companyWebSite = value; }
        }

        public Company(string companyName, string companyAdress, string companyPhone, string companyFax, string companyWebSite, string manager, Manager pmanager)
        {
            CompanyName = companyName;
            CompanyAdress = companyAdress;
            CompanyPhone = companyPhone;
            CompanyFax = companyFax;
            CompanyWebSite = companyWebSite;
            this.manager = pmanager;
        }

        public Company()
        {
        }

    }
}
//has name, address, phone number, fax number, web site and manager