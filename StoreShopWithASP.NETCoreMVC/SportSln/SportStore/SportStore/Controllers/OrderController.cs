﻿using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository rep;
        private Cart cart;
        public OrderController (IOrderRepository repoService, Cart cartService)
        {
            rep = repoService;
            cart = cartService;
        }
        public ViewResult Checkout() => View(new Order());
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", " Sorry, your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                rep.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else return View();
        }
    }
}
