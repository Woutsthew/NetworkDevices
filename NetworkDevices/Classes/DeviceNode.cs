using System.Collections.Generic;

namespace NetworkDevices.Classes
{
    public class DeviceNode
    {
        public string fileName { get; set; }

        public List<DeviceNode> deviceNodes { get; set; }

        public List<Device> devices { get; set; }

        public DeviceNode(string fileName, List<DeviceNode> deviceNode, List<Device> device)
        {
            this.fileName = fileName;
            this.deviceNodes = deviceNode;
            this.devices = device;
        }

        public override string ToString() { return fileName; }
    }
}
