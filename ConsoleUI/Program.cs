﻿using Business.Concrete;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
           
            foreach (var product in productManager.GetALL())   
            {
                Console.WriteLine(product.ProductName);
            }

        }

            
    }
}