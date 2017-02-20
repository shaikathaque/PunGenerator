using PunGenerator.Core.Services.Interfaces;
using Android.Media;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using Android.App;

namespace PunGenerator.Droid.Services
{
    public class SoundService : ISoundService
    {
        MediaPlayer player;
        

        public void PlaySound(string filePath)
        {
            

            if (player == null)
            {
                var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
                var resourceId = (int)typeof(Resource.Raw).GetField(filePath).GetValue(null);

                player = MediaPlayer.Create(activity.ApplicationContext, resourceId);
            } else
            {
                if (player.IsPlaying)
                {
                    player.SeekTo(0);
                } else
                {
                    player.Start();
                }
            }
            
        }
    }
}