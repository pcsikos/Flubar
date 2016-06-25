﻿using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flubar.Unity.Tests
{
    internal static class UnityContainerExtensions
    {
        public static void RegisterCollection(this UnityContainer container, Type serviceType, IEnumerable<Type> implementations, LifetimeManager lifetimeManager = null)
        {
            foreach (var impl in implementations)
            {
                container.RegisterType(serviceType, impl, impl.FullName, lifetimeManager ?? new TransientLifetimeManager(), new InjectionMember[0]);
            }
        }
    }
}
