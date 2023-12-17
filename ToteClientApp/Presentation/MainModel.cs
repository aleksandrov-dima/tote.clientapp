using ToteClientApp.Business;

namespace ToteClientApp.Presentation;

public partial record MainModel(IProgrammService ProgramService)
{
    public IState<string> SearchTerm => State<string>.Value(this, () => "Programm1");

    public IListFeed<SearchResultItem> SearchShowsResults => SearchTerm
        .Where(searchTerm => searchTerm is { Length: > 0 })
        .SelectAsync(async (searchTerm, ct) =>
            await ProgramService.SearchShows(searchTerm, nextPageToken: string.Empty, maxResult: 30, ct))
        .Select(result => result.ResultItems)
        .AsListFeed();
}
