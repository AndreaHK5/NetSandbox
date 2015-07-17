using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.BusinessLayer {
    /// <summary>
    /// Types of access for the implementation (refer to config file).
    /// </summary>
    public enum AccessType : byte {
        Mock = 0,
        Persistance = 1,
    }
}
