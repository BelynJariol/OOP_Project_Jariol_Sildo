using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttandanceSystem
{
    class StudentClass
    {

        private String FirstName, LastName, MiddleName, Id;

        public StudentClass (string FirstName, string MiddleName, string LastName, string Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Id = Id;
           

        }
        public void SetFirstName(string firstname)
        {
         this.FirstName = firstname;    
        }
         public void SetLastName(string lastname)
        {
         this.LastName = lastname;    
        }
         public void SetMiddleName(string middlename)
         {
             this.MiddleName = middlename;
         }
         public void SetId(string id)
         {
             this.Id = id;
         }


        public String GetFirstName()
        {
            return this.FirstName;
        }
         public String GetLastName()
        {
            return this.LastName;
        }
         public String GetMiddleName()
         {
             return this.MiddleName;
         }
        public String GetId()
        {
            return this.Id;
        }



    }
}
