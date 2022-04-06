using NetworkDevices.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkDevices.Forms
{
    public partial class PingResult : Form
    {
        DeviceNode list;

        public PingResult(DeviceNode ls)
        {
            InitializeComponent();
            list = ls;
            Load += PingResult_Load;
            KeyUp += (s, e) => { if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Left) Close(); };
            lbResult.KeyUp += (s, e) => { if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Left) Close(); };
        }

        private async void PingResult_Load(object sender, EventArgs e)
        {
            await Task.Run(() => TestPing(list.devices));
            int index = lbResult.Items.Count;
            int trash = 0;
            int CountDevices = list.devices.Count;
            int CountNowork = lbResult.Items.Count;
            foreach (DeviceNode folder in list.deviceNodes)
            {
                int CountDevice = folder.devices.Count;
                await Task.Run(() => TestPing(folder.devices));
                lbResult.Items.Insert(index, $"В папке \"{list}->{folder}\" всего: {CountDevice} устройств. Не доступных устройств: {lbResult.Items.Count - CountDevices + CountNowork - trash++}");
                if (index != 0) { lbResult.Items.Insert(index, ""); trash++; }
                index = lbResult.Items.Count;
                CountDevices += CountDevice;
            }
            lbResult.Items.Insert(0, $"В папке \"{list}\" всего: {CountDevices} устройств. Не доступных устройств: {lbResult.Items.Count - trash}");
        }

        private void TestPing(List<Device> ls)
        {
            foreach (Device d in ls)
            {
                bool flag = false;

                for (int i = 0; i < 3; i++)
                    if (Constants.CheckStatusPing(d.IP_Address) != -1) { flag = true; break; };

                if (flag == false)
                    lbResult.Items.Add(String.Join("   ", d.AllProperty().Split('|')));
            }
        }
    }
}
