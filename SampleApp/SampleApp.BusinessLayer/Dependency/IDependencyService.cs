﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.BusinessLayer.Dependency {
    public interface IDependencyService {
        T Resolve<T>();
    }
}
