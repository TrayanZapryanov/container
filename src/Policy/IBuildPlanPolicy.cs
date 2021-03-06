﻿using Unity.Builder;

namespace Unity.Policy
{
    /// <summary>
    /// A build plan is an object that, when invoked, will create a new object
    /// or fill in a given existing one. It encapsulates all the information
    /// gathered by the strategies to construct a particular object.
    /// </summary>
    public interface IBuildPlanPolicy 
    {
        /// <summary>
        /// Creates an instance of this build plan's type, or fills
        /// in the existing type if passed in.
        /// </summary>
        /// <param name="context">Context used to build up the object.</param>
        void BuildUp<TBuilderContext>(ref TBuilderContext context)
            where TBuilderContext : IBuilderContext;
    }
}
