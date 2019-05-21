using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.Brand;

namespace TaskUser.Service
{
   
    public interface IBrandService
    {
        Task<List<BrandViewsModels>> GetBranListAsync();
        Task<bool> AddBrandAsync(BrandViewsModels addBrand);
        IEnumerable<Brand> Getbrand();
        Task<BrandViewsModels> GetIdbrandAsync(int id);
        Task<bool> EditBrandAsync(BrandViewsModels editBrand);
        bool IsExistedName(int id, string name);
        Task<bool> Delete(int id);

    }

    public class BrandService : IBrandService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BrandService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Brand> Getbrand()
        {
            return _context.Brands;
        } 

        

        /// list brand
        public async Task<List<BrandViewsModels>> GetBranListAsync()//
        {
            var list = await _context.Brands.ToListAsync();
            var listBrand = _mapper.Map<List<BrandViewsModels>>(list);
            return listBrand;
        }
        //create brand
        public async Task<bool> AddBrandAsync(BrandViewsModels addBrand)
        {
            try
            {
                var brand = new Brand()
                {
                    BrandName = addBrand.BrandName
                };
            
                _context.Brands.Add(brand);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        //get brand
        public async Task<BrandViewsModels> GetIdbrandAsync(int id)
        {
            var findBrand= await _context.Brands.FindAsync(id);
            var brandDtos = _mapper.Map<BrandViewsModels>(findBrand);
            return brandDtos;
        }
        //post edit band = try catch
        public async Task<bool> EditBrandAsync(BrandViewsModels editBrand)
        {
            try
            {
                var brand =await _context.Brands.FindAsync(editBrand.Id);
                brand.BrandName = editBrand.BrandName;
                _context.Brands.Update(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        //check dieu kien neu brandname == name 
        public bool IsExistedName(int id,string name)
        {
            return _context.Brands.Any(x => x.BrandName == name && x.Id != id);
        }
        // delet brand
        public async Task<bool>Delete(int id)
        {
            try
            {
                var brand = await _context.Brands.FindAsync(id);
                _context.Brands.Remove(brand);
                _context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
//        
    }
}