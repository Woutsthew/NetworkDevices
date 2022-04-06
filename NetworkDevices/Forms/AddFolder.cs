using NetworkDevices.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetworkDevices.Forms
{
    public partial class AddFolder : Form
    {
        DeviceNode system;
        string depth = "";

        public AddFolder(DeviceNode ls, string depth1 = "")
        {
            InitializeComponent();
            system = ls;
            depth = depth1;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string namefolder = tbName.Text;

                #region search and add folder

                List<DeviceNode> list;
                if (depth == "") list = system.deviceNodes;
                else list = system.deviceNodes.Where(x => x.fileName == depth).First().deviceNodes;

                foreach (DeviceNode old in list)
                {
                    if (namefolder == old.fileName)
                        throw new Exception("Папка с таким именем уже существует!");
                }

                if (depth == "") system.deviceNodes.Add(new DeviceNode(namefolder, new List<DeviceNode>(), new List<Device>()));
                else system.deviceNodes.Where(x => x.fileName == depth).First().deviceNodes.Add(new DeviceNode(namefolder, new List<DeviceNode>(), new List<Device>()));

                #endregion

                string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                File.WriteAllText(Constants.settings, jsonData);
                Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
