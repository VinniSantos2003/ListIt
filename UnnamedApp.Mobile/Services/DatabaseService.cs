
using Android.Graphics.Pdf.Models;
using Microsoft.EntityFrameworkCore;

using UnnamedApp.SharedKernel.Data;

namespace UnnamedApp.Mobile.Services
{
    public class DatabaseService
    {
        private ApplicationContext _dbContext;

        public DatabaseService(ApplicationContext applicationContext)
        {
            _dbContext = applicationContext;
        }

        public async Task<List<ItemList>> GetAllItemLists()
        {
            return await _dbContext.ItemLists.ToListAsync();
        }
        public async Task<ItemList> GetItemList(Guid id)
        {
            return await _dbContext.ItemLists.FirstAsync(x => x.Id == id);
        }   

        public async Task EditItemList(ItemList itemList)
        {
            _dbContext.ItemLists.Update(itemList);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteItemList(Guid Id)
        {
            await _dbContext.ItemLists.Where(x=>x.Id == Id).ExecuteDeleteAsync();
        }
        public async Task<List<Item>> GetItemsFromList(Guid listId)
        {
            return await _dbContext.Items.Where(x => x.ItemListId == listId).ToListAsync();
        }
        public async Task<List<Item>> GetAllItems()
        {
            return await _dbContext.Items.ToListAsync();
        }
        public async Task<Item> GetItem(Guid id)
        {
            return await _dbContext.Items.FirstAsync(x => x.Id == id);
        }
        public async Task SaveItem(Item item)
        {
            await _dbContext.Items.AddAsync(item);
        }
        public async Task EditItem(Item item)
        {
            _dbContext.Items.Update(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteItem(Item item)
        {
            await _dbContext.Items.Where(x => x.Id == item.Id).ExecuteDeleteAsync();
        }   
         
    }
}
