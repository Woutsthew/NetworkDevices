using NetworkDevices.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetworkDevices.Forms
{
    public partial class AddDevice : Form
    {
        DeviceNode system;
        string depth1;
        string depth2;

        public AddDevice(DeviceNode ls, string d1 = "", string d2 = "")
        {
            InitializeComponent();

            system = ls;
            depth1 = d1; depth2 = d2;
            btnObzor.Click += BtnObzor_Click;
            btnSave.Click += BtnSave_Click;

            pbImage.AllowDrop = true;
            pbImage.DragEnter += PbImage_DragEnter;
            pbImage.DragDrop += PbImage_DragDrop;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region take param

                if (tbName.Text == "")
                    throw new Exception("Введите наименование устройства.");

                string name = tbName.Text;

                if (!cbType.Items.Contains(cbType.Text))
                    throw new Exception("Не выбран тип устройства.");

                string type = cbType.Text;
                string ip = tbIP.Text;
                string mac = tbMAC.Text;
                string inventory = tbInventory.Text;
                string imagename = $"{name}^{ip}^{inventory}";

                if (pbImage.Image == null)
                    throw new Exception("Не выбрано изображение.");

                string image = Constants.images + "\\" + imagename + ".png";

                Device nw = new Device(name, type, ip, mac, inventory, image);

                #endregion

                #region search and add device

                List<Device> ls;
                if (depth1 == "") ls = system.devices;
                else if (depth2 == "") ls = system.deviceNodes.Where(x => x.fileName == depth1).First().devices;
                else ls = system.deviceNodes.Where(x => x.fileName == depth1).First().deviceNodes.Where(x => x.fileName == depth2).First().devices;

                foreach (Device d in ls)
                {
                    if (d.Name == nw.Name || d.IP_Address == nw.IP_Address)
                        throw new Exception("Устройство с таким именем и ip-адресом уже существует");

                    if (nw.MAC_Address != "")
                        if (d.MAC_Address == nw.MAC_Address)
                            throw new Exception("Устройство с таким mac-адресом уже существует");

                    if (nw.Inventory != "")
                        if (d.Inventory == nw.Inventory)
                            throw new Exception("Устройство с таким инвертарным номером уже существует");
                }

                if (depth1 == "") system.devices.Add(nw);
                else if (depth2 == "") system.deviceNodes.Where(x => x.fileName == depth1).First().devices.Add(nw);
                else system.deviceNodes.Where(x => x.fileName == depth1).First().deviceNodes.Where(x => x.fileName == depth2).First().devices.Add(nw);

                #endregion

                string jsonData = JsonConvert.SerializeObject(system, Formatting.Indented);
                File.WriteAllText(Constants.settings, jsonData);
                pbImage.Image.Save(image);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnObzor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files(*.PNG;*.JPG;*.GIF;*.BMP)|*.PNG;*.JPG;*.GIF;*.BMP|All Files(*.*)|*.*" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try { pbImage.Image = new Bitmap(ofd.FileName); }
                catch { MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void PbImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void PbImage_DragDrop(object sender, DragEventArgs e)
        {
            string pathimage = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string exc = pathimage.Split('.').Last().ToLower();
            if (exc == "png" || exc == "jpg")
                pbImage.Image = new Bitmap(pathimage);
        }
    }
}
