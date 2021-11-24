using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class Manager
    {
        string managerName;
        string managerSurName;
        string managerPhone;

        public string ManagerName 
        { 
            get => managerName;
            set => managerName = value;
        }
        public string ManagerSurName
        {
            get => managerSurName;
            set => managerSurName = value;
        }
        public string ManagerPhone
        {
            get => managerPhone;
            set => managerPhone = value;
        }

        public Manager()
        {
            ManagerName = "none";
            ManagerPhone = "none";
            ManagerSurName = "none";
        }
        public Manager(string managerName, string managerSurName, string managerPhone)
        {
            ManagerName = managerName;
            ManagerPhone = managerPhone;
            ManagerSurName = managerSurName;
        }
    }
}
