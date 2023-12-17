using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToteClientApp.Services.Models;

namespace ToteClientApp.Business.Models;

public partial record SearchResultItem(ProgrammDetailsData Details)
{
    public string? Id => Details.Id;

    private const long Thousand = 1_000;
    private const long Million = Thousand * Thousand;

    private static string FormatLongNumber(long number) =>
        number switch
        {
            >= Million => (number / Million).ToString("0.##") + "M",
            >= Thousand => (number / Thousand).ToString("0.##") + "K",
            _ => number.ToString()
        };

    private static string ToFriendlyString(TimeSpan elapsedTime)
    {
        double minutesElapsed = elapsedTime.TotalMinutes;

        var result = minutesElapsed switch
        {
            < 0.75 => "less than a minute",
            < 1.5 => "about a minute",
            < 45 => $"{Math.Round(minutesElapsed)} minutes",
            < 90 => "about an hour",
            < 60 * 24 => $"about {Math.Round(Math.Abs(elapsedTime.TotalHours))} hours",
            < 60 * 48 => "a day",
            < 60 * 24 * 30 => $"{Math.Floor(Math.Abs(elapsedTime.TotalDays))} days",
            < 60 * 24 * 60 => "about a month",
            < 60 * 24 * 365 => $"{Math.Floor(Math.Abs(elapsedTime.TotalDays / 30))} months",
            < 60 * 24 * 365 * 2 => "about a year",
            _ => $"{Math.Floor(Math.Abs(elapsedTime.TotalDays / 365))} years"
        };

        return $"{result} ago";
    }
}

public record SearchResultSet(IImmutableList<SearchResultItem> ResultItems, string NextPageToken)
{
    public static SearchResultSet CreateEmpty() => new(ImmutableList.Create<SearchResultItem>(), string.Empty);
}
