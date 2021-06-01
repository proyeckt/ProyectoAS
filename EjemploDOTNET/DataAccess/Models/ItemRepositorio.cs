using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

using Data;


using Entities;

namespace Models
{
    public class ItemRepositorio{
        public bool addItem(Item item){
            using (var context = new UsuarioContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
                context.Items.Add(item);

                // Saves changes
                context.SaveChanges();
                return true;
            }
        }

        public Item findItem(int id){
            using (var context = new UsuarioContext())
            {
                var items = context.Items;
                foreach (var it in items)
                {
                    if(id.Equals(it.ID)){
                        Console.WriteLine("True");
                        return it;
                    }
                    //if(string.Compare(email,user.Email)==0 && string.Compare(password,user.Password)==0)
                    
                }
                Console.WriteLine("False");
                return null;
            }
        }

        public List<Item> findItems(){
            using (var context = new UsuarioContext())
            {
                var items = context.Items;
                return items.ToList();
            }
        }
    }   
}