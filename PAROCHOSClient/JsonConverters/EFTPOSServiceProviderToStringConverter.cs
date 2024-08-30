using PAROCHOSClient;
using Newtonsoft.Json;
using System.Collections.Generic;

/// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="EFTPOSServiceProvider"/> to <see cref="string"/>
public class EFTPOSServiceProviderToStringConverter : BaseEnumToStringJsonConverter<EFTPOSServiceProvider>
{
    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public EFTPOSServiceProviderToStringConverter() : base()
    {

    }

    #endregion

    #region Protected Methods

    /// <inheritdoc/>
    protected override IReadOnlyDictionary<EFTPOSServiceProvider, string> GetMapper() => PAROCHOSClientConstants.EFTPOSServiceProviderToStringMapper;

    #endregion
}