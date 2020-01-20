public class SmartHomeResponse
    {
        public string requestId { get; set; }
        public Payload payload { get; set; }
    }

public class Payload
    {
        public string agentUserId { get; set; }

        public List<Device> devices { get; set; }
    }

public class Device
    {
        public string id { get; set; }

        public string type { get; set; }

        public List<string> traits { get; set; }

        public DeviceName name { get; set; }

        public bool willReportState { get; set; }

        public ThermostatAttributes attributes { get; set;}
    }

public class DeviceName
    {
        public List<string> defaultNames { get; set; }

        public string name { get; set; }
    }

public class ThermostatAttributes
    {
        public string availableThermostatModes { get; set; }
        
        public string thermostatTemperatureUnit { get; set; }

        public ThermostatTemperatureRange thermostatTemperatureRange { get; set; }

        public bool commandOnlyTemperatureSetting { get; set; }
    }

    public class ThermostatTemperatureRange
    {
        public float minThresholdCelsius { get; set; }
        public float maxThresholdCelsius { get; set; }
    }
