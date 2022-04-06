
namespace NetworkDevices.Classes
{
    public class Device
    {
        public string Name { get; private set; }

        public string Type { get; private set; }

        public string IP_Address { get; private set; }

        public string MAC_Address { get; private set; }

        public string Inventory { get; private set; }

        public string Image { get; private set; }

        public Device(string name, string type, string iP_Address,
            string mAC_Address, string inventory, string image)
        {
            Name = name;
            Type = type;
            IP_Address = iP_Address;
            MAC_Address = mAC_Address;
            Inventory = inventory;
            Image = image;
        }

        public override string ToString() { return Name; }

        public string AllProperty() { return $"{Name}|{Type}|{IP_Address}|{MAC_Address}|{Inventory}|{Image}"; }
    }
}
