using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_and_SET_data_accessors
{
    class User
    {
        private string name = "Shinchan and Doctor";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "Shinchan" || value == "Doctor")
                {
                    name = value;
                }
            }
        }
    }
    class read_only_property_get_accessor
    {
        private string name;
        private String standard;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Standard
        {
            get
            {
                return standard;
            }
        }
        public read_only_property_get_accessor(string a , string b)
        {
            name = a;
            standard = b;
        }
    }

    class WriteOnlyPropertySetAccessor
    {
        private string name;
        private string standard;

        public string Name
        {
            set
            {
                name = value;
            }
        }
        public string Standard
        {
            set
            {
                standard = value;
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine(name);
            Console.WriteLine(standard);
        }
    }

    class AutoImplementedAccessors
    {
        private string location;
        public string Location
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Pyari Doctor";
            Console.WriteLine(u.Name);

            // Read only Property :- get accessor
            read_only_property_get_accessor read = new read_only_property_get_accessor("Shinchan","XII");
            Console.WriteLine(read.Name);
            Console.WriteLine(read.Standard);

            // Write only Property :- set accessor
            WriteOnlyPropertySetAccessor write = new WriteOnlyPropertySetAccessor();
            write.Name = "Doctor";
            write.Standard = "XII";
            write.DisplayDetails();

            // Auto Implemented accessors
            AutoImplementedAccessors auto = new AutoImplementedAccessors();
            auto.Location = "UP";
            Console.WriteLine(auto.Location);

            Console.ReadLine();
        }
    }
}
