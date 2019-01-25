using System.Collections.ObjectModel;
using System.Xml;
using System.Xml.Linq;

namespace GeoMapSampleProject
{
    public class MainWindowViewModel
    {
        public ObservableCollection<SnowDepthData> SnowPoints { get; } = new ObservableCollection<SnowDepthData>();

        public MainWindowViewModel(string path)
        {
            LoadSnowData(path + @"\SnowDepthExport.xml");
        }

        private void LoadSnowData(string path)
        {
            using (var reader = XmlReader.Create(path))
            {
                reader.ReadStartElement("config");

                while (!reader.EOF)
                {
                    if (reader.Name == "Area")
                    {
                        var el = (XElement)XNode.ReadFrom(reader);
                        SnowPoints.Add(new SnowDepthData(el));
                    }
                    else
                    {
                        reader.Read();
                    }
                }
            }
        }
    }
}
