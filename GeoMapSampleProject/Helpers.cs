using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Maps = Infragistics.Controls.Maps;

namespace GeoMapSampleProject
{
    public class LocalMapImagery : Maps.GeographicMapImagery
    {
        public LocalMapImagery(string path) : base(new LocalMapTileSource(path)) { }
    }

    public class LocalMapTileSource : Maps.XamMultiScaleTileSource
    {
        private readonly string _originalPath;

        public LocalMapTileSource(string path) : base(3033, 3033, 256, 256, 0)
        {
            _originalPath = path + @"\Tiles\{Z}\{X}\{Y}.png";
        }

        protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, System.Collections.Generic.IList<object> tileImageLayerSources)
        {
            var zoom = tileLevel - 8;
            var invY = (int)Math.Pow(2.0, zoom) - tilePositionY - 1;
            if (zoom > 0)
            {
                var uriString = _originalPath;
                uriString = uriString.Replace("{Z}", zoom.ToString());
                uriString = uriString.Replace("{X}", tilePositionX.ToString());
                uriString = uriString.Replace("{Y}", invY.ToString());
                tileImageLayerSources.Add(new Uri(uriString));
            }
        }
    }

    public class SnowDepthData : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public SnowDepthData(XContainer element)
        {
            try
            {
                var gps = element.Element("GPS");
                if (gps != null)
                {
                    Latitude = double.Parse(GetAttribute(gps, "lat"));
                    Longitude = double.Parse(GetAttribute(gps, "lon"));
                }

                TimeStamp = GetChildElement(element, "TimeStamp");
                SeaLevel = int.Parse(GetChildElement(element, "SeaLevel"));
                SnowHeight = double.Parse(GetChildElement(element, "SnowHeight"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Latitude = 0;
                Longitude = 0;
                TimeStamp = "";
                SeaLevel = 0;
                SnowHeight = 0;
            }
        }

        #region Properties
        private string _timeStamp { get; set; }
        public string TimeStamp
        {
            get => _timeStamp;
            set
            {
                _timeStamp = value;
                OnPropertyChanged();
            }
        }

        private int _seaLevel { get; set; }
        public int SeaLevel
        {
            get => _seaLevel;
            set
            {
                _seaLevel = value;
                OnPropertyChanged();
            }
        }

        private double _snowHeight { get; set; }
        public double SnowHeight
        {
            get => _snowHeight;
            set
            {
                _snowHeight = value;
                OnPropertyChanged();
            }
        }

        private double _latitude { get; set; }
        public double Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }

        private double _longitude { get; set; }
        public double Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Private Methods
        private static string GetAttribute(XElement element, string attributeName)
        {
            var att = element.Attribute(attributeName);
            return att != null ? att.Value : "";
        }

        private static string GetChildElement(XContainer element, string elementName)
        {
            var el = element.Element(elementName);
            return el != null ? el.Value : "";
        }
        #endregion
    }
}
