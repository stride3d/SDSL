using CommunityToolkit.HighPerformance.Buffers;

namespace Stride.Shaders.Parsing.SDSL.PreProcessing.Macros;

public struct CommentPhase() : IPreProcessorPhase
{
    public readonly SDSLPreProcessor Apply(SDSLPreProcessor sdslpp)
    {
        var frame = new CodeFrame();
        var last = sdslpp.CodeFrames[^1];
        var scanner = new Scanner(last.Code.ToString());
        var started = false;
        while(!scanner.MatchUntilAny(["//", "/*"]))
        {
            if(!started)
                started = true;
            frame.Add(last, ..scanner.Position);
            if (scanner.Match("//"))
                scanner.MatchUntil('\n', advance: true);
            else if (scanner.Match("/*"))
                scanner.MatchUntil("*/", advance: true);
        }
        if (!started)
            frame.Add(last, ..);
        return sdslpp;
    }
}
