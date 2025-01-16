using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.LSP;



public class HoverHandler(ILogger<HoverHandler> logger) : HoverHandlerBase
{

    ILogger<HoverHandler> _logger = logger;
    public override async Task<Hover?> Handle(HoverParams request, CancellationToken cancellationToken)
    {
        var content = MonoGamePreProcessor.Run(
            await File.ReadAllTextAsync(DocumentUri.GetFileSystemPath(request.TextDocument.Uri) ?? "", cancellationToken).ConfigureAwait(false), 
            Path.GetFileName(DocumentUri.GetFileSystemPath(request.TextDocument.Uri))!
        );
        var result = SDSLParser.Parse(content);
        if (result.AST is ShaderFile sf && sf.Namespaces.Count > 0)
        {
            if(ComputeIntersection(request.Position, sf, out var description))
            {
                _logger.LogInformation($"Found description");
                return new Hover
                {
                    Contents = new(description)
                };
            }
        }
        return null;
    }

    protected override HoverRegistrationOptions CreateRegistrationOptions(HoverCapability capability, ClientCapabilities clientCapabilities)
    {
        return new HoverRegistrationOptions
        {
            DocumentSelector = TextDocumentSelector.ForLanguage("sdsl"),
            WorkDoneProgress = true
        };
    }

    static bool ComputeIntersection(Position position, ShaderFile file, out string description)
    {
        description = "";
        foreach(var ns in file.Namespaces)
        {
            if(ns.Namespace is not null && ns.Namespace.Intersects(position))
            {
                description = ns.Namespace.ToString();
                return true;
            }
            else
            {
                foreach(var decl in ns.Declarations)
                {
                    if(decl is ShaderClass sclass && sclass.Intersects(position))
                    {
                        description = $"shader {sclass.Name}";
                        return true;
                    }
                }
            }
        }
        return false;
    }
}