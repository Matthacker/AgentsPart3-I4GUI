﻿using System.Collections.ObjectModel;

namespace Delopgave5
{
    class Speciality : ObservableCollection<string>
    {
        public  Speciality()
        {
            Add("Assassination");
            Add("CodeGenius");
            Add("BabyMaker");
            Add("IceCreamMaker");
            Add("Systematicer");
        }
    }
}
