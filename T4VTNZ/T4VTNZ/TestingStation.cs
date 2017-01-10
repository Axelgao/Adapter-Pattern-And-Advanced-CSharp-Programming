using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4VTNZ
{
    public abstract class TestingStation
    {
        private string _stationTitle;
        private string _stationAddress;
        private string _stationHours;

        public TestingStation(string title, string address, string hours)
        {
            _stationTitle = title;
            _stationAddress = address;
            _stationHours = hours;
        }

        public string StationAddress
        {
            get
            {
                return _stationAddress;
            }

            set
            {
                _stationAddress = value;
            }
        }

        public string StationHours
        {
            get
            {
                return _stationHours;
            }

            set
            {
                _stationHours = value;
            }
        }

        public string StationTitle
        {
            get
            {
                return _stationTitle;
            }

            set
            {
                _stationTitle = value;
            }
        }

        public abstract string ShowStationDetails();
    }
}