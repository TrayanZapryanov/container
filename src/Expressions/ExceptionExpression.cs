﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Unity.Expressions
{
    public class ExceptionExpression
    {
        public static readonly ConstructorInfo InvalidOperationExceptionCtor =
            typeof(InvalidOperationException)
                .GetTypeInfo()
                .DeclaredConstructors
                .First(c =>
                {
                    var parameters = c.GetParameters();
                    return 2 == parameters.Length &&
                           typeof(string) == parameters[0].ParameterType &&
                           typeof(Exception) == parameters[1].ParameterType;
                });
    }
}
