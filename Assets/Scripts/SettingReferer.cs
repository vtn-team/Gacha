using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SettingReferer
{
    static SettingReferer _instance = new SettingReferer();
    static public SettingReferer Instance { get { return _instance; } } 
    private SettingReferer() { }


    public NotionSetting Setting;
}
