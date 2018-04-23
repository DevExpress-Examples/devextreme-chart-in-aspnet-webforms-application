using System;
using System.Collections;
using System.Collections.Generic;

public class DataHelper {
    private readonly List<string> FeedList;

    public DataHelper() {
        this.FeedList = new List<string>();
        
        this.FeedList.Add("ASP.NET");
        this.FeedList.Add("WinForms");
        this.FeedList.Add("WPF");
        this.FeedList.Add("SL");
        this.FeedList.Add("VCL");
    }

    public IEnumerable GetItems() {
        Random randomizer = new Random();
        List<KBInfo> kbItems = new List<KBInfo>();
        foreach (string name in FeedList) {
            kbItems.Add(new KBInfo() {
                PlatformName = name,
                Count = randomizer.Next(100, 500)
            });
        }
        return kbItems;
    }
}

public class KBInfo {
    public string PlatformName { get; set; }
    public int Count { get; set; }
}