using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttandanceSystem
{
    class Student
    {
         public String FirstName, LastName, MiddleName, Id;

        public Student(String id, String firstname, String lastname, String middlename)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
            this.Id = id;
        }
        public String toString()
        {
            return
                  "]  \n\tId           =\t'" + Id + '\'' +
                    " \n\tFirstName    =\t'" + FirstName + '\'' +
                    " \n\tLastName     =\t'" + LastName + '\'' +
                    " \n\tMiddleName   =\t'" + MiddleName + '\'' +
                    ']';
        }
        public Student(String id, String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

    }
}   
