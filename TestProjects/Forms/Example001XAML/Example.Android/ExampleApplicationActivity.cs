﻿
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;
using Xamarin.Forms;

namespace Example.Droid
{
    [Activity(Label = "ExampleApplicationActivity", ScreenOrientation=ScreenOrientation.Portrait)]
    public class ExampleApplicationActivity : MvxFormsApplicationActivity
    {
    }
}

