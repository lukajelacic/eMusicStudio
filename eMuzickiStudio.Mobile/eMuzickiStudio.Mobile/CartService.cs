using eMuzickiStudio.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMuzickiStudio.Mobile
{
    public static class CartService
    {
        public static Dictionary<int, MuzickaOpremaDetailViewModel> Cart { get; set; } = new Dictionary<int, MuzickaOpremaDetailViewModel>();
    }
}
