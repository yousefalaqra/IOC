using System;

public class Application : IApplication{

    private IManager _itemManager;
    private ILogger _logger;

    public Application(
        IManager itemManager,
        ILogger logger)
    {
        _itemManager = itemManager;
        _logger = logger;
    }

    public void Run(){

        var item = new ItemEntity{
            CreatedBy = nameof(Application),
            CreatedOn = DateTime.Now,
            Descreption = "Item for test",
            Name = "Jo",
            Price = 56578.5,
        };
        // save item ..
        _itemManager.AddItem(item);
        _logger.Log($"New Item has been inserted to the database.");

        // _itemManager.AddItem(item2);
        // _logger.Log($"New Item has been inserted to the database.");

        // _itemManager.AddItem(item2);
        // _logger.Log($"New Item has been inserted to the database.");

        //get item by id..  
        var getItem =  _itemManager.GetItemById(1);
        _logger.Log($"Itme Details: Name = {getItem.Name}\n Descreption = {getItem.Descreption}\n");

        // DELETE:
        _itemManager.DeleteItme(getItem);
        _logger.Log("Item with id {getItem.Id} has been deleted");

        // Update item:
        // var updatedItem = itemManager.Update(AddedItem);
        // logger.Log($"Itme has been updated successfuly: Name = {getItem.Name}\n Descreption = {getItem.Descreption}\n");

        // getALL
        var allItems = _itemManager.GetAllItems();
        foreach(var itemEntity in allItems){
            _logger.Log($"get all items {itemEntity.Id}");
        }
    }
}