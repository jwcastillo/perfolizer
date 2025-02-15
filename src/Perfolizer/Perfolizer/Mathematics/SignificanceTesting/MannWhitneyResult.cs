using Perfolizer.Common;
using Perfolizer.Mathematics.Common;
using Perfolizer.Mathematics.SignificanceTesting.Base;
using Perfolizer.Mathematics.Thresholds;

namespace Perfolizer.Mathematics.SignificanceTesting;

public class MannWhitneyResult : SignificanceTwoSampleResult
{
    public double Ux { get; }
    public double Uy { get; }

    public MannWhitneyResult(Sample x, Sample y, Threshold threshold, AlternativeHypothesis alternativeHypothesis, Probability pValue,
        double ux, double uy)
        : base(x, y, threshold, alternativeHypothesis, pValue)
    {
        Ux = ux;
        Uy = uy;
    }

    public override string ToString() => $"{nameof(Ux)}: {Ux}, {nameof(Uy)}: {Uy}, {base.ToString()}";
}