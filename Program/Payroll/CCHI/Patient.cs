using System;

//Author: 


namespace CCHI
{


    class Patient
    {        
        public string PatientType { get; set; }
        public String FirstName {get; set;}
        public String LastName {get; set;}
        public String Gender {get; set;}
        public string Married { get; set; }
        public String BirthDate{get; set;}
        public double HealthCareExpenses{get; set;} 
        public double CopayRate { get; }
        public double Copay { get; }
        public double InsuranceCoverage { get; }
        public String StreetAddress {get; set;}        
        public String City {get; set;}        
        public String State {get; set;}        
        public String Zip {get; set;}        
        public string check { get; set; } 
    }
    class OutPatient : Patient
    {
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
    }
    class ResidentPatient : Patient
    {
        public string HospitalName { get; set; }
    }
    class Contact
    {
        public String HomeNumber { get; set; }
        public String MobileNumber { get; set; }
        public string ContactPhone { get; set; }
        public string HospitalPhone { get; set; }
    }
}
