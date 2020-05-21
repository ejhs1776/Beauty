namespace beauty.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        #region Properties

        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsRemember
        {
            get;
            set;
        }

        public bool IsVisible
        {
            get;
            set;
        }
        #endregion

        #region Commands

        public ICommand LoginCommand => new RelayCommand(login);

        public Action login
        {
            get; private set;

        }








        #endregion
    }
}
