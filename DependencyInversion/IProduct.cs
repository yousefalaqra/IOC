public interface IProduct
{
    public void PurchaseItme(int quantity);
    public string Name { get; set; }
    public IPerson Owner { get; set; }
    
    public int Quantity { get; }
    public bool IsAvilable { get;   } 

}