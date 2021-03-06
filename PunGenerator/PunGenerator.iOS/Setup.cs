using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using PunGenerator.Core;
using MvvmCross.iOS.Views.Presenters;

namespace PunGenerator.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter) : base(appDelegate, presenter)
        {

        } 

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}