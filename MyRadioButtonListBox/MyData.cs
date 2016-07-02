using System;
using System.Collections.Generic;

namespace MyRadioButtonListBox
{
    internal class MyData
    {
        public MyData()
        {
        }

        public string Color { get; set; }
        public string DisplayName { get; set; }

        internal static List<MyData> SampleData()
        {
            var source = new List<MyData>();
            source.Add(new MyData { Color = "#99b433", DisplayName = "Light Green" });
            source.Add(new MyData { Color = "#00a300", DisplayName = "Green" });
            source.Add(new MyData { Color = "#1e7145", DisplayName = "Dark Green" });
            source.Add(new MyData { Color = "#ff0097", DisplayName = "Magenta" });
            source.Add(new MyData { Color = "#9f00a7", DisplayName = "Light Purple" });
            source.Add(new MyData { Color = "#7e3878", DisplayName = "Purple" });
            source.Add(new MyData { Color = "#603cba", DisplayName = "Dark Purple" });
            return source;
        }
    }
}