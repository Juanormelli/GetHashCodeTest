using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;

namespace CourseCount.Entities
{
    class Users
    {
        public int Id { get; set; }
        

        public Users()
        {

        }

        public Users(int id)
        {
            Id = id;
           
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Users))
            {
                return false;
            }
            Users other = obj as Users;
            return Id.Equals(other.Id);
        }
    }
    
}
