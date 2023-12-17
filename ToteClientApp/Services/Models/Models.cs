using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToteClientApp.Services.Models;
public partial record ProgrammDetailsData(
    string? Id,
    string? ImgUrl,
    SnippetData? Snippet
    );


public record ProgramDetailsResultData(ImmutableList<ProgrammDetailsData>? Items);

public record SnippetData(string? ChannelId, string? Title, string? Description, string? ChannelTitle, DateTime? Start);
