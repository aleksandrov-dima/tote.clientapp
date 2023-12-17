using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using ToteClientApp.Services;
using ToteClientApp.Services.Models;

namespace ToteClientApp.Business;

public class ProgrammServiceMock : IProgrammService
{
    private readonly ProgramDetailsResultData _details;
    //private readonly IDictionary<string, ChannelData> _channels;

    public ProgrammServiceMock(ISerializer serializer)
    {
        _details = new ProgramDetailsResultData(Items: [new("Programm1", "https://snipboard.io/Uj7rFx.jpg", new SnippetData("ChanellID1", "Title1", "Descripton", "ChannelTitle", DateTime.Now))]);

        //var channelsData = serializer.FromString<ChannelSearchResultData>(YoutubeServiceMockData.ChannelData)!;
        //_channels = channelsData.Items!.ToDictionary(channel => channel.Id!, StringComparer.OrdinalIgnoreCase);
    }

    public Task<SearchResultSet> SearchShows(string searchQuery, string nextPageToken, uint maxResult, CancellationToken ct)
    {
        var filtered = _details
            .Items!
            .Where(detail =>
                detail.Id.Contains(searchQuery, StringComparison.OrdinalIgnoreCase));

        var resultItems = filtered
                    .Select(detail => new SearchResultItem(detail))
                    .ToImmutableList();

        var result = new SearchResultSet(resultItems, NextPageToken: string.Empty);

        return Task.FromResult(result);
    }
}
