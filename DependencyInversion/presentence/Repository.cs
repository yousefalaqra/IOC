using System.Collections.Generic;
using System.Linq;

public class Repository<T> : IRepository<T> where T : class{
    // Job: Retrive, Insert, Update, Delete entties to database

    // Create Instance of the db context to qury the database
    AppDbContext DbContext =  new AppDbContext();

    // RetriveAllItems: select and retrun all the Items form the database
    public List<T>  RetriveAllItems(){
        var entties = DbContext.Set<T>().ToList();
        return entties;
    }

    // RetriveById(int id): select and retrun the Items match a specfic id.
    public T RetriveById(int id){
        var ItemEntity = DbContext.Set<T>().Find(id);
        return ItemEntity;
    }

    // Insert(Itme): inset an item entity into the db.
    public void InsertItem(T entity){
        DbContext.Set<T>().Add(entity);
    }

    // UpdateItem(item): update an item entity
    public void UpdateItem(T entity){
         DbContext.Set<T>().Update(entity);
    }

    // RemoveItem(item): reomve an item entity
    public void RemoveItem(T entity){
        DbContext.Set<T>().Remove(entity);
    }

    // Save(): save the changes. The function must be called when altering the db, ie: when calling updateItem
    public void Save(){
        DbContext.SaveChanges();
    }

}