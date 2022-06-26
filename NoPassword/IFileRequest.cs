namespace AttUssHub.Domain.Interfaces.Requests.Bases
{
    public interface IFileRequest
    {
        string Guid { get; set; }
        string FileName { get; set; }
        byte[] Binary { get; set; }
    }
}
