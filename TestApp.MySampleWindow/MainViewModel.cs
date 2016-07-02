using System.Collections.Generic;

namespace TestApp.MySampleWindow
{
    internal class MainViewModel
    {
        MainWindow view;

        List<TalkData> _Talks;
        public List<TalkData> Talks
        {
            get { return _Talks; }
            set { _Talks = value; }
        }

        public MainViewModel(MainWindow _view)
        {
            this.view = _view;
        }

        internal void InitViewModel()
        {
            Talks = TalkData.SampleData();
        }
    }
}