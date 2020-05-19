namespace TestApplication.Exceptions
{
    public class UnluckyException:AppException
    {
        public override string code => "unlucky_exception";
        public UnluckyException(string msg) : base(msg)
        {
        }

      
    }
}