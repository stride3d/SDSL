using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

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
            var ns = sf.Namespaces[0];
            if (ns.Intersects(request.Position))
            {
                _logger.LogInformation($"{request.Position} intersects with {ns.Namespace}");
                return new Hover
                {
                    Contents = new($"{ns.Namespace}", "This is a namespace")
                };
            }
            else
            {
                return new Hover
                {
                    Contents = new("Shader file", $"You're hovering over a shader file at {request.Position}\nAnd Namespace is at l{ns.Info.Line}-c{ns.Info.Column}")
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
}