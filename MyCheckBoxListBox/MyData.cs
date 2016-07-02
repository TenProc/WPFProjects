using System;
using System.Collections.Generic;

namespace MyCheckBoxListBox
{
    public class MyData
    {
        public string CheckBoxName { get; set; }
        public bool IsUsed { get; set; }

        internal static List<MyData> SampleData()
        {
            var source = new List<MyData>();
            source.Add(new MyData { CheckBoxName = "Microsoft", IsUsed = true });
            source.Add(new MyData { CheckBoxName = "Kakao", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Google", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Apple", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Facebook", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Oracle", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "NCSoft", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Amazon", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Xiaomi", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Twitter", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Steam", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "NHN", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Line", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Samsung", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Nokia", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Maxis", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Sony", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Intel", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "OnDrive", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Instagram", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "IBM", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Cyworld", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Alibaba", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "DELL", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "EA", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Lenovo", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "NateOn", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "NEC", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "LG", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "TeamViewer", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Riot", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Exchangegram", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Blizzard", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Canon", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Hyundai", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Ebay", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Yahoo", IsUsed = false });
            source.Add(new MyData { CheckBoxName = "Tencent", IsUsed = false });
            return source;
        }
    }
}