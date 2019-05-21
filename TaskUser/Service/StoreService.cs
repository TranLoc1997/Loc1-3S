﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Sales;
using TaskUser.ViewsModels.Store;

namespace TaskUser.Service
{
    public interface IStoreService
    {
        Task<List<StoreViewModels>> GetStoreListAsync();
        IEnumerable<Store> GetStore();
        Task<bool> AddStoreAsync(StoreViewModels addStore);
        Task<StoreViewModels> GetIdStoreAsync(int id); //
        Task<bool> EditStoreAsync(StoreViewModels editStore);
        bool IsExistedEmailStore(int id, string email);
        Task<bool> Delete(int id);



    }
    public class StoreService : IStoreService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StoreService(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
      
//
       // get show store
        public async Task<List<StoreViewModels>> GetStoreListAsync()//
        {
            var list = await _context.Stores
                .ToListAsync();
            var listStore = _mapper.Map<List<StoreViewModels>>(list);
            return listStore;
        }

        public IEnumerable<Store> GetStore()
        {
            return _context.Stores;
        } 
        // get create store
        public async Task<bool> AddStoreAsync(StoreViewModels addStore)
        {
            try
            {
                var store = new Store()
                {
                    StoreName = addStore.StoreName,
                    Email = addStore.Email,
                    Phone = addStore.Phone,
                    City = addStore.City,
                    State = addStore.State,
                    Street = addStore.Street,
                    ZipCode = addStore.ZipCode,
                    
                };
            
                await _context.Stores.AddAsync(store);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }  
        //get edit id store
        public async Task<StoreViewModels> GetIdStoreAsync(int id)
        {
            var findStore=await _context.Stores.FindAsync(id);
            var storeDtos = _mapper.Map<StoreViewModels>(findStore);
            return storeDtos;
        }
        // get edit store
        public async Task<bool> EditStoreAsync(StoreViewModels editStore)
        {
            try
            {
                var store =await _context.Stores.FindAsync(editStore.Id);
            
                store.StoreName = editStore.StoreName;
                store.Email = editStore.Email;
                store.Phone = editStore.Phone;
                store.City = editStore.City;
                store.State = editStore.State;
                store.Street = editStore.Street;
                store.ZipCode = editStore.ZipCode;
                _context.Stores.Update(store);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }
        // ckeck email
        public bool IsExistedEmailStore(int id,string email)
        {
            return _context.Stores.Any(x => x.Email == email && x.Id != id);
        }
        
        //delete store
        public async Task<bool> Delete(int id)
        {
            try
            {
                var store = await _context.Stores.FindAsync(id);
                _context.Stores.Remove(store);
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