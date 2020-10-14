﻿using EndlessEntities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndlessEntities.Data
{
    public class MockDataStore : IDataStore<Entity>
    {
        private readonly List<Entity> items;

        public MockDataStore()
        {
            items = new List<Entity>()
            {
                new Entity { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Entity { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Entity { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Entity { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Entity { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Entity { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Entity item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Entity item)
        {
            var oldItem = items.Where((Entity arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Entity arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Entity> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Entity>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}