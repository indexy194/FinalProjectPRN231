namespace FinalProjectPRN231.API.DTO.Common
{
    public class ResponseDTO<T>
    {
        public ResponseDTO()
        {
            Errors = new List<ResponseError>();
        }
        public ResponseDTO(T data)
        {
            Data = data;
        }
        public ResponseDTO(int code, string message)
        {
            Code = code;
            Message = message;
        }
        public int Code { get; set; } = (int)RESPONSE_CODE.OK;
        public string Message { get; set; } 
        public IList<ResponseError> Errors { get; set; }
        public T Data { get; set; }
    }
    public class ResponseError
    {

        public int Code { get; set; }
        public string Message { get; set; }
        public string Field { get; set; }
    }
    public enum RESPONSE_CODE
    {
        OK = 200,
        Created = 201,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500
    }
}
