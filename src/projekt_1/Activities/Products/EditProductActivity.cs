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

namespace projekt_1.Activities.Products
{
    [Activity(Label = "Edit product")]
    public class EditProductActivity : ProductAcitivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var id = Int32.Parse(Intent.GetStringExtra("ID"));
            var model = _productRepository.GetProduct(id);

            _id = id;
            _txtCount.Text = model.Count.ToString();
            _txtName.Text = model.Name;
            _txtPrice.Text = model.Price.ToString();
        }

        protected override void DoneClick()
        {
            var model = GetModel();
            _productRepository.Update(model);
            StartActivity(typeof(ProductListActivity));
        }

        protected override string GetButtonName()
            => "Update";

        protected override string GetTitle()
            => "Update product";
    }
}