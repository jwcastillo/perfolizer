using Perfolizer.Mathematics.Common;

namespace Perfolizer.Common;

internal static class DoubleExtensions
{
    public static string ToStringInvariant(this double value) => value.ToString(DefaultCultureInfo.Instance);
    public static string ToStringInvariant(this double value, string format) => value.ToString(format, DefaultCultureInfo.Instance);

    public static string ToStringInvariant(this Probability p) => p.ToString(DefaultCultureInfo.Instance);
    public static string ToStringInvariant(this Probability p, string format) => p.ToString(format, DefaultCultureInfo.Instance);
}