namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        public ServiceResponse() { Success = true; }

        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}