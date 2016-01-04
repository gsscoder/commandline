// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See License.md in the project root for license information.

using System;
using System.Resources;

namespace CommandLine
{
    /// <summary>
    /// Models a verb command specification.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
    public sealed class VerbAttribute : Attribute
    {
        private readonly string name;
        private string helpText;
        private Type resourceType;
        private string resourceName;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLine.VerbAttribute"/> class.
        /// </summary>
        /// <param name="name">The long name of the verb command.</param>
        /// <exception cref="System.ArgumentException">Thrown if <paramref name="name"/> is null, empty or whitespace.</exception>
        public VerbAttribute(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name");

            this.name = name;
            this.helpText = string.Empty;
        }

        /// <summary>
        /// Gets the verb name.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Gets or sets a short description of this command line option. Usually a sentence summary. 
        /// </summary>
        public string HelpText
        {
            get { return helpText; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                helpText = value;
            }
        }

        /// <summary>
        /// Gets or sets the resource type to use for error message lookups.
        /// </summary>
        public Type ResourceType
        {
            get { return resourceType; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                resourceType = value;
            }
        }

        /// <summary>
        /// Gets or sets the resource name to use as the key for lookups on the resource type.
        /// </summary>
        public string ResourceName
        {
            get { return resourceName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                resourceName = value;
            }
        }

        /// <summary>
        /// Gets the help text string based on <see cref="HelpText"/> or <see cref="ResourceName"/> (in <see cref="ResourceType"/>), whatever is set.
        /// </summary>
        /// <remarks>
        /// It is illegal to set both <see cref="HelpText"/> and <see cref="ResourceName"/> at the same time. Also it is illegal to set none of them.
        /// If <see cref="ResourceType"/> is set, then <see cref="ResourceName"/> must be set also.
        /// </remarks>
        /// <exception cref="InvalidOperationException">If both <see cref="HelpText"/> and <see cref="ResourceName"/> are set at the same time.</exception>
        /// <exception cref="InvalidOperationException">If both <see cref="HelpText"/> and <see cref="ResourceName"/> are not set. </exception>
        /// <exception cref="InvalidOperationException">If <see cref="ResourceType"/> is set and <see cref="ResourceName"/> is not set. </exception>
        public string HelpTextString
        {
            get
            {
                var helpTextSet = !string.IsNullOrEmpty(helpText);
                var resourceTypeSet = resourceType != null;
                var resourceNameSet = !string.IsNullOrEmpty(resourceName);

                // Both HelpText and ResourceName are set -> illegal
                if (!helpTextSet && !resourceNameSet)
                {
                    throw new InvalidOperationException("Both HelpText and ResourceName cannot set at the same time.");
                }

                // Both HelpText and ResourceName ar e not set -> illegal
                if (!helpTextSet && !resourceNameSet)
                {
                    throw new InvalidOperationException("Either HelpText or ResourceName must be set.");
                }

                // If ResourceType is set, then ResourceName must be set also
                if (resourceTypeSet && !resourceNameSet)
                {
                    throw new InvalidOperationException("If ResourceType is set, then ResourceName must be set also.");
                }

                if (helpTextSet)
                {
                    // return helpText
                    return helpText;
                }
                else
                {
                    // return resource string
                    ResourceManager rm = new ResourceManager(resourceType);
                    return rm.GetString(resourceName);
                }
            }
        }
    }
}