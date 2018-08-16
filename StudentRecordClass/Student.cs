using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordClass
{
    class Student
    {
        private string id;
        private string name;
        private decimal subjectOne;
        private decimal subjectTwo;
        private decimal subjectThree;

        public Student(string ID, string name, decimal scoreOne, decimal scoreTwo, decimal scoreThree)
        {
            Id = id;
            Name = name;
            SubjectOne = scoreOne;
            SubjectTwo = scoreTwo;
            SubjectThree = scoreThree;
        }

        public string Id
        {

            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public decimal SubjectOne
        {
            get
            {
                return subjectOne;
            }
            set
            {
                if(value > 0)
                {
                    subjectOne = value;
                }
            }
        }
        public decimal SubjectTwo
        {
            get
            {
                return subjectTwo;
            }
            set
            {
                if (value > 0)
                {
                    subjectTwo = value;
                }
            }
        }
        public decimal SubjectThree
        {
            get
            {
                return subjectThree;
            }
            set
            {
                if (value > 0)
                {
                    subjectThree = value;
                }
            }
        }

        public decimal GetAggregate()
        {
            return SubjectOne + SubjectTwo + SubjectThree;
        }

        public decimal GetPercentage()
        {
            decimal sum = GetAggregate();

            return sum / 50 * 100;
        }
    }
}
