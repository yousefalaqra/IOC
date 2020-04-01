using System.Collections.Generic;

public interface IRepository<T> where T : class 
{
    public List<T>  RetriveAllItems();

    public T RetriveById(int id);

    public void InsertItem(T entity);

    public void UpdateItem(T entity);

    public void RemoveItem(T entity);

    public void Save();
    
}