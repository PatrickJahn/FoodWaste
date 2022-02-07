using System.Collections.Generic;

namespace FoodWaste {


public class Store {

    string address; 
    string city; 
    string country; 
    string street;
    int zip; 
    string brand;
    string name; 

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

}

public class Clearances {

List<Offer> offerList = new List<Offer>();

List<Product> productList = new List<Product>(); 

}


}

