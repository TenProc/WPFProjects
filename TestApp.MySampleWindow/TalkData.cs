using System;
using System.Collections.Generic;

namespace TestApp.MySampleWindow
{
    internal class TalkData
    {
        public string DisplayMembers { get; private set; }
        public string Thumbnail { get; private set; }
        public DateTime Time { get; private set; }
        public int NewMessages { get; private set; }
        public string Message { get; private set; }

        internal static List<TalkData> SampleData()
        {
            var source = new List<TalkData>();
            source.Add(new TalkData { DisplayMembers ="이재웅, 박종호, 정동민", Message = "대박사건 ㅋㅋ", Time = DateTime.Now, Thumbnail = "/Images/kko.png", NewMessages = 7 });
            source.Add(new TalkData { DisplayMembers = "이재웅, 고미숙", Message = "하트좀 보내줘 빨랑...", Time = DateTime.Now, Thumbnail = "/Images/kko.png", NewMessages = 4 });
            source.Add(new TalkData { DisplayMembers = "이재웅, 장대웅", Message = "ㅋㅋ 어제 그래가지고... 어떻게 됐냐면 ㅎㅎ 그.. ", Time = DateTime.Now, Thumbnail = "/Images/kko.png", NewMessages = 1 });
            return source;
        }
    }
}