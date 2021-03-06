﻿using RepoDb.Attributes;
using RepoDb.Interfaces;
using System;
using System.Reflection;

namespace RepoDb.Resolvers
{
    /// <summary>
    /// A class that is used to resolve the equivalent property handler object of the property.
    /// </summary>
    public class PropertyHandlerPropertyLevelResolver : IResolver<Type, PropertyInfo, object>
    {
        /// <summary>
        /// Creates a new instance of <see cref="PropertyHandlerPropertyLevelResolver"/> object.
        /// </summary>
        public PropertyHandlerPropertyLevelResolver() { }

        /// <summary>
        /// Resolves the equivalent property handler object of the property.
        /// </summary>
        /// <param name="entityType">The type of the data entity.</param>
        /// <param name="propertyInfo">The instance of <see cref="PropertyInfo"/> to be resolved.</param>
        /// <returns>The equivalent property handler object of the property.</returns>
        public object Resolve(Type entityType,
            PropertyInfo propertyInfo)
        {
            var propertyHandler = (object)null;

            // Attribute
            var attribute = propertyInfo.GetCustomAttribute<PropertyHandlerAttribute>();
            if (attribute != null)
            {
                propertyHandler = Converter.ToType<object>(Activator.CreateInstance(attribute.HandlerType));
            }

            // Property Level
            if (propertyHandler == null)
            {
                propertyHandler = PropertyHandlerMapper.Get<object>(entityType, propertyInfo);
            }

            // Type Level
            if (propertyHandler == null)
            {
                propertyHandler = PropertyHandlerMapper.Get<object>(propertyInfo.PropertyType);
            }

            // Return the value
            return propertyHandler;
        }
    }
}
