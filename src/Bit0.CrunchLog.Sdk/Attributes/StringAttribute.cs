using System;

namespace Bit0.CrunchLog.Attributes
{
    /// <summary>
    /// Add string meta data to <see cref="Enum"/> fields.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class StringAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance of <see cref="StringAttribute"/> class
        /// </summary>
        /// <param name="value">String value of <see cref="Enum"/> field</param>
        public StringAttribute(String value)
        {
            Value = value;
        }

        /// <summary>
        /// String value of <see cref="Enum"/> field
        /// </summary>
        public String Value { get; set; }
    }
}