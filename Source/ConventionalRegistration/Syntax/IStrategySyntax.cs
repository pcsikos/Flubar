﻿using System;
using System.Collections.Generic;
using ConventionalRegistration.RegistrationProducers;

namespace ConventionalRegistration.Syntax
{
    /// <summary>
    /// Provides methods to select the interface selection strategy.
    /// </summary>
    public interface IStrategySyntax
    {
        IRegisterSyntax UsingSelfRegistrationStrategy();
        IRegisterSyntax UsingSingleInterfaceStrategy();
        IRegisterSyntax UsingSingleInterfaceStrategy(IEnumerable<Type> excluding);
        IRegisterSyntax UsingDefaultInterfaceStrategy();
        IRegisterSyntax UsingAllInterfacesStrategy();
        IRegisterSyntax UsingAllInterfacesStrategy(IEnumerable<Type> excluding);
        IRegisterSyntax UsingStrategy(IRegistrationProducer registrationProducer);
    }
}
