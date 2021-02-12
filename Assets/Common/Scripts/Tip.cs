﻿using System;

namespace Common.Scripts {
    [Serializable]
    public class Tip {
        public string header;
        public string title;
        public string content;

        public static Tip[] Serialize(string jsonString) {
            return JsonHelper.FromJson<Tip>(jsonString);
        }

    }
}
