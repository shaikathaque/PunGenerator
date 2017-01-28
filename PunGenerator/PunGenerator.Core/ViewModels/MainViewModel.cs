using MvvmCross.Core.ViewModels;
using PunGenerator.Core.Models;
using PunGenerator.Core.Services.Interfaces;
using System.Collections.Generic;

namespace PunGenerator.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IPunService _punService;
        List<Pun> puns;
        private int randomIndex;

        public MainViewModel(IPunService punService)
        {
            _punService = punService;
            puns = _punService.getPunList();
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
