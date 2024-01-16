using System;
namespace BCM.Infrastructure.Dtos
{
	public class ResponseDto
	{
        public bool Status { get; set; }
        public string Message { get; set; }
    }

    public class ResponseDto<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
    }
}

