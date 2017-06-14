using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NativeEmbedding
{
    public class RegisteredDevicesViewModel
    {
        public IList<RegisteredDevice> Devices { get; set; }
        public RegisteredDevicesViewModel()
        {
            var repository = new RegisteredDevicesRepository();
            var devices = repository.Devices.OrderBy(x => x.UserName).ToList();
            Devices = new ObservableCollection<RegisteredDevice>(devices);
        }
    }
}

