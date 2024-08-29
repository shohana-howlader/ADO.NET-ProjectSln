namespace AdioProject
{
    partial class VehicleManagement
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
            this.VehicleInfo = new System.Windows.Forms.TabControl();
            this.VehicleDeteils = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butReset = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ModelWithPrice = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageUpload = new System.Windows.Forms.GroupBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butBrowse = new System.Windows.Forms.Button();
            this.pictureBoxVehicle = new System.Windows.Forms.PictureBox();
            this.BasicInformation = new System.Windows.Forms.GroupBox();
            this.radBattery = new System.Windows.Forms.RadioButton();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.Enginetype = new System.Windows.Forms.Label();
            this.cheStock = new System.Windows.Forms.CheckBox();
            this.combCatagory = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VehicleName = new System.Windows.Forms.TextBox();
            this.VCode = new System.Windows.Forms.TextBox();
            this.labStock = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.LDate = new System.Windows.Forms.Label();
            this.VName = new System.Windows.Forms.Label();
            this.VehicleCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleList = new System.Windows.Forms.TabPage();
            this.ViewReport = new System.Windows.Forms.Button();
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.VehicleInfo.SuspendLayout();
            this.VehicleDeteils.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ModelWithPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.ImageUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).BeginInit();
            this.BasicInformation.SuspendLayout();
            this.VehicleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleInfo
            // 
            this.VehicleInfo.Controls.Add(this.VehicleDeteils);
            this.VehicleInfo.Controls.Add(this.VehicleList);
            this.VehicleInfo.Location = new System.Drawing.Point(12, 21);
            this.VehicleInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleInfo.Name = "VehicleInfo";
            this.VehicleInfo.SelectedIndex = 0;
            this.VehicleInfo.Size = new System.Drawing.Size(1496, 724);
            this.VehicleInfo.TabIndex = 0;
            // 
            // VehicleDeteils
            // 
            this.VehicleDeteils.Controls.Add(this.groupBox4);
            this.VehicleDeteils.Controls.Add(this.ModelWithPrice);
            this.VehicleDeteils.Controls.Add(this.ImageUpload);
            this.VehicleDeteils.Controls.Add(this.BasicInformation);
            this.VehicleDeteils.Controls.Add(this.label1);
            this.VehicleDeteils.Location = new System.Drawing.Point(4, 25);
            this.VehicleDeteils.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleDeteils.Name = "VehicleDeteils";
            this.VehicleDeteils.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleDeteils.Size = new System.Drawing.Size(1488, 695);
            this.VehicleDeteils.TabIndex = 0;
            this.VehicleDeteils.Text = "Vehicle Deteils";
            this.VehicleDeteils.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butReset);
            this.groupBox4.Controls.Add(this.butDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(41, 601);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(780, 89);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(539, 21);
            this.butReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(189, 50);
            this.butReset.TabIndex = 0;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(285, 21);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(189, 50);
            this.butDelete.TabIndex = 0;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(31, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModelWithPrice
            // 
            this.ModelWithPrice.Controls.Add(this.dgvProduct);
            this.ModelWithPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelWithPrice.Location = new System.Drawing.Point(871, 100);
            this.ModelWithPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModelWithPrice.Name = "ModelWithPrice";
            this.ModelWithPrice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModelWithPrice.Size = new System.Drawing.Size(597, 590);
            this.ModelWithPrice.TabIndex = 1;
            this.ModelWithPrice.TabStop = false;
            this.ModelWithPrice.Text = "Model With Price";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.ModelName,
            this.Price});
            this.dgvProduct.Location = new System.Drawing.Point(15, 30);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(568, 542);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvProduct_UserDeletingRow);
            // 
            // dgvProductId
            // 
            this.dgvProductId.DataPropertyName = "dgvProductId";
            this.dgvProductId.HeaderText = "dgvProductId";
            this.dgvProductId.MinimumWidth = 6;
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.Visible = false;
            this.dgvProductId.Width = 125;
            // 
            // ModelName
            // 
            this.ModelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "Model Name";
            this.ModelName.MaxInputLength = 50000;
            this.ModelName.MinimumWidth = 10;
            this.ModelName.Name = "ModelName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ImageUpload
            // 
            this.ImageUpload.Controls.Add(this.butClear);
            this.ImageUpload.Controls.Add(this.butBrowse);
            this.ImageUpload.Controls.Add(this.pictureBoxVehicle);
            this.ImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageUpload.Location = new System.Drawing.Point(447, 100);
            this.ImageUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageUpload.Name = "ImageUpload";
            this.ImageUpload.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageUpload.Size = new System.Drawing.Size(373, 494);
            this.ImageUpload.TabIndex = 1;
            this.ImageUpload.TabStop = false;
            this.ImageUpload.Text = "Image Upload";
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(204, 404);
            this.butClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(164, 41);
            this.butClear.TabIndex = 0;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowse.Location = new System.Drawing.Point(5, 404);
            this.butBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(164, 41);
            this.butBrowse.TabIndex = 0;
            this.butBrowse.Text = "Browse..";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // pictureBoxVehicle
            // 
            this.pictureBoxVehicle.Location = new System.Drawing.Point(29, 50);
            this.pictureBoxVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxVehicle.Name = "pictureBoxVehicle";
            this.pictureBoxVehicle.Size = new System.Drawing.Size(311, 288);
            this.pictureBoxVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehicle.TabIndex = 0;
            this.pictureBoxVehicle.TabStop = false;
            // 
            // BasicInformation
            // 
            this.BasicInformation.Controls.Add(this.radBattery);
            this.BasicInformation.Controls.Add(this.radDiesel);
            this.BasicInformation.Controls.Add(this.Enginetype);
            this.BasicInformation.Controls.Add(this.cheStock);
            this.BasicInformation.Controls.Add(this.combCatagory);
            this.BasicInformation.Controls.Add(this.dateTimePicker1);
            this.BasicInformation.Controls.Add(this.VehicleName);
            this.BasicInformation.Controls.Add(this.VCode);
            this.BasicInformation.Controls.Add(this.labStock);
            this.BasicInformation.Controls.Add(this.Category);
            this.BasicInformation.Controls.Add(this.LDate);
            this.BasicInformation.Controls.Add(this.VName);
            this.BasicInformation.Controls.Add(this.VehicleCode);
            this.BasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicInformation.Location = new System.Drawing.Point(41, 100);
            this.BasicInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasicInformation.Name = "BasicInformation";
            this.BasicInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasicInformation.Size = new System.Drawing.Size(381, 494);
            this.BasicInformation.TabIndex = 1;
            this.BasicInformation.TabStop = false;
            this.BasicInformation.Text = "Basic Information";
            // 
            // radBattery
            // 
            this.radBattery.AutoSize = true;
            this.radBattery.Location = new System.Drawing.Point(275, 404);
            this.radBattery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBattery.Name = "radBattery";
            this.radBattery.Size = new System.Drawing.Size(94, 29);
            this.radBattery.TabIndex = 6;
            this.radBattery.TabStop = true;
            this.radBattery.Text = "Battery";
            this.radBattery.UseVisualStyleBackColor = true;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.Location = new System.Drawing.Point(171, 404);
            this.radDiesel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(87, 29);
            this.radDiesel.TabIndex = 6;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            // 
            // Enginetype
            // 
            this.Enginetype.AutoSize = true;
            this.Enginetype.Location = new System.Drawing.Point(27, 404);
            this.Enginetype.Name = "Enginetype";
            this.Enginetype.Size = new System.Drawing.Size(115, 25);
            this.Enginetype.TabIndex = 5;
            this.Enginetype.Text = "Engine type";
            // 
            // cheStock
            // 
            this.cheStock.AutoSize = true;
            this.cheStock.Location = new System.Drawing.Point(183, 343);
            this.cheStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cheStock.Name = "cheStock";
            this.cheStock.Size = new System.Drawing.Size(134, 29);
            this.cheStock.TabIndex = 4;
            this.cheStock.Text = "Is Avilabel?";
            this.cheStock.UseVisualStyleBackColor = true;
            // 
            // combCatagory
            // 
            this.combCatagory.FormattingEnabled = true;
            this.combCatagory.Location = new System.Drawing.Point(183, 274);
            this.combCatagory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combCatagory.Name = "combCatagory";
            this.combCatagory.Size = new System.Drawing.Size(181, 33);
            this.combCatagory.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 202);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // VehicleName
            // 
            this.VehicleName.Location = new System.Drawing.Point(181, 126);
            this.VehicleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.Size = new System.Drawing.Size(181, 30);
            this.VehicleName.TabIndex = 1;
            // 
            // VCode
            // 
            this.VCode.Location = new System.Drawing.Point(183, 65);
            this.VCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VCode.Name = "VCode";
            this.VCode.Size = new System.Drawing.Size(181, 30);
            this.VCode.TabIndex = 1;
            // 
            // labStock
            // 
            this.labStock.AutoSize = true;
            this.labStock.Location = new System.Drawing.Point(27, 347);
            this.labStock.Name = "labStock";
            this.labStock.Size = new System.Drawing.Size(73, 25);
            this.labStock.TabIndex = 0;
            this.labStock.Text = "Stock :";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(27, 274);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(103, 25);
            this.Category.TabIndex = 0;
            this.Category.Text = "Category :";
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(25, 202);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(123, 25);
            this.LDate.TabIndex = 0;
            this.LDate.Text = "Lunch Date :";
            // 
            // VName
            // 
            this.VName.AutoSize = true;
            this.VName.Location = new System.Drawing.Point(25, 126);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(145, 25);
            this.VName.TabIndex = 0;
            this.VName.Text = "Vehicle Name :";
            // 
            // VehicleCode
            // 
            this.VehicleCode.AutoSize = true;
            this.VehicleCode.Location = new System.Drawing.Point(27, 65);
            this.VehicleCode.Name = "VehicleCode";
            this.VehicleCode.Size = new System.Drawing.Size(141, 25);
            this.VehicleCode.TabIndex = 0;
            this.VehicleCode.Text = "Vehicle Code :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(585, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Management";
            // 
            // VehicleList
            // 
            this.VehicleList.Controls.Add(this.ViewReport);
            this.VehicleList.Controls.Add(this.dgvVehicleList);
            this.VehicleList.Controls.Add(this.label2);
            this.VehicleList.Location = new System.Drawing.Point(4, 25);
            this.VehicleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleList.Size = new System.Drawing.Size(1488, 695);
            this.VehicleList.TabIndex = 1;
            this.VehicleList.Text = "Vehicle List";
            this.VehicleList.UseVisualStyleBackColor = true;
            // 
            // ViewReport
            // 
            this.ViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReport.Location = new System.Drawing.Point(1091, 640);
            this.ViewReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Size = new System.Drawing.Size(189, 46);
            this.ViewReport.TabIndex = 2;
            this.ViewReport.Text = "View Report";
            this.ViewReport.UseVisualStyleBackColor = true;
            this.ViewReport.Click += new System.EventHandler(this.ViewReport_Click);
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Location = new System.Drawing.Point(25, 62);
            this.dgvVehicleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.RowHeadersWidth = 51;
            this.dgvVehicleList.RowTemplate.Height = 24;
            this.dgvVehicleList.Size = new System.Drawing.Size(1413, 567);
            this.dgvVehicleList.TabIndex = 1;
            this.dgvVehicleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleList_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle List";
            // 
            // VehicleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 750);
            this.Controls.Add(this.VehicleInfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VehicleManagement";
            this.Text = "Vehicle Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VehicleInfo.ResumeLayout(false);
            this.VehicleDeteils.ResumeLayout(false);
            this.VehicleDeteils.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ModelWithPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ImageUpload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).EndInit();
            this.BasicInformation.ResumeLayout(false);
            this.BasicInformation.PerformLayout();
            this.VehicleList.ResumeLayout(false);
            this.VehicleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl VehicleInfo;
        private System.Windows.Forms.TabPage VehicleDeteils;
        private System.Windows.Forms.TabPage VehicleList;
        private System.Windows.Forms.GroupBox ModelWithPrice;
        private System.Windows.Forms.GroupBox ImageUpload;
        private System.Windows.Forms.GroupBox BasicInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label VehicleCode;
        private System.Windows.Forms.TextBox VehicleName;
        private System.Windows.Forms.TextBox VCode;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.Label VName;
        private System.Windows.Forms.Label labStock;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combCatagory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cheStock;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.PictureBox pictureBoxVehicle;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radBattery;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.Label Enginetype;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button ViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

