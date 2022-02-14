
namespace FoodWaste {

    public class User {

    
int id; 
string userName; 
string userPassword; 
string email;

        public User(string userName, string userPassword, string email)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.email = email;

        }

     public int getId() {
         return this.id;
     }
    
     public int setId() {
         return this.id;
     }


    public string getUserName() {
        return this.userName;
    }

    public string setUserName() {
        return this.userName;
    }
    

    public string getEmail() {
        return this.email;
    }

    public string setEmail() {
        return this.email;
    }


    }
}