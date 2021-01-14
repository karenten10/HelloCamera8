using System;
using Android.App;
using Android.Runtime;

namespace HelloCamera8.Droid
{
    //[Application(
    //    Theme = "@style/MainTheme"
    //    )]

#if DEBUG
[Application(
        Theme = "@style/MainTheme",
        Debuggable = true
        )]
#else
    [Application(
        Theme = "@style/MainTheme",
        Debuggable = false
        )]
#endif

    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}
