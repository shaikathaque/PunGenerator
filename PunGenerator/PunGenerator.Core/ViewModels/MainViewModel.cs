using MvvmCross.Core.ViewModels;
using PunGenerator.Core.Models;
using PunGenerator.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace PunGenerator.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IPunService _punService;
        private IRandomService _randomService;
        private int index;
        List<Pun> puns;

        public MainViewModel(IPunService punService, IRandomService randomService)
        {
            _punService = punService;
            _randomService = randomService;
            puns = _punService.getPunList();
            puns = _randomService.Randomize(puns);
            index = 0;
        }

        public ICommand NextPunCommand
        {
            get { return new MvxCommand(() => NextPun()); }
        }

        private void NextPun()
        {
            index++;

            //empty string tells UI to reread all properties
            RaisePropertyChanged("");
        }

        public string Question
        {
            get { return puns[index].Question; }
        }

        public string Answer
        {
            get { return puns[index].Answer; }
        }

    }
}
