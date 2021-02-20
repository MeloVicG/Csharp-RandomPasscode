using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{

    // public class RandomPasscodeController : Controller
    // {
    public class MainController : Controller
    {
        private static string RandomPasscode(int length = 14)
        {
            string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rand = new Random();
            char[] chars = new char[length];
            for(int i = 0; i < length;i++)
        {
            chars[i] = validChars[rand.Next(0,validChars.Length)];
        }
            return new string(chars);
        } 
            int count = 0;
            [HttpPost("")]
            public IActionResult Index()
            {
                //retrieving session number
                // int? randNum= HttpContext.Session.GetInt32("RandNumber");
                // ViewBag.RandNumber = randNum;

                string RandomPassword = RandomPasscode();
                count += count;
                int? countIndex = HttpContext.Session.GetInt32("RandomPw");
                ViewBag.CountIndex = countIndex;
                HttpContext.Session.SetString("RandomPW", RandomPassword);
                ViewBag.RandPass = RandomPassword;

                return View();
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [HttpPost("random-number")]
            // public IActionResult RandomNumber(int number)
            // {
            //     Console.WriteLine(number);
            //     //saving number into session
            //     HttpContext.Session.SetInt32("RandNumber", number);
            //     return RedirectToAction("Index");
            // }

            //--------------------------------------------
            // [HttpPost("reset")]
            // public IActionResult ResetNumber()
            // {
            //     HttpContext.Session.Clear();
            //     return RedirectToAction("Index");
            // }

        }
    // }
}