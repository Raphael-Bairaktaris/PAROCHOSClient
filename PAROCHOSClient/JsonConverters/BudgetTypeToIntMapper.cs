using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAROCHOSClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="BudgetType"/> to <see cref="string"/>
    /// </summary>
    public class BudgetTypeToIntMapper : BaseEnumToIntJsonConverter<BudgetType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BudgetTypeToIntMapper() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BudgetType, int> GetMapper() => PAROCHOSClientConstants.BudgetTypeToIntMapper;

        #endregion
    }
}
