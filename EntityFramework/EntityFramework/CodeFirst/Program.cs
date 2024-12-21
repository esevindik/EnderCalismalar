﻿// See https://aka.ms/new-console-template for more information
using CodeFirst.DAL;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();
    products.ForEach(p => { Console.WriteLine($"{p.Name}-{p.Price}-{p.Stock}"); });
    
    
}
