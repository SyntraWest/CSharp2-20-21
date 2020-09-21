using System;
using HtmlAgilityPack;

namespace VoorbeeldHtmlParsen
{
    class Program
    {
        /// <summary>
        /// Haal een lijst van links op uit de hoofdpagina van de Nederlandstalige wikipedia.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var htmlDoc = web.Load(@"https://nl.wikipedia.org/wiki/Hoofdpagina");

            var docNode = htmlDoc.DocumentNode;

            var htmlNode = ZoekEersteChildMetNaam(docNode, "html");
            var body = ZoekEersteChildMetNaam(htmlNode, "body");
            var div = ZoekEersteChildMetNaamEnId(body, "div", "mw-navigation");
            div = ZoekEersteChildMetNaamEnId(div, "div", "mw-panel");
            div = ZoekEersteChildMetNaamEnId(div, "nav", "p-navigation");
            div = ZoekEersteChildMetNaam(div, "div");
            var ul = ZoekEersteChildMetNaam(div, "ul");
            
            // overloop alle list items
            foreach(var li in ul.ChildNodes)
            {
                var link = ZoekEersteChildMetNaam(li, "a");
                Console.WriteLine($"{link.InnerText} ==> {link.Attributes["href"].Value}");
            }
        }

        static HtmlNode ZoekEersteChildMetNaam(HtmlNode parentNode, string nodeNaam)
        {
            foreach (var node in parentNode.ChildNodes)
            {
                if (node.Name == nodeNaam)
                {
                    return node;
                }
            }
            return null;
        }
        static HtmlNode ZoekEersteChildMetNaamEnId(HtmlNode parentNode, string nodeNaam, string nodeId)
        {
            foreach (var node in parentNode.ChildNodes)
            {
                if (node.Name == nodeNaam && node.Id == nodeId)
                {
                    return node;
                }
            }
            return null;
        }
    }
}
