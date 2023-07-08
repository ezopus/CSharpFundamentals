string title = Console.ReadLine();
string content = Console.ReadLine();
string comments = "";
List<string> commentList = new List<string>();
while ((comments = Console.ReadLine()) != "end of comments")
{
    commentList.Add(comments);
}

Console.WriteLine("<h1>");
Console.WriteLine($"\t{title.PadLeft(5)}");
Console.WriteLine("</h1>");
Console.WriteLine("<article>");
Console.WriteLine($"\t{content.PadLeft(5)}");
Console.WriteLine("</article>");
foreach (string comment in commentList)
{
    Console.WriteLine("<div>");
    Console.WriteLine($"\t{comment.PadLeft(5)}");
    Console.WriteLine("</div>");
}
