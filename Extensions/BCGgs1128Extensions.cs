using BarcodeBakery.Common.GS1;

namespace BarcodeBakery.Barcode
{
    /// <summary>
    /// Extensions for the barcode GS1-128.
    /// </summary>
    public static class BCGgs1128Extensions
    {
        /// <summary>
        /// Installs the default well known Application Identifiers from GS1.
        /// </summary>
        /// <param name="code">The GS1-128 instance.</param>
        public static void InstallDefaultApplicationIdentifiers(this BCGgs1128 code)
        {
            code.SetApplicationIdentifiers(GS1AI.GetDefaultAIData());
        }
    }
}
