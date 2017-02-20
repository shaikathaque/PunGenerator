using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using PunGenerator.Core;
using MvvmCross.Platform;
using PunGenerator.Core.Services.Interfaces;
using PunGenerator.Droid.Services;

namespace PunGenerator.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void InitializeFirstChance()
        {
            //Register Platform Specific Services
            Mvx.RegisterSingleton<ISoundService>(new SoundService());

            base.InitializeFirstChance();
        }
    }
}