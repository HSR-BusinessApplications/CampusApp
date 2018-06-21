﻿// Copyright (c) Hochschule für Technik Rapperswil. All Rights Reserved.
// Licensed under the Apache 2.0 license. See LICENSE.txt in the project root for license information.

namespace Hsr.Campus.Droid.Views
{
    using Android.App;
    using Android.OS;
    using Android.Views;
    using Core.ViewModels;
    using Widgets;
    using Widgets.ViewPager;

    [Activity(Label = "@string/TileCampusMap", Theme = "@style/Theme.View", Icon = "@drawable/ic_launcher")]
    public class MapView : TabViewPagerActivity<MapViewModel, BaseItemView>
    {
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_refresh:
#pragma warning disable 4014
                    this.ViewModel.UpdateCommand.Execute(null);
#pragma warning restore 4014
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            this.MenuInflater.Inflate(Resource.Menu.updateable, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            if (this.ViewModel.Id == null)
            {
                this.SetContentView(Resource.Layout.MapViewHome);
            }
            else
            {
                this.ActionBar.Title = this.ViewModel.Title;
                this.SetContentView(Resource.Layout.MapView);
            }
        }
    }
}
