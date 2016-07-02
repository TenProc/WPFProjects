using System;
using System.Collections.Generic;

namespace MyCheckBoxListBox
{
    internal class MainViewModel
    {
        private MainWindow view;
        public List<MyData> CheckDatas { get; set; }
            
        public MainViewModel(MainWindow _view)
        {
            this.view = _view;
        }


        internal void InitViewModel()
        {
            CheckDatas = MyData.SampleData();
        }
    }
}