using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Developtive.ListBoxUniformGrid
{
    internal class MainViewModel
    {
        private MainWindow mainWindow;

        List<Champ> _Champs;
        public List<Champ> Champs
        {
            get { return _Champs; }
            set { _Champs = value; }
        }

        Champ _CurrentChamp;
        public Champ CurrentChamp
        {
            get { return _CurrentChamp; }
            set
            {
                _CurrentChamp = value;
                _CurrentChamp.IsPick = false;
                if (picked % 2 == 0)
                    BluePicked.Add(value.Clone());
                else
                    PupplePicked.Add(value.Clone());

                picked++;
            }
        }

        int picked;

        ObservableCollection<Champ> _BluePicked;
        public ObservableCollection<Champ> BluePicked
        {
            get { return _BluePicked; }
            set { _BluePicked = value; }
        }

        ObservableCollection<Champ> _PupplePicked;
        public ObservableCollection<Champ> PupplePicked
        {
            get { return _PupplePicked; }
            set { _PupplePicked = value; }
        }


        public MainViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        internal void InitViewModel()
        {
            BluePicked = new ObservableCollection<Champ>();
            PupplePicked = new ObservableCollection<Champ>();
            Champs = Champ.SampleData();
        }
    }
}