﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.Store;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<StoreResource> _storeLocalizer;
        public StoreController(IStoreService storeService,SharedViewLocalizer<CommonResource> localizer,SharedViewLocalizer<StoreResource> storeLocalizer)
        {
            _storeService = storeService;
            _localizer = localizer;
            _storeLocalizer = storeLocalizer;

        }
        
        /// <summary>
        /// show index of store
        /// </summary>
        /// <returns>return view</returns>
        public async Task<IActionResult> Index()
        {
            var listStore = await _storeService.GetStoreListAsync();
            return View(listStore);

        }
        
        /// <summary>
        /// get create of store
        /// </summary>
        /// <returns>view create of store</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        /// <summary>
        /// post create of store
        /// </summary>
        /// <param name="store"></param>
        /// <returns>index of store else view</returns>
        [HttpPost]
        public async Task<IActionResult> Create(StoreViewModels store)
        {
            if (ModelState.IsValid)
            {
                var addStore = await _storeService.AddStoreAsync(store);
                if (addStore)
                {
                    TempData["Successfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index");
                }
                TempData["Failure"] = _localizer.GetLocalizedString("err_AddFailure").ToString();
                return View(store);
            }
            
            return View(store);
        }
        
        /// <summary>
        /// get edit of store
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view edit of stroe</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int?id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var getstore =await _storeService.GetIdStoreAsync(id.Value);
           
            return View(getstore);
        }
        
        /// <summary>
        /// post edit of store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editStore"></param>
        /// <returns>index of store else view</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(StoreViewModels editStore)
        {
           
            if (ModelState.IsValid)
            {
                 var store= await _storeService.EditStoreAsync(editStore);
                if (store)
                {
                    
                    TempData["Successfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly").ToString();
                    return RedirectToAction("Index");
                }
                TempData["Failure"] = _localizer.GetLocalizedString("err_EditFailure").ToString();
                return View(editStore);
                }
            return View(editStore);
        }
        
        /// <summary>
        /// delete of store
        /// </summary>
        /// <param name="id"></param>
        /// <returns>index</returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
           var rmStore=await _storeService.Delete(id.Value);
            if (rmStore)
            {
                TempData["Successfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly").ToString();
                return RedirectToAction("Index"); 
            }
            TempData["Failure"] = _localizer.GetLocalizedString("err_DeleteFailure").ToString();
            return RedirectToAction("Index");
            
        }
    }
}