using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4VTNZ
{
    public interface IService
    {
        string ServiceDetails { get; }
        string ServiceTitle { get; set; }
        decimal ServicePrice { get; set; }
    }
}