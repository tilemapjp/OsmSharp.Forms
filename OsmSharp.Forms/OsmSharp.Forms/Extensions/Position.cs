using OsmSharp.Math.Geo;
using Xamarin.Forms.Maps;

namespace OsmSharp.Forms
{
    public static class PositionExtensions
    {
        public static GeoCoordinate ToGeoCoordinate(this Position pos)
        {
            return new GeoCoordinate(pos.Latitude, pos.Longitude);
        }
    }
}
