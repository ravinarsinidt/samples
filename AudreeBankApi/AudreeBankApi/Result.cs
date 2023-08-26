using System.Collections.Generic;

namespace AudreeBankApi
{
    public class AudreeResult
    {
        public int Code { get; set; }
        public List<string> Errors  { get; set; }
        public object Data { get; set; }
        public int MyProperty { get; set; }
    }
}
