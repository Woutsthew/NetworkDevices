
namespace NetworkDevices.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms1AddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1RemoveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1AddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1RemoveDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1CheckPing = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.cms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms2AddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cms2RemoveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cms2AddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cms2RemoveDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cms2CheckPing = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.cms3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms3AddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cms3RemoveDevice = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.cms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.cms2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.cms3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ContextMenuStrip = this.cms1;
            this.dgv1.Location = new System.Drawing.Point(11, 11);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(136, 358);
            this.dgv1.TabIndex = 0;
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms1AddFolder,
            this.cms1RemoveFolder,
            this.cms1AddDevice,
            this.cms1RemoveDevice,
            this.cms1CheckPing});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(206, 114);
            // 
            // cms1AddFolder
            // 
            this.cms1AddFolder.Name = "cms1AddFolder";
            this.cms1AddFolder.Size = new System.Drawing.Size(205, 22);
            this.cms1AddFolder.Text = "Добавить папку";
            // 
            // cms1RemoveFolder
            // 
            this.cms1RemoveFolder.Name = "cms1RemoveFolder";
            this.cms1RemoveFolder.Size = new System.Drawing.Size(205, 22);
            this.cms1RemoveFolder.Text = "Удалить папку";
            // 
            // cms1AddDevice
            // 
            this.cms1AddDevice.Name = "cms1AddDevice";
            this.cms1AddDevice.Size = new System.Drawing.Size(205, 22);
            this.cms1AddDevice.Text = "Добавить устройство";
            // 
            // cms1RemoveDevice
            // 
            this.cms1RemoveDevice.Name = "cms1RemoveDevice";
            this.cms1RemoveDevice.Size = new System.Drawing.Size(205, 22);
            this.cms1RemoveDevice.Text = "Удалить устройство";
            // 
            // cms1CheckPing
            // 
            this.cms1CheckPing.Name = "cms1CheckPing";
            this.cms1CheckPing.Size = new System.Drawing.Size(205, 22);
            this.cms1CheckPing.Text = "Проверить доступность";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.ContextMenuStrip = this.cms2;
            this.dgv2.Location = new System.Drawing.Point(151, 11);
            this.dgv2.Margin = new System.Windows.Forms.Padding(2);
            this.dgv2.MultiSelect = false;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(136, 358);
            this.dgv2.TabIndex = 1;
            // 
            // cms2
            // 
            this.cms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms2AddFolder,
            this.cms2RemoveFolder,
            this.cms2AddDevice,
            this.cms2RemoveDevice,
            this.cms2CheckPing});
            this.cms2.Name = "cms2";
            this.cms2.Size = new System.Drawing.Size(206, 114);
            // 
            // cms2AddFolder
            // 
            this.cms2AddFolder.Name = "cms2AddFolder";
            this.cms2AddFolder.Size = new System.Drawing.Size(205, 22);
            this.cms2AddFolder.Text = "Добавить папку";
            // 
            // cms2RemoveFolder
            // 
            this.cms2RemoveFolder.Name = "cms2RemoveFolder";
            this.cms2RemoveFolder.Size = new System.Drawing.Size(205, 22);
            this.cms2RemoveFolder.Text = "Удалить папку";
            // 
            // cms2AddDevice
            // 
            this.cms2AddDevice.Name = "cms2AddDevice";
            this.cms2AddDevice.Size = new System.Drawing.Size(205, 22);
            this.cms2AddDevice.Text = "Добавить устройство";
            // 
            // cms2RemoveDevice
            // 
            this.cms2RemoveDevice.Name = "cms2RemoveDevice";
            this.cms2RemoveDevice.Size = new System.Drawing.Size(205, 22);
            this.cms2RemoveDevice.Text = "Удалить устройство";
            // 
            // cms2CheckPing
            // 
            this.cms2CheckPing.Name = "cms2CheckPing";
            this.cms2CheckPing.Size = new System.Drawing.Size(205, 22);
            this.cms2CheckPing.Text = "Проверить доступность";
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.AllowUserToResizeColumns = false;
            this.dgv3.AllowUserToResizeRows = false;
            this.dgv3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.ContextMenuStrip = this.cms3;
            this.dgv3.Location = new System.Drawing.Point(291, 11);
            this.dgv3.Margin = new System.Windows.Forms.Padding(2);
            this.dgv3.MultiSelect = false;
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.RowHeadersVisible = false;
            this.dgv3.RowTemplate.Height = 25;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3.Size = new System.Drawing.Size(136, 358);
            this.dgv3.TabIndex = 2;
            // 
            // cms3
            // 
            this.cms3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms3AddDevice,
            this.cms3RemoveDevice});
            this.cms3.Name = "cms3";
            this.cms3.Size = new System.Drawing.Size(192, 48);
            // 
            // cms3AddDevice
            // 
            this.cms3AddDevice.Name = "cms3AddDevice";
            this.cms3AddDevice.Size = new System.Drawing.Size(191, 22);
            this.cms3AddDevice.Text = "Добавить устройство";
            // 
            // cms3RemoveDevice
            // 
            this.cms3RemoveDevice.Name = "cms3RemoveDevice";
            this.cms3RemoveDevice.Size = new System.Drawing.Size(191, 22);
            this.cms3RemoveDevice.Text = "Удалить устройство";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 380);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Network Devices";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.cms1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.cms2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.cms3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem cms1AddFolder;
        private System.Windows.Forms.ToolStripMenuItem cms1RemoveFolder;
        private System.Windows.Forms.ToolStripMenuItem cms1AddDevice;
        private System.Windows.Forms.ToolStripMenuItem cms1RemoveDevice;
        private System.Windows.Forms.ToolStripMenuItem cms1CheckPing;
        private System.Windows.Forms.ContextMenuStrip cms2;
        private System.Windows.Forms.ToolStripMenuItem cms2AddFolder;
        private System.Windows.Forms.ToolStripMenuItem cms2RemoveFolder;
        private System.Windows.Forms.ToolStripMenuItem cms2AddDevice;
        private System.Windows.Forms.ToolStripMenuItem cms2RemoveDevice;
        private System.Windows.Forms.ToolStripMenuItem cms2CheckPing;
        private System.Windows.Forms.ContextMenuStrip cms3;
        private System.Windows.Forms.ToolStripMenuItem cms3AddDevice;
        private System.Windows.Forms.ToolStripMenuItem cms3RemoveDevice;
    }
}