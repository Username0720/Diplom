using AngleSharp.Html.Dom;

namespace Grants.Parser
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
