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
        public int discount {get; set;}

        public int newPrice {get; set;}

        public int originalPrice {get; set;}

        public int percentDiscount {get; set;}

        public string startTime {get; set;}

        public string endTime {get; set;}

        public int stock {get; set;} 

    } 

    public class Product {


        public string description { get; set; }
        public string image { get; set; }

    }
    public class Clearances {
        
        public Offer offer { get; set;}
        public Product product {get; set;}

     

    }

    public class foodOffers {
        public Clearances clearances {get; set;} 
    }
}

