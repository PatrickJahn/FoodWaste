using System.Collections.Generic;

namespace FoodWaste {


public class Store {

    public Address address {get; set; }
    public string brand {get; set; }

    public string name { get; set; }

}

public class Address{
    public string city { get; set; } 
    public string country { get; set; } 
    public string street { get; set; }
    public string zip { get; set; }

}

public class Offer {

    string currency;
    int discount;

    int newPrice; 

    int originalPrice;

    int percentDiscount;

    string startTime; 

    string endTime;

    int stock; 

} 

public class Product {


string description;

string image; 

public string Image { get; set; }
}

public class Clearances {

List<Offer> offerList = new List<Offer>();

List<Product> productList = new List<Product>(); 

}


}

