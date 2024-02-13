using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="FuelCodeCategoryType"/> to <see cref="int"/>
    /// </summary>
    public class FuelCodeCategoryTypeToIntMapper : BaseEnumToIntJsonConverter<FuelCodeCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FuelCodeCategoryTypeToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FuelCodeCategoryType, int> GetMapper() => PAROCHOSClientConstants.FuelCodeCategoryTypeToIntMapper;

        #endregion
    }
}
