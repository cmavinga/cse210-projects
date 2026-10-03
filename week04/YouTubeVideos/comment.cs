public class Comment
{
    public string personComment { get; set; }
    public string CommentContent { get; set; }

    public Comment(string name, string text)
    {
        personComment = name;
        CommentContent = text;
    }
}