using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NetworkDevices.Classes;
using Newtonsoft.Json;

namespace NetworkDevices.Forms
{
    public partial class Main : Form
    {
        DeviceNode system;
        string tablenamedgv1;
        string tablenamedgv2;
        bool select = true;

        public Main()
        {
            InitializeComponent();

            #region file

            if (!File.Exists(Constants.settings))
                File.WriteAllText(Constants.settings, JsonConvert.SerializeObject(new DeviceNode("system", new List<DeviceNode>(), new List<Device>()), Formatting.Indented));

            if (!Directory.Exists(Constants.images)) Directory.CreateDirectory(Constants.images);

            #endregion

            #region dgv event

            dgv1.CellDoubleClick += Dgv1_CellDoubleClick;
            dgv2.CellDoubleClick += Dgv2_CellDoubleClick;
            dgv3.CellDoubleClick += Dgv3_CellDoubleClick;

            dgv1.SelectionChanged += (s, e) => { if (select == true) { select = false; dgv2.ClearSelection(); dgv3.ClearSelection(); select = true; } };
            dgv2.SelectionChanged += (s, e) => { if (select == true) { select = false; dgv1.ClearSelection(); dgv3.ClearSelection(); select = true; } };
            dgv3.SelectionChanged += (s, e) => { if (select == true) { select = false; dgv1.ClearSelection(); dgv2.ClearSelection(); select = true; } };

            dgv1.KeyUp += Dgv1_KeyUp;
            dgv2.KeyUp += Dgv2_KeyUp;
            dgv3.KeyUp += Dgv3_KeyUp;

            dgv1.Columns.Add("1", "1");
            dgv2.Columns.Add("2", "2");
            dgv3.Columns.Add("3", "3");

            #endregion

            #region cms click event

            cms1AddFolder.Click += CMS1AddFolder_Click;
            cms1RemoveFolder.Click += CMS1RemoveFolder_Click;
            cms1AddDevice.Click += CMS1AddDevice_Click;
            cms1RemoveDevice.Click += CMS1RemoveDevice_Click;
            cms1CheckPing.Click += CMS1CheckPing_Click;

            cms2AddFolder.Click += CMS2AddFolder_Click;
            cms2RemoveFolder.Click += CMS2RemoveFolder_Click;
            cms2AddDevice.Click += CMS2AddDevice_Click;
            cms2RemoveDevice.Click += CMS2RemoveDevice_Click;
            cms2CheckPing.Click += CMS2CheckPing_Click;

            cms3AddDevice.Click += CMS3AddDevice_Click;
            cms3RemoveDevice.Click += CMS3RemoveDevice_Click;

            #endregion

            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            PrintOnTable(dgv1, system);
        }

        private void PrintOnTable(DataGridView dgv, DeviceNode dn)
        {
            dgv.Rows.Clear();
            foreach (DeviceNode row in dn.deviceNodes)
            {
                dgv.Rows.Add(row);
                dgv.Rows[dgv.RowCount - 1].Cells[0].Style.BackColor = Color.LightCyan;
            }
            foreach (Device row in dn.devices)
                dgv.Rows.Add(row.Name);
        }

        #region dgv event

        #region dgv celldoubleclick

        private void Dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                tablenamedgv1 = dgv1.SelectedCells[0].Value.ToString();
                DeviceNode d = system.deviceNodes.Where(x => x.ToString() == tablenamedgv1).First();
                dgv3.Rows.Clear();
                dgv2.ContextMenuStrip = cms2;
                dgv3.ContextMenuStrip = null;
                PrintOnTable(dgv2, d);
            }
            else
            {
                string name = dgv1.SelectedCells[0].Value.ToString();
                Device d = system.devices.Where(x => x.ToString() == name).First();
                new ShowInfoDevice(d).Show();
            }
        }

        private void Dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv2.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                tablenamedgv2 = dgv2.SelectedCells[0].Value.ToString();
                DeviceNode d = system.deviceNodes.Where(x => x.ToString() == tablenamedgv1).First().
                    deviceNodes.Where(x => x.ToString() == tablenamedgv2).First();
                dgv3.ContextMenuStrip = cms3;
                PrintOnTable(dgv3, d);
            }
            else
            {
                string name = dgv2.SelectedCells[0].Value.ToString();
                Device d = system.deviceNodes.Where(x => x.ToString() == tablenamedgv1).First().
                    devices.Where(x => x.ToString() == name).First();
                new ShowInfoDevice(d).Show();
            }
        }

        private void Dgv3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgv3.SelectedCells[0].Value.ToString();
            Device d = system.deviceNodes.Where(x => x.ToString() == tablenamedgv1).First().
                    deviceNodes.Where(x => x.ToString() == tablenamedgv2).First().
                    devices.Where(x => x.ToString() == name).First();
            new ShowInfoDevice(d).Show();
        }
        
        #endregion

        #region dgv keyup

        private void Dgv1_KeyUp(object sender, KeyEventArgs e)
        {
            bool isFolder = false;
            if (e.KeyCode == Keys.Right)
            {
                if (dgv1.SelectedCells[0].Style.BackColor == Color.LightCyan) isFolder = true;
                Dgv1_CellDoubleClick(dgv1, null);
                if (isFolder) if (dgv2.Rows.Count != 0) dgv2.Focus();
            }
            if (e.KeyCode == Keys.Add) { CMS1AddDevice_Click(cms1, null); }
            if (e.KeyCode == Keys.Subtract) { CMS1RemoveDevice_Click(cms1, null); }
            if (e.KeyCode == Keys.Multiply) { CMS1AddFolder_Click(cms1, null); }
            if (e.KeyCode == Keys.Divide) { CMS1RemoveFolder_Click(cms1, null); }
            if (e.KeyCode == Keys.NumPad0) { CMS1CheckPing_Click(cms1, null); }
        }

        private void Dgv2_KeyUp(object sender, KeyEventArgs e)
        {
            bool isFolder = false;
            if (e.KeyCode == Keys.Right)
            {
                if (dgv2.SelectedCells[0].Style.BackColor == Color.LightCyan) isFolder = true;
                Dgv2_CellDoubleClick(dgv2, null);
                if (isFolder) if (dgv3.Rows.Count != 0) dgv3.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                dgv1.Focus();
                dgv1.Rows[0].Selected = true;
                SendKeys.Send("{UP}");
            }
            if (e.KeyCode == Keys.Add) { CMS2AddDevice_Click(cms2, null); }
            if (e.KeyCode == Keys.Subtract) { CMS2RemoveDevice_Click(cms2, null); }
            if (e.KeyCode == Keys.Multiply) { CMS2AddFolder_Click(cms2, null); }
            if (e.KeyCode == Keys.Divide) { CMS2RemoveFolder_Click(cms2, null); }
            if (e.KeyCode == Keys.NumPad0) { CMS2CheckPing_Click(cms2, null); }
        }
        
        private void Dgv3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) Dgv3_CellDoubleClick(dgv3, null);
            if (e.KeyCode == Keys.Left)
            {
                dgv2.Focus();
                dgv2.Rows[0].Selected = true;
                SendKeys.Send("{UP}");
            }
            if (e.KeyCode == Keys.Add) { CMS3AddDevice_Click(cms3, null); }
            if (e.KeyCode == Keys.Subtract) { CMS3RemoveDevice_Click(cms3, null); }
        }

        #endregion

        #endregion

        #region cms clicks

        #region cMS1

        private void CMS1AddFolder_Click(object sender, EventArgs e)
        {
            new AddFolder(system).ShowDialog();
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            PrintOnTable(dgv1, system);
        }

        private void CMS1RemoveFolder_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedCells.Count == 0) return;
            if (dgv1.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                string folder = dgv1.SelectedCells[0].Value.ToString();
                DeviceNode del = system.deviceNodes.Where(x => x.fileName == folder).First();
                if (MessageBox.Show($"Вы действительно хотите удалить это папку? \n{folder}", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    system.deviceNodes.Remove(del);
                    foreach (DeviceNode dd in del.deviceNodes)
                        foreach (Device ddd in dd.devices)
                            File.Delete(ddd.Image);
                    foreach (Device dddd in del.devices) File.Delete(dddd.Image);
                    string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                    File.WriteAllText(Constants.settings, jsonData);
                }
                system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
                dgv2.Rows.Clear(); dgv3.Rows.Clear();
                PrintOnTable(dgv1, system);
            }
        }

        private void CMS1AddDevice_Click(object sender, EventArgs e)
        {
            new AddDevice(system).ShowDialog();
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            PrintOnTable(dgv1, system);
        }

        private void CMS1RemoveDevice_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedCells.Count == 0) return;
            if (dgv1.SelectedCells[0].Style.BackColor != Color.LightCyan)
            {
                string device = dgv1.SelectedCells[0].Value.ToString();
                Device dev = system.devices.Where(x => x.Name == device).First();
                if (MessageBox.Show($"Вы действительно хотите удалить это устройство? \n {dev.Name} {dev.IP_Address}", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    system.devices.Remove(dev);
                    string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                    File.WriteAllText(Constants.settings, jsonData);
                    File.Delete(dev.Image);
                }
                system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
                dgv2.Rows.Clear(); dgv3.Rows.Clear();
                PrintOnTable(dgv1, system);
            }
        }
        
        private void CMS1CheckPing_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedCells.Count == 0) return;
            if (dgv1.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                string checkping = dgv1.SelectedCells[0].Value.ToString();
                DeviceNode ping = system.deviceNodes.Where(x => x.fileName == checkping).First();
                new PingResult(ping).ShowDialog();
            }
        }
       
        #endregion

        #region cMS2

        private void CMS2AddFolder_Click(object sender, EventArgs e)
        {
            new AddFolder(system, tablenamedgv1).ShowDialog();
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First();
            PrintOnTable(dgv2, d);
        }
        
        private void CMS2RemoveFolder_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedCells.Count == 0) return;
            if (dgv2.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                string folder = dgv2.SelectedCells[0].Value.ToString();
                DeviceNode del = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == folder).First();
                if (MessageBox.Show($"Вы действительно хотите удалить это папку? \n{folder}", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Remove(del);
                    foreach (Device dev in del.devices) File.Delete(dev.Image);
                    string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                    File.WriteAllText(Constants.settings, jsonData);
                }
                system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
                DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First();
                dgv3.Rows.Clear();
                PrintOnTable(dgv2, d);
            }
        }

        private void CMS2AddDevice_Click(object sender, EventArgs e)
        {
            new AddDevice(system, tablenamedgv1).ShowDialog();
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First();
            PrintOnTable(dgv2, d);
        }
        
        private void CMS2RemoveDevice_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedCells.Count == 0) return;
            if (dgv2.SelectedCells[0].Style.BackColor != Color.LightCyan)
            {
                string device = dgv2.SelectedCells[0].Value.ToString();
                Device dev = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().devices.Where(x => x.Name == device).First();
                if (MessageBox.Show($"Вы действительно хотите удалить это устройство? \n {dev.Name} {dev.IP_Address}", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().devices.Remove(dev);
                    string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                    File.WriteAllText(Constants.settings, jsonData);
                    File.Delete(dev.Image);
                }
                system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
                DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First();
                dgv3.Rows.Clear();
                PrintOnTable(dgv2, d);
            }
        }

        private void CMS2CheckPing_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedCells.Count == 0) return;
            if (dgv2.SelectedCells[0].Style.BackColor == Color.LightCyan)
            {
                string checkping = dgv2.SelectedCells[0].Value.ToString();
                DeviceNode ping = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == checkping).First();
                new PingResult(ping).ShowDialog();
            }
        }
        
        #endregion

        #region cMS3

        private void CMS3AddDevice_Click(object sender, EventArgs e)
        {
            new AddDevice(system, tablenamedgv1, tablenamedgv2).ShowDialog();
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == tablenamedgv2).First();
            PrintOnTable(dgv3, d);
        }

        private void CMS3RemoveDevice_Click(object sender, EventArgs e)
        {
            if (dgv3.SelectedCells.Count == 0) return;
            string device = dgv3.SelectedCells[0].Value.ToString();
            Device dev = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == tablenamedgv2).First().devices.Where(x => x.Name == device).First();
            if (MessageBox.Show($"Вы действительно хотите удалить это устройство? \n {dev.Name} {dev.IP_Address}", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == tablenamedgv2).First().devices.Remove(dev);
                string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                File.WriteAllText(Constants.settings, jsonData);
                File.Delete(dev.Image);
            }
            system = JsonConvert.DeserializeObject<DeviceNode>(File.ReadAllText(Constants.settings));
            DeviceNode d = system.deviceNodes.Where(x => x.fileName == tablenamedgv1).First().deviceNodes.Where(x => x.fileName == tablenamedgv2).First();
            PrintOnTable(dgv3, d);
        }

        #endregion

        #endregion
    }
}
