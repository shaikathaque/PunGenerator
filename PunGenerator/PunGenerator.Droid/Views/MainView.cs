using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace PunGenerator.Droid.Views
{
    [Activity(Label="Pun Generator", MainLauncher=true)]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}