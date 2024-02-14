using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="DateOnly"/> to <see cref="string"/>
    /// </summary>
    public class DateOnlyToStringJsonConverter : BaseFormattableValueToStringJsonConverter<DateOnly>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing and deserializing dates
        /// </summary>
        public const string DateFormat = "yyyy-MM-dd";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateOnlyToStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override string GetFormat() => DateFormat;

        #endregion
    }
}
