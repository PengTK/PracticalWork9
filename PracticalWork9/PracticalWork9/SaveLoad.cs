using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork9
{
    internal class SaveLoad
    {
        public static List<Hotkey> Load()
        {
            List<Hotkey> Hotkeys;
            if (File.Exists("C:\\Users\\Den\\Desktop\\Hotkeys.json"))
            {
                string Text = File.ReadAllText("C:\\Users\\Den\\Desktop\\Hotkeys.json");
                Hotkeys = JsonConvert.DeserializeObject<List<Hotkey>>(Text);
                return Hotkeys;
            }
            else return null;
        }
        public static void Save(List<Hotkey> hotkeys)
        {
            string json = JsonConvert.SerializeObject(hotkeys);
            File.WriteAllText("C:\\Users\\Den\\Desktop\\Hotkeys.json", json);
        }
    }
}
