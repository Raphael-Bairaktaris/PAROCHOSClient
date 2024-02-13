using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
        /// <summary>
        /// The base for all the <see cref="JsonConverter{T}"/>s that are used for converting between an <see cref="Enum"/> and a <see cref="string"/>.
        /// </summary>
        public abstract class BaseEnumToStringJsonConverter<T> : BaseEnumToValueJsonConverter<T, string>
            where T : Enum
        {
            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public BaseEnumToStringJsonConverter()
            {

            }

            #endregion
        }
}