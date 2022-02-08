using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Reflection;
using System.Security.Cryptography.Xml;

namespace Shared.Infrastructure
{
    //class will be responsible for adding controllers that are in different projects.
    //We will have to register this class into the service container of our host ASP.NET Core application.

    	//Shared.Infrastructure should have a reference to Shared.Core
   

    internal class InternalControllerFeatureProvider: ControllerFeatureProvider
    {
        protected override bool IsController(TypeInfo typeInfo)
        {
            if (!typeInfo.IsClass)
            {
                return false;
            }
            if (typeInfo.IsAbstract)
            {
                return false;
            }
            if (typeInfo.ContainsGenericParameters)
            {
                return false;
            }
            if (typeInfo.IsDefined(typeof(NonControllerAttribute)))
            {
                return false;
            }
            return typeInfo.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase) ||
            typeInfo.IsDefined(typeof(ControllerAttribute));
        }

    }
}
