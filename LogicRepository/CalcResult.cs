namespace WebCalc.LogicRepository
{
    public class CalcResult
    {
        public CalcResult(bool isOk, string result)
        {
            IsOk = isOk;
            Result = result;
        }
        public bool IsOk { get; set; }
        public string Result { get; set; }
    }
}
