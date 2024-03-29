﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace projekt_1.Activities.Shops
{
    [Activity(Label = "Add shop", Theme = "@style/Theme.AppCompat.Light")]
    public class AddShopActivity : ShopActivityBase
    {
        protected async override void DoneClick()
        {
            var model = GetModel();
            var location = await _geolocationService.GetCurrentGeolocationAsync();

            model.Latitude = location.Latitude;
            model.Longitude = location.Longitude;

            await _shopRepository.InsertAsync(model);

            OnBackPressed();
        }

        protected override string GetButtonName()
        {
            return "Save";
        }

        protected override string GetTitle()
        {
            return "Add new shop";
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}
