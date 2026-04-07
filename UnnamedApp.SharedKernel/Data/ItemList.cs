using System;
using System.Collections.Generic;
using System.Text;

namespace UnnamedApp.SharedKernel.Data
{
    public class ItemList : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Item>? Items { get; set; }
        /// <summary>
        /// Metodo que verifica se todos os itens da lista foram comprados,
        /// retornando true se todos os itens foram comprados e false caso contrário.
        /// </summary>
        /// <returns></returns>
        public bool WereAllItemsBought()
        {
            if(Items == null || Items.Any(x=>x.Bought == false))
            {
                return false;
            }
            return true;
        }

        public void AddItem(Item item)
        {
            if (Items == null)
            {
                Items = new List<Item>();
            }
            Items.Add(item);
        }
        public void RemoveItem(Guid itemId)
        {
            if (Items == null) return;
            Items.RemoveAll(x => x.Id == itemId);
        }
        public void RemoveItem(Item item)
        {
            if (Items == null) return;
            Items.RemoveAll(x => x.Id == item.Id);
        }
        public void RemoveAllItems()
        {
            Items?.RemoveAll(x=> x.CreatedAt > DateTime.MinValue);
        }
    }
}
