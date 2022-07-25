﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;

        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat)
        {
            _allCars = iallCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List() 
        {
            ViewBag.Title = "Страница с авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
     
        }

    }
}