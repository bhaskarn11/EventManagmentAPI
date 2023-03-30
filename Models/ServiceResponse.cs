namespace EventManagment.Models
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(T data, bool susscess)
        {
            Data = data;
            Success = susscess;
        }

        public ServiceResponse()
        {
        }

        public T? Data { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; } = "";
    }
}
