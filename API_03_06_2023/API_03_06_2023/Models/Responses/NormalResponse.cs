namespace API_03_06_2023.Models.Responses
{
    public class NormalResponse<T>
    {
        public ServerInfo ServerInfo { get; set; }
        public T? ServerResponse { get; set; }

        public NormalResponse()
        {
            ServerInfo = new();
        }
    }
}
