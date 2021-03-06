﻿using System.Collections.Generic;
using Unity.Builder;

namespace Unity.Policy
{
    /// <summary>
    /// An <see cref="IBuilderPolicy"/> that will examine the given
    /// types and return a sequence of <see cref="System.Reflection.MethodInfo"/> objects
    /// that should be called as part of building the object.
    /// </summary>
    public interface IMethodSelectorPolicy 
    {
        /// <summary>
        /// Return the sequence of methods to call while building the target object.
        /// </summary>
        /// <param name="context">Current build context.</param>
        /// <returns>Sequence of methods to call.</returns>
        IEnumerable<object> SelectMethods<TBuilderContext>(ref TBuilderContext context)
            where TBuilderContext : IBuilderContext;
    }
}
