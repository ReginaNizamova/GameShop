using GameShop.Models;
using GameShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameShop.ViewModels
{
    class NavigateViewModel : BaseViewModel
    {
        //NavigateModel navigateModel = new NavigateModel();

        public NavigateViewModel ()
        {
 
        }

        public NavigateViewModel(Frame frame)
        {
            _frame = frame;
        }
        
        private Frame _frame;

        public Frame Frame
        {
            get
            {
                if(_frame == null)
                {
                    _frame = Frame;
                }
                return _frame;
            }

            set
            {
                if (_frame == value)
                    return;

                _frame = value;
                RaisePropertyChanged("Frame");
            }
        }

        //private void NV()
        //{
        //    Frame.Navigate(new UserAccountView());
        //}
    }
}
