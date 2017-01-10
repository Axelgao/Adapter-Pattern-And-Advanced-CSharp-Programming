using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4VTNZ
{
    public class VTNZ : TestingStation
    {
        private string _email;
        private List<IService> _serviceList;


        public VTNZ(string _stationTitle, string _stationAddress, string _stationHours, string email):base(_stationTitle, _stationAddress, _stationHours)
        {
            _serviceList = new List<IService>();
            _email = email;
        }

        public List<IService> ServiceList
        {
            get
            {
                return _serviceList;
            }
        }

        public override string ShowStationDetails()
        {
            return base.StationTitle + Environment.NewLine + base.StationAddress + Environment.NewLine + base.StationHours;
        }

        public void AddList(IService service)
        {
            _serviceList.Add(service);
        }
    }
}