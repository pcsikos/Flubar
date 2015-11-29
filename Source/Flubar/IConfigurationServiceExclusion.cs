﻿using System;
using System.Collections.Generic;

namespace Flubar
{
    public interface IConfigurationServiceExclusion
    {
        IConfigurationServiceExclusion Exclude(IRegistrationEntry registration);
        IConfigurationServiceExclusion Exclude(IEnumerable<IRegistrationEntry> registrations);
        //ITypeExclusion Exclude(Type serviceType, Type implementationType);
        //ITypeExclusion Exclude(IEnumerable<Type> serviceTypes, Type implementationType);
        IConfigurationServiceExclusion Exclude(Type serviceType);
        IConfigurationServiceExclusion Exclude(IEnumerable<Type> serviceTypes);
    }
}