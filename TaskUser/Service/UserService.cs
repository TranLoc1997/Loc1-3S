﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Encryption;
using TaskUser.Models;
using TaskUser.Models.Sales;
using TaskUser.ViewsModels.User;

namespace TaskUser.Service
{
    public interface IUserService
    {
        bool Login(string email, string password);
        Task<List<UserViewsModels>> GetUserListAsync();
        Task<bool> AddUserAsync(UserViewsModels user);
        Task<EditViewPassword> GetPasswordAsync(int id);
        Task<bool> EditPasswordAsync(EditViewPassword passUser);
        IEnumerable<User> GetUser();
        Task<EditUserViewsModels> GetIdAsync(int id);
        Task<bool> EditUserAsync(EditUserViewsModels userParam);
        User GetName(string name);
        Task<bool> Delete(int id);
        
        bool IsExistedEmailUser(int id, string email);

    }

    public class UserService : IUserService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// ckeck login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>true of flase</returns>
        public bool Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            var user = _context.Users.FirstOrDefault(x =>
                x.Email == email && SecurePasswordHasher.Verify(password, x.PassWord));

            if (user == null)

            {
                return false;
            }

            return true;
        }
//get list show user
        public async Task<List<UserViewsModels>> GetUserListAsync()
        {
            var list = await _context.Users
                .Include(u=>u.Store).
                ToListAsync();
            var listUser = _mapper.Map<List<UserViewsModels>>(list);
            return listUser;
            
        }

        public IEnumerable<User> GetUser()
        {
            return _context.Users;
        } 
//create user
        public async Task<bool> AddUserAsync(UserViewsModels user)
        {
            try
            {
                var users = new User()
                {
                    Name = user.Name,
                    Email = user.Email,
                    PassWord =SecurePasswordHasher.Hash(user.PassWord),
                    Phone = user.Phone,
                    StoreId = user.StoreId,
                    IsActiver = user.IsActiver
                    
                };
            
                await _context.Users.AddAsync(users);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }  
           
        }
        
        //get edit id      
        public async Task<EditUserViewsModels> GetIdAsync(int id)
        {
            var findUser=await _context.Users.FindAsync(id);
            var userDtos = _mapper.Map<EditUserViewsModels>(findUser);
           
            return userDtos;
          
          
        }

        //post edit id   

        public async Task<bool> EditUserAsync(EditUserViewsModels userParam)
        {
            try
            {
                var user = await _context.Users.FindAsync(userParam.Id);
                
                user.Name = userParam.Name;
                user.Email = userParam.Email;
                user.Phone = userParam.Phone;
                user.IsActiver = userParam.IsActiver;
                user.StoreId = userParam.StoreId;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }
        //get password
        public async Task<EditViewPassword> GetPasswordAsync(int id)
        {
            var findPassWord= await _context.Users.FindAsync(id);
            var usereditDtos = _mapper.Map<EditViewPassword>(findPassWord);           
            return usereditDtos;
        }
        
        //post user Password
        public async Task<bool> EditPasswordAsync(EditViewPassword passUser)
        {
            try
            {
                var user = await _context.Users.FindAsync(passUser.Id);
                user.PassWord = SecurePasswordHasher.Hash(passUser.NewPassword);
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
       
        // delete user
        public async Task<bool> Delete(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        //ckeck name
        public User GetName(string email)
        {
            var user = _context.Users.FirstOrDefault(x =>
                x.Email == email );

            return user;
        }
        //ckeck trung email
        public bool IsExistedEmailUser(int id,string email)
        {
            return _context.Users.Any(x => x.Email == email && x.Id != id);
        }
    }
}