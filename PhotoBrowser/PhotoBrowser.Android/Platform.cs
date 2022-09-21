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
using Com.Stfalcon.Frescoimageviewer;
using Xamarin.Forms;

namespace Stormlion.PhotoBrowser.Droid
{
    public class Platform
    {
        public static Context Context { get; set; }

        public static void Init(Context context)
        {
            Context = context;

            FrescoWrapper.Initialize(context);

            DependencyService.Register<PhotoBrowserImplementation>();
        }
    }
}