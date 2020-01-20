public class SmartHomeRequest
    {
        public string requestId { get; set; }
        public List<RequestInput> inputs { get; set; }

        public SmartHomeRequest()
        {
            inputs = new List<RequestInput>();
        }
    }
public class RequestInput
    {
        public string intent { get; set; }
    }
