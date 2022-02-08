using System.Collections.Generic;

namespace FoodWaste {


    public class Store {

        public Address address {get; set; }
        public string brand {get; set; }
        public string name { get; set; }
        public string id { get; set; }

    }

    public class Address{
        public string city { get; set; } 
        public string country { get; set; } 
        public string street { get; set; }
        public string zip { get; set; }

    }

    public class Offer {

        public string currency {get; set;}
        public float discount {get; set;}

        public float newPrice {get; set;}

        public float originalPrice {get; set;}

        public float percentDiscount {get; set;}

        public string startTime {get; set;}

        public string endTime {get; set;}

        public float stock {get; set;} 

    } 

    public class Product {


        public string description { get; set; }
        public string image { get; set; }

    }
    public class Clearances {
        
        
        public Offer offer { get; set;}
        public Product product {get; set;}

     

    }

    public class foodWasteDTO {


        public Store store {get; set;}
        public List<Clearances> clearances {get; set;} 
    }
}

