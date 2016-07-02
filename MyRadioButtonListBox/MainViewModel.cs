using System;
using System.Collections.Generic;

namespace MyRadioButtonListBox
{
    internal class MainViewModel
    {
        private MainWindow mainWindow;

        public MainViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public List<MyData> MyDatas { get; set; }

        internal void InitViewModel()
        {
            MyDatas = MyData.SampleData();
        }
    }
}