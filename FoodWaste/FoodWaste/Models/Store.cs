using System.Collections.Generic;

namespace FoodWaste {


    public class Store {

        public Address address {get; set; }
        public string brand {get; set; }
        public string name { get; set; }
        public string id { get; set; }

        public Hours[] hours {get; set;}
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

<<<<<<< HEAD
    public class suggestions {

       public string title {get; set;} 
       public string id {get; set;} 
       public string  prod_id {get; set;} 
       public double price {get; set;} 
       public string description {get; set;} 
       public string link {get; set;} 
       public string img {get; set;} 


    }

    public class searchItemList {

         List<suggestions> suggestions {get; set;}
=======

    public class Hours {
        public string close {get;set;}
        public string open {get;set;}
        public bool closed {get;set;}
        public float[] customerFlow {get;set;}
    
>>>>>>> f6041617259bf2e4b5b302cc3cc40269b318e8a1
    }
}


