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
        string tapToReveal = "Tap to Reveal";

        //load services using dependency injection
        public MainViewModel(IPunService punService, IRandomService randomService)
        {
            _punService = punService;
            _randomService = randomService;
            puns = _punService.getPunList();
            puns = _randomService.Randomize(puns);
            index = 0;
            Answer = tapToReveal;
        }

        public ICommand NextPunCommand
        {
            get { return new MvxCommand(() => NextPun()); }
        }

        public ICommand TapToRevealCommand
        {
            get { return new MvxCommand(() => TapToReveal()); }
        }

        private void TapToReveal()
        {
            Answer = puns[index].Answer;
            RaisePropertyChanged("");
        }

        public string Question
        {
            get { return puns[index].Question; }
            set { Question = value; }
        }

        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        private void NextPun()
        {
            index++;
            Answer = tapToReveal;

            if (index == puns.Count)
            {
                reset();
            }

            //empty string tells UI to reread all properties
            RaisePropertyChanged("");
        }

        private void reset()
        {
            index = 0;
            puns = _randomService.Randomize(puns);
        }

    }
}
