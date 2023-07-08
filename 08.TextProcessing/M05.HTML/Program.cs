string title = Console.ReadLine();
string content = Console.ReadLine();
string comments = "";
List<string> commentList = new List<string>();
while ((comments = Console.ReadLine()) != "end of comments")
{
    commentList.Add(comments);
}

Console.WriteLine("<h1>");
Console.WriteLine($"{title.PadLeft(5)}");
Console.WriteLine("</h1>");
Console.WriteLine("<article>");
Console.WriteLine($"{content.PadLeft(5)}");
Console.WriteLine("</article>");
foreach (string comment in commentList)
{
    Console.WriteLine("<div>");
    Console.WriteLine($"{comment.PadLeft(5)}");
    Console.WriteLine("</div>");
}
