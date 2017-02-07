using MvvmCross.Core.ViewModels;
using PunGenerator.Core.Models;
using PunGenerator.Core.Services.Interfaces;
using System.Collections.Generic;

namespace PunGenerator.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IPunService _punService;
        private IRandomService _randomService;
        List<Pun> puns;

        public MainViewModel(IPunService punService, IRandomService randomService)
        {
            _punService = punService;
            _randomService = randomService;
            puns = _punService.getPunList();
            puns = _randomService.Randomize(puns);
        }

        public string Question
        {
            get { return puns[0].Question; }
        }

        public string Answer
        {
            get { return puns[0].Answer; }
        }

    }
}
