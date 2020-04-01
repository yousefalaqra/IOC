using System;
using System.Collections.Generic;

public class Manager : IManager{
    // job: handleing the logic behind insert, udpate, delete, retrive, and save items entitiy by calling the repository

    // create an instance of the items repository
    private IRepository<ItemEntity> _itmesRepository;

    public Manager(IRepository<ItemEntity> itemRepository)
    {
        _itmesRepository = itemRepository;
    }


    // GetAllItems(): function will be reposnble to handle the reuquired logic to get all the items 
    public List<ItemEntity> GetAllItems(){
        return _itmesRepository.RetriveAllItems();
    }

    //// GetItemById(int id): function will be reposnble to handle the reuquired logic to get an item by id
    public ItemEntity GetItemById(int id){
        ItemEntity item = null;
        if(id > 0){
            item =  _itmesRepository.RetriveById(id);
        }else{
            throw new Exception("Invalid ID value");
        }
        if(item != null)
        return item;
        else
        throw new Exception("Itme Not Found");
    } 

    //Update(item): function will be reposnble to handle the reuquired logic to udpate an Item
    public ItemEntity Update(ItemEntity item){

        _itmesRepository.UpdateItem(item);
        _itmesRepository.Save();

        var udpatedItem = GetItemById(item.Id);
        return udpatedItem;
    }

    //AddItem(item): function will be reposnble to handle the reuquired logic to udpate an Item
    public void AddItem(ItemEntity item){
        _itmesRepository.InsertItem(item);
        _itmesRepository.Save();
    }

     //Delete(item): function will be reposnble to handle the reuquired logic to udpate an Item
    public void DeleteItme(ItemEntity item){
        _itmesRepository.RemoveItem(item);
        _itmesRepository.Save();
    }

}