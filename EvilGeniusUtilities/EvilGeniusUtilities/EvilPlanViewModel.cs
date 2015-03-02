﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilGeniusUtilities
{
    public class EvilPlanViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string EvilPlanName {
            get { return evilPlanName;  }
            set {
                if (evilPlanName != value)
                {
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("EvilPlanName"));
                    evilPlanName = value;
                }
            }
        }
        private string evilPlanName;
    }
}
