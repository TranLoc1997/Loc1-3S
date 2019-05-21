﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.Category;

namespace TaskUser.Service
{
    public interface ICategoryService
    {
        Task<List<CategoryViewsModels>> GetCategoryListAsync();
        Task<bool> AddCategoryAsync(CategoryViewsModels addCategory);
        IEnumerable<Category> GetCategory();
        Task<CategoryViewsModels> GetIdCategoryAsync(int id);
        Task<bool> EditCategoryAsync(CategoryViewsModels editCategory);
        bool IsExistedName(int id, string name);
        Task<bool> Delete(int id);
    }

    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       //show category list
        public async Task<List<CategoryViewsModels>> GetCategoryListAsync()//
        {
            var list = await _context.Categories.ToListAsync();
            var listCategory = _mapper.Map<List<CategoryViewsModels>>(list);
            return listCategory;
        }
        // create category
        public async Task<bool> AddCategoryAsync(CategoryViewsModels addCategory)
        {
            try
            {
                var category = new Category()
                {
                    CategoryName = addCategory.CategoryName,
                
                    
                };
            
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
    
        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories;
        }
        //get edit category
        public async Task<CategoryViewsModels> GetIdCategoryAsync(int id)
        {
            var findCategory=await _context.Categories.FindAsync(id);
            var categoryDtos = _mapper.Map<CategoryViewsModels>(findCategory);
            return categoryDtos;
        }
        //post edit category
        public async Task<bool> EditCategoryAsync(CategoryViewsModels editCategory)
        {
            try
            {
                var category =await _context.Categories.FindAsync(editCategory.Id);
            
                category.CategoryName = editCategory.CategoryName;
            
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }
        public bool IsExistedName(int id,string name)
        {
            return _context.Categories.Any(x => x.CategoryName == name && x.Id != id);
        }
        // delete category
        public async Task<bool> Delete(int id)
        {
            try
            {
                var category = await _context.Categories.FindAsync(id);
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
    }
}