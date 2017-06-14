using System.Collections.Generic;

namespace NativeEmbedding
{
    public class RegisteredDevicesRepository
    {
        public IList<RegisteredDevice> Devices { get; set; }

        public RegisteredDevicesRepository()
        {
            Devices = new List<RegisteredDevice>()
            {
                new RegisteredDevice()
                {
                    UserName = "Rob Gibbens",
                    Platform = "iOS",
                    Version = "11"
                },
                new RegisteredDevice()
                {
                    UserName = "Jason DeBoever",
                    Platform = "Windows",
                    Version = "10"
                },
                new RegisteredDevice()
                {
                    UserName = "Charles Petzold",
                    Platform = "Android",
                    Version = "API 24"
                },
                new RegisteredDevice()
                {
                    UserName = "Jesse Dietrichson",
                    Platform = "Windows",
                    Version = "8"
                },
                new RegisteredDevice()
                {
                    UserName = "Rene Ruppert",
                    Platform = "iOS",
                    Version = "10.3"
                },
            };
        }
    }
}
