﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using projekt_1.Models;

namespace projekt_1.Services.Products
{
    public interface IProductService : IService
    {
        void ProductWasCreated(Product product);
    }
}