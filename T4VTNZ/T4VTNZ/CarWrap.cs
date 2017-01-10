using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4VTNZ
{
    public class CarWrap : IService
    {
        private CarInspection _carInspection;

        public CarWrap()
        {
            _carInspection = new CarInspection();
        }

        public CarWrap(string title, decimal price)
        {
            _carInspection = new CarInspection();
            _carInspection.ServiceTitle = title;
            _carInspection.ServicePrice = price;
        }

        public string ServiceDetails
        {
            get
            {
                return _carInspection.ServiceTitle + " " + _carInspection.ServicePrice.ToString("c");
            }
        }

        public decimal ServicePrice
        {
            get
            {
                return _carInspection.ServicePrice;
            }
            set
            {
                _carInspection.ServicePrice = value;
            }
        }

        public string ServiceTitle
        {
            get
            {
                return _carInspection.ServiceTitle;
            }
            set
            {
                _carInspection.ServiceTitle = value;
            }

        }
    }
}