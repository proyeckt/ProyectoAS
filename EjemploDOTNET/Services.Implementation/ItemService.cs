using System;
using Models;
using Entities;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class ItemService : IItemService
    {
        public bool saveItem(Item item){
            ItemRepositorio dataAccess=new ItemRepositorio();
            bool added=dataAccess.addItem(item);
            return added;
        }

        public Item findItem(int id){
            ItemRepositorio dataAccess=new ItemRepositorio();
            Item valido=dataAccess.findItem(id);
            
            if(valido!=null){
                Console.WriteLine("Valido");
            }
            else Console.WriteLine("No Valido");
            return valido;
        }

        public List<Item> findItems(){
            ItemRepositorio dataAccess=new ItemRepositorio();
            List<Item> items=dataAccess.findItems();
            
            return items;
        }

    }
}
