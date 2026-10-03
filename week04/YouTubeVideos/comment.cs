public class Comment
{
    public string PersonComment { get; set; }
    public string CommentContent { get; set; }

    public Comment(string name, string text)
    {
        PersonComment = name;
        CommentContent = text;
    }
}