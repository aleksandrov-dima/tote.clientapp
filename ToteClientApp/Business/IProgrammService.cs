using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToteClientApp.Business;
public interface IProgrammService
{
    Task<SearchResultSet> SearchShows(string searchQuery, string nextPageToken, uint maxResult, CancellationToken ct);
}
