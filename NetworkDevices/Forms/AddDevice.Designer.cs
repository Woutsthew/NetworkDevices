
namespace NetworkDevices.Forms
{
    partial class AddDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevice));
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.tbMAC = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnObzor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 39);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(101, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Тип устройства:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(13, 69);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(145, 17);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "Логический адрес (IP): ";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(13, 99);
            this.lblMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(163, 17);
            this.lblMAC.TabIndex = 3;
            this.lblMAC.Text = "Физический адрес (MAC): ";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(13, 129);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(139, 17);
            this.lblInventory.TabIndex = 4;
            this.lblInventory.Text = "Инвентарный номер: ";
            // 
            // tbMAC
            // 
            this.tbMAC.Location = new System.Drawing.Point(183, 96);
            this.tbMAC.Name = "tbMAC";
            this.tbMAC.Size = new System.Drawing.Size(117, 25);
            this.tbMAC.TabIndex = 5;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(183, 66);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(117, 25);
            this.tbIP.TabIndex = 6;
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(183, 126);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(117, 25);
            this.tbInventory.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(117, 25);
            this.tbName.TabIndex = 8;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Компьютер",
            "Сервер",
            "Web сервер",
            "Камера",
            "Коммутатор",
            "Регистратор"});
            this.cbType.Location = new System.Drawing.Point(183, 36);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(117, 25);
            this.cbType.TabIndex = 9;
            // 
            // btnObzor
            // 
            this.btnObzor.Location = new System.Drawing.Point(116, 154);
            this.btnObzor.Margin = new System.Windows.Forms.Padding(2);
            this.btnObzor.Name = "btnObzor";
            this.btnObzor.Size = new System.Drawing.Size(90, 26);
            this.btnObzor.TabIndex = 10;
            this.btnObzor.Text = "Обзор...";
            this.btnObzor.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 154);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(303, 9);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 166);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 184);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnObzor);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbMAC);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDevice";
            this.Text = "Добавить устройтсво";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox tbMAC;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnObzor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbImage;
    }
}