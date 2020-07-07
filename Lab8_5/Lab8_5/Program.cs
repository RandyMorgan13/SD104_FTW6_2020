using System;
using System.Xml.XPath;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5
{

    class Application
    {
        public string FirstName;
        public string LastName;
        public string Birthday;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public string PhoneNumber;
        public string Email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string FirstName, string LastName, string Birthday, string Address, string City, string State, int ZipCode, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            isSubmitted = false;
            isAccepted = false;
        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("You're Application has been submitted.");
        }
        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted");
        }


        class HouseHunter : Application
        {
            public string JobTitle;
            public int AnnualIncome;
            public int BuyHouse;
            public int Bedrooms;
            public int Bathrooms;

            public HouseHunter(string Job, int Income, int House, int Beds, int Bath, string FirstName, string LastName, string Birthday, string Address, string City, string State, int ZipCode, string Phone, string Email)
            : base(FirstName, LastName, Birthday, Address, City, State, ZipCode, Phone, Email)
            {

                this.JobTitle = Job;
                this.AnnualIncome = Income;
                this.BuyHouse = House;
                this.Bedrooms = Beds;
                this.Bathrooms = Bath;
            }
            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've Been Accepted to Dream House Hunters!");


            }
        }

        class ParadiseIsland : Application
        {
            public string Gender;
            public string SignificantOther;
            public int YearsDated;

            public ParadiseIsland(string Gender, string SignificantOther, int Relationship, string FirstName, string LastName, string Birthday, string Address, string City, string State, int ZipCode, string Phone, string Email)
            : base(FirstName, LastName, Birthday, Address, City, State, ZipCode, Phone, Email)
            {
                this.Gender = Gender;
                this.SignificantOther = SignificantOther;
                this.YearsDated = Relationship;
            }
            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've Been Accepted to Paradise Island!");
            }
        }

        class AboveDeck : Application
        {
            public int Experience;
            public string Nationality;

            public AboveDeck(int Experience, string Nationality, string FirstName, string LastName, string Birthday, string Address, string City, string State, int ZipCode, string Phone, string Email)
                : base(FirstName, LastName, Birthday, Address, City, State, ZipCode, Phone, Email)
            {
                this.Experience = Experience;
                this.Nationality = Nationality;
            }
            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("You've Been Accepted to Above Deck!");
            }


    class Program
            {
                static void Main(string[] args)
                {
                    HouseHunter HHContestant = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

                    ParadiseIsland PIContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles", "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

                    AboveDeck ADContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com");

                    HHContestant.Submit();
                    HHContestant.Accept();
                    PIContestant.Submit();
                    PIContestant.Accept();
                    ADContestant.Submit();
                    ADContestant.Accept();
                }
            }
        }
    }
}
            
 

