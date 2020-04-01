using System.Collections.Generic;

public interface IManager
{
    public List<ItemEntity> GetAllItems();

    public ItemEntity GetItemById(int id);

    public ItemEntity Update(ItemEntity item);

    public void AddItem(ItemEntity item);

    public void DeleteItme(ItemEntity item);
}