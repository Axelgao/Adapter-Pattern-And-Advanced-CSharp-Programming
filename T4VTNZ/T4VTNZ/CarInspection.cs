using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4VTNZ
{
    public class CarInspection
    {
        private string _serviceTitle;
        private decimal _servicePrice;

        public CarInspection()
        {
        }

        public CarInspection(string title, decimal price)
        {
            _serviceTitle = title;
            _servicePrice = price;
        }

        public string ServiceTitle
        {
            get
            {
                return _serviceTitle;
            }

            set
            {
                _serviceTitle = value;
            }
        }

        public decimal ServicePrice
        {
            get
            {
                return _servicePrice;
            }

            set
            {
                _servicePrice = value;
            }
        }
    }
}