using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesAssignment2
{
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string BirthPlace { get; set; }
        public uint Age { get { return (uint)(DateTime.Now.Year - DateOfBirth.Year); } }
        public bool IsGraduated { get; set; }

        public Member(string firstName, string lastName, string gender, DateTime dateOfBirth, string phone, string birthPlace, bool isGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            BirthPlace = birthPlace;
            IsGraduated = isGraduated;
        }

        public string Information
        {
            get
            {
                string Graduated = (IsGraduated) ? "Graduated" : "Not Graduated";
                // always add extra line
                return FirstName + "\t" + LastName + "\t" + Gender + "\t" + DateOfBirth + "\t" + Phone + "\t" +
                    BirthPlace + "\t" + Age + "\t" + Graduated;
            }
        }
    }
}
