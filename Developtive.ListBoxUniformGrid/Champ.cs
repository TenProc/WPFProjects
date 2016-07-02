using System;
using System.Collections.Generic;

namespace Developtive.ListBoxUniformGrid
{
    internal class Champ : ObservableObject
    {
        bool _IsPick;
        public bool IsPick
        {
            get { return _IsPick; }
            set { _IsPick = value; base.OnPropertyChanged("IsPick"); }
        }
        public string Name { get; set; }
        public string Thumbnail
        {
            get { return string.Format("/Images/{0}.jpg", Name); }
        }

        internal Champ Clone()
        {
            var copy = new Champ();
            copy.Name = this.Name;
            copy.IsPick = true;
            return copy;
        }

        internal static List<Champ> SampleData()
        {
            var source = new List<Champ>();
            source.Add(Item("Aatrox"));
            source.Add(Item("Ahri"));
            source.Add(Item("Akali"));
            source.Add(Item("Alistar"));
            source.Add(Item("Amumu"));
            source.Add(Item("Anivia"));
            source.Add(Item("Annie"));
            source.Add(Item("Ashe"));
            source.Add(Item("Azir"));
            source.Add(Item("Bard"));
            source.Add(Item("Brand"));
            source.Add(Item("Braum"));
            source.Add(Item("Caitlyn"));
            source.Add(Item("Cassiopeia"));
            source.Add(Item("Chogath"));
            source.Add(Item("Corki"));
            source.Add(Item("Darius"));
            source.Add(Item("Diana"));
            source.Add(Item("Draven"));
            source.Add(Item("DrMundo"));
            source.Add(Item("Ekko"));
            source.Add(Item("Elise"));
            source.Add(Item("Evelynn"));
            source.Add(Item("Ezreal"));
            source.Add(Item("Fiddlesticks"));
            source.Add(Item("Fiora"));
            source.Add(Item("Fizz"));
            source.Add(Item("Galio"));
            source.Add(Item("Gangplank"));
            source.Add(Item("Garen"));
            source.Add(Item("Gnar"));
            source.Add(Item("Gragas"));
            source.Add(Item("Hecarim"));
            source.Add(Item("Himerdinger"));
            source.Add(Item("Irelia"));
            source.Add(Item("Janna"));
            source.Add(Item("JarvanIV"));
            source.Add(Item("Jax"));
            source.Add(Item("Jayce"));
            source.Add(Item("Jinx"));
            return source;
        }

        private static Champ Item(string name)
        {
            return new Champ { Name = name, IsPick = true };
        }
    }
}