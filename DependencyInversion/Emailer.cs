using System;

public class Emailer {
    
    public void SendEmail(Owner owner, string message){
        Console.WriteLine($"email to: {owner.FirstName},  message: { message }");
    }
}