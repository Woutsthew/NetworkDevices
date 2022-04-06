using NetworkDevices.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkDevices.Forms
{
    public partial class ShowInfoDevice : Form
    {
        Device device;

        public ShowInfoDevice(Device d)
        {
            InitializeComponent();
            device = d;
            Load += ShowInfoDevice_Load;
            KeyUp += (s, e) => { if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Left) Close(); };
        }

        private void ShowInfoDevice_Load(object sender, EventArgs e)
        {
            lblName.Text += device.Name;
            lblType.Text += device.Type;
            lblIP.Text += device.IP_Address;
            lblMAC.Text += device.MAC_Address;
            lblInventory.Text += device.Inventory;
            pbImage.ImageLocation = device.Image;
            CheckPingIP(device.IP_Address);
        }

        private async void CheckPingIP(string ip)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    await Task.Run(() =>
                    {
                        int ms = Constants.CheckStatusPing(ip);
                        this.Invoke(new Action(() =>
                        {
                            if (ms != -1) lblStatus.ForeColor = Color.Green;
                            lblStatus.Text += $" {{{ms}}}";
                        }));
                    });
                }
            }
            catch { }
        }
    }
}
