using System.Collections.Generic;

namespace Developtive.ListBoxApp
{
    internal class MainViewModel
    {
        MainWindow view;

        List<MyData> _Datas;
        public List<MyData> Datas
        {
            get { return _Datas; }
            set { _Datas = value; }
        }

        public MainViewModel(MainWindow _view)
        {
            this.view = _view;
        }

        internal void InitViewModel()
        {
            Datas = MyData.SampleData();
        }
    }
}