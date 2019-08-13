using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int? SessHappiness = HttpContext.Session.GetInt32("Happiness");
            if(SessHappiness == null)
            {
                HttpContext.Session.SetInt32("Happiness", 20);
            }
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            int? SessMeals = HttpContext.Session.GetInt32("Meals");
            if(SessMeals == null)
            {
                HttpContext.Session.SetInt32("Meals", 3);
            }
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            int? SessFullness = HttpContext.Session.GetInt32("Fullness");
            if(SessFullness == null)
            {
                HttpContext.Session.SetInt32("Fullness", 20);
            }
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");

            int? SessEnergy = HttpContext.Session.GetInt32("Energy");
            if(SessEnergy == null)
            {
                HttpContext.Session.SetInt32("Energy", 50);
            }
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");

            if(HttpContext.Session.GetInt32("Happiness") == 0 || HttpContext.Session.GetInt32("Fullness") ==0)
            {
                TempData["Message"] = "Your Dachi hit 0 happiness/fullness. You lost";
            }
            return View();

        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
           int? meal = HttpContext.Session.GetInt32("Meals"); //gives 3
            if(meal > 0)
            {
                meal =  meal -1; //should give 2
                HttpContext.Session.SetInt32("Meals", (int)meal);
                ViewBag.Meals = HttpContext.Session.Get("Meals");

                Random rand = new Random();
                int randFullness = rand.Next(5,10);
                int randNum = rand.Next(1,4);
                int? fullness = HttpContext.Session.GetInt32("Fullness");
                if(randNum != 1){
                    fullness += randFullness;
                    HttpContext.Session.SetInt32("Fullness", (int)fullness);
                    TempData["Message"] = $"Your Dachi got +{randFullness} after you fed it";
                }
                else{
                    TempData["Message"] = "Your Dachi didn't like what you fed it. +0 fullness";
                }
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                return RedirectToAction("Index");
            }
            else{
                TempData["Message"] = "You ran out of food to feed your Dachi. Go work for more meals.";
                return RedirectToAction("Index");
            }
        }

        [HttpGet("play")]

        public IActionResult Play()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            if(energy > 0)
            {
                energy -= 5;
                HttpContext.Session.SetInt32("Energy", (int)energy);
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");

                Random rand = new Random();
                int? happiness = HttpContext.Session.GetInt32("Happiness");
                int randNum = rand.Next(1,4);
                int randHappy = rand.Next(5,10);
                if(randNum != 1)
                {
                    happiness += randHappy;
                    HttpContext.Session.SetInt32("Happiness", (int)happiness);
                    TempData["Message"] = $"Your Dachi was pleased and gained +{randHappy} happiness after you played with it!";
                }
                else{
                    TempData["Message"] ="Your Dachi didn't didn't enjoy the activity. Got 0 happiness";
                }
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                return RedirectToAction("Index");
            }
            else{
                TempData["Message"] = "You ran out of energy to play with your Dachi. Rest up to regain energy.";
                return RedirectToAction("Index");
            }
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? meal = HttpContext.Session.GetInt32("Meals");
            energy -= 5;
            HttpContext.Session.SetInt32("Energy", (int)energy);
            Random rand = new Random();
            int randMeal = rand.Next(1,3);
            meal += randMeal;
            HttpContext.Session.SetInt32("Meals", (int)meal);
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            TempData["Message"] = $"You worked and received {randMeal} meals";
            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]

        public IActionResult Sleep()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            energy += 15;
            HttpContext.Session.SetInt32("Energy", (int)energy);
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");

            int? fullness = HttpContext.Session.GetInt32("Fullness");
            fullness -= 5;
            HttpContext.Session.SetInt32("Fullness", (int)fullness);
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");

            int? happiness = HttpContext.Session.GetInt32("Happiness");
            happiness -= 5;
            HttpContext.Session.SetInt32("Happiness",(int) happiness);
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            TempData["Message"] = $"You slept and regained +15 energy, but neglected your Dachi. It lost 5 Fullness and Happiness";
            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
