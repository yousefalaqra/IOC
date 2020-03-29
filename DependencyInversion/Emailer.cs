using System;

public class Emailer : IMessageSender{
    
    public void SendEmail(IPerson owner, string message){
        Console.WriteLine($"email to: {owner.FirstName},  message: { message }");
    }
}