using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FinanceTracker
{
    // Class to represent each row in the ListView
    public class ListViewData
    {
        public string Name { get; set; }
        public string Money { get; set; }
    }

    // Helper class to save and load ListView data
    public static class ListViewHelper
    {
        public static void SaveListViewToJSON(ListView listView, string filePath)
        {
            var data = new List<ListViewData>();

            foreach (ListViewItem item in listView.Items)
            {
                data.Add(new ListViewData
                {
                    Name = item.SubItems[0].Text,
                    Money = item.SubItems[1].Text
                });
            }

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void LoadListViewFromJSON(ListView listView, string filePath)
        {
            if (!File.Exists(filePath)) return;

            listView.Items.Clear();
            string json = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<ListViewData>>(json);

            foreach (var row in data)
            {
                ListViewItem item = new ListViewItem(row.Name);
                item.SubItems.Add(row.Money);
                listView.Items.Add(item);
            }
        }
    }
}
