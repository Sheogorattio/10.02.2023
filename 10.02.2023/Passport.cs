using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportClass
{
    public class Passport
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] >= 48 && value[i] <= 57) throw new Exception("Name input error");
                    name = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }
        }
        private string surname;
        public string Surname
        {
            get 
            {
                return surname;
            } set 
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] >= 48 && value[i] <= 57) throw new Exception("Surname input error");
                    surname = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(2);
                }
            }
        }
        private string patronumic;
        public string Patronumic
        {
            get
            {
                return patronumic;
            }
            set
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] >= 48 && value[i] <= 57) throw new Exception("Patronumic input error");
                    patronumic = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(3);
                }
            }
        }
        private string sex;
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                try
                {
                    if (value != "M" || value != "F") throw new Exception("Sex input error(M/F)");
                    sex = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(4);
                }
            }
        }

        private string nationality;
        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                try
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] >= 48 && value[i] <= 57) throw new Exception("Nationality input error");
                    nationality = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(4);
                }
            }
        }
        public DateTime DateOfBirth 
        {
            get
            {
                return DateOfBirth;
            }
            set
            {
                DateOfBirth = value;
            }
        }
        public DateTime DateOfExpiry
        {
            get
            {
                return DateOfExpiry;
            }
            set
            {
                DateOfExpiry = value;
            }
        }
    }
}
