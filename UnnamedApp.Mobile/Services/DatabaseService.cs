using System;
using System.Collections.Generic;
using System.Text;
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

        public async Task SaveItem(Item item)
        {
            await _dbContext.Items.AddAsync(item);
        }


    }
}
