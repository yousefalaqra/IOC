public class Phone {
    
    public string Name { get; set; }
    public Owner Owner { get; set; }
    
    public int Quantity { get; set; }
    public bool IsAvilable { get;  set; } 

    public Phone(
        int quantity
    )
    {
        this.Quantity = quantity;
        this.IsAvilable = this.Quantity > 0;
    }

    public void PurchaseItme(int quantity){
        // cases to be handled when soneone want to purhcase an item ... 
        // success pruchase: 
        // case: the amount of the item quantity in the stock is equale to the purhcase quntity or it's more than the purhcase qunatity
        // possible fail purhcase: 
        //  when the totlat amount of item quantity in the stock is less than the quntity amount of purchase but it's not equal to 0
        // in this case we should try to ask the user to purchase the item again with the avalible quantity.
        // fail purchase:
        // case: when isAvalible is equlas to flase.

      var _logger = new Logger();
      var _emailer = new Emailer();  


      if(this.IsAvilable){  
          if(quantity <= this.Quantity){
              this.Quantity = this.Quantity - quantity;
              this.IsAvilable = this.Quantity > 0;
              _logger.Log("Thank you for your purchase!");
              _emailer.SendEmail(this.Owner, $"The itme: {this.Name} was purchased. Amount left in the sotck {this.Quantity}");
          } else{
              _logger.Log($"Sorry, only {this.Quantity} left in the stock. Press 1 to adjust your purhcase amount or 0 to cancle ...");
              /// to do handle the case when the user enter 1 or 0.
               
          }

      }else {
          _logger.Log("Sorry, the item is out of stock");
          _emailer.SendEmail(this.Owner, $"The itme: {this.Name} is out of stock, someone tried to purchase it.");
      }
    }
}