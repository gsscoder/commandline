// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See License.md in the project root for license information.

using System;
using System.Resources;

namespace CommandLine
{
    /// <summary>
    /// Models a base attribute to define command line syntax.
    /// </summary>
    public abstract class BaseAttribute : Attribute
    {
        private int min;
        private int max;
        private object @default;
        private string helpText;
        private Type resourceType;
        private string resourceName;
        private string metaValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLine.BaseAttribute"/> class.
        /// </summary>
        protected internal BaseAttribute()
        {
            min = -1;
            max = -1;
            helpText = string.Empty;
            metaValue = string.Empty;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a command line option is required.
        /// </summary>
        public bool Required
        {
            get;
            set;
        }

        /// <summary>
        /// When applied to <see cref="System.Collections.Generic.IEnumerable{T}"/> properties defines
        /// the lower range of items.
        /// </summary>
        /// <remarks>If not set, no lower range is enforced.</remarks>
        public int Min
        {
            get { return min; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value");
                }

                min = value;
            }
        }

        /// <summary>
        /// When applied to <see cref="System.Collections.Generic.IEnumerable{T}"/> properties defines
        /// the upper range of items.
        /// </summary>
        /// <remarks>If not set, no upper range is enforced.</remarks>
        public int Max
        {
            get { return max; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value");
                }

                max = value;
            }
        }

        /// <summary>
        /// Gets or sets mapped property default value.
        /// </summary>
        public object Default
        {
            get { return @default; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                @default = value;
            }
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
<<<<<<< HEAD
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

=======
>>>>>>> master
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
<<<<<<< HEAD
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

=======
        public string MergedHelpText
        {
            get
            {
                var resourceTypeSet = resourceType != null;
                var resourceNameSet = !string.IsNullOrEmpty(resourceName);

>>>>>>> master
                // If ResourceType is set, then ResourceName must be set also
                if (resourceTypeSet && !resourceNameSet)
                {
                    throw new InvalidOperationException("If ResourceType is set, then ResourceName must be set also.");
                }

<<<<<<< HEAD
                if (helpTextSet)
=======
                if (!resourceTypeSet)
>>>>>>> master
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

        /// <summary>
        /// Gets or sets mapped property meta value. Usually an uppercase hint of required value type.
        /// </summary>
        public string MetaValue
        {
            get { return metaValue; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                metaValue = value;
            }
        }
    }
}
