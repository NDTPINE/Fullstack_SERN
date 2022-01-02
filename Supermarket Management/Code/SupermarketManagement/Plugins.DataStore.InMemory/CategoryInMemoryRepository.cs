﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            //Add some default categories
            categories = new List<Category>()
            {
                new Category{CategoryId = 1, Name = "Beverage", Description="beverage" },
                new Category{CategoryId = 2, Name = "Bakery", Description="Bakery" },
                new Category{CategoryId = 3, Name = "Meat", Description="Meat" }
            };

        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            var category = categories?.FirstOrDefault(x => x.CategoryId == categoryId);
            return category;
        }
    }
}
