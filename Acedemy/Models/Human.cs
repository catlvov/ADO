using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Acedemy.Models
{
    internal class Human
    {
        int id;
        string last_name;
        string first_name;
        string middle_name;
        string birth_date;
        string email;
        string phone;
        Image photo;
        public Human(
            int id, 
            string last_name, string first_name, string middle_name, 
            string birth_date, 
            string email, string phone, 
            Image photo
            )
        {
            this.id = id;
            this.last_name = last_name;
            this.first_name = first_name;
            this.middle_name = middle_name;
            this.birth_date = birth_date;
            this.email = email;
            this.phone = phone;
            this.photo = photo;
        }

        public Human(Human other)
        {
            this.id=other.id;
            this.last_name=other.last_name;
            this.first_name=other.first_name;
            this.middle_name=other.middle_name;
            this.birth_date=other.birth_date;
            this.email=other.email;
            this.phone=other.phone;
            this.photo=other.photo;
            //copy constructor
        }

        public virtual string GetNames()
        {
            return "last_name,first_name,middle_name,birth_date,enail,phone";
        }
        public virtual string GetValues()
        {
            return $"N'{last_name}'N'{first_name}'N'{middle_name}N'{birth_date}'N'{email}'N'{phone}'";
        }

    }
}
