namespace Management.CSAT.NPS.Domain.Common.v1
{
    public class CustomException : Exception
    {
        public int StatusCode { get; set; }
        public object? Value { get; set; }
    }
}
