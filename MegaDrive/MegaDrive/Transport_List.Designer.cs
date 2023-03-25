
namespace MegaDrive
{
    partial class Transport_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport_List));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.labelCompany = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.dataSet = new MegaDrive.DataSet();
            this.transport2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport2TableAdapter = new MegaDrive.DataSetTableAdapters.transport2TableAdapter();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.panelInfo2 = new System.Windows.Forms.Panel();
            this.labelDateMake2 = new System.Windows.Forms.Label();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.labelColor2 = new System.Windows.Forms.Label();
            this.labelPlace2 = new System.Windows.Forms.Label();
            this.labelDateMake = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataSet_transport = new MegaDrive.DataSet_transport();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter = new MegaDrive.DataSet_transportTableAdapters.transportTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporttypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportenabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentpointlocationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new MegaDrive.DataSet1();
            this.transportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter1 = new MegaDrive.DataSet1TableAdapters.transportTableAdapter();
            this.dataSet2 = new MegaDrive.DataSet2();
            this.transportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter2 = new MegaDrive.DataSet2TableAdapters.transportTableAdapter();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.panelCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport2BindingSource)).BeginInit();
            this.panelInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panelInfo.Controls.Add(this.panelInfo2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 417);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(1, 8, 1, 8);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(859, 136);
            this.panelInfo.TabIndex = 1;
            // 
            // panelCompany
            // 
            this.panelCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panelCompany.Controls.Add(this.buttonBack);
            this.panelCompany.Controls.Add(this.buttonAdd);
            this.panelCompany.Controls.Add(this.comboBoxTransport);
            this.panelCompany.Controls.Add(this.labelSearch);
            this.panelCompany.Controls.Add(this.textBoxSearch);
            this.panelCompany.Controls.Add(this.labelCompany);
            this.panelCompany.Controls.Add(this.pictureBoxIcon);
            this.panelCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompany.Location = new System.Drawing.Point(0, 0);
            this.panelCompany.Margin = new System.Windows.Forms.Padding(1, 8, 1, 8);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(859, 138);
            this.panelCompany.TabIndex = 2;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCompany.Location = new System.Drawing.Point(381, 5);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(157, 59);
            this.labelCompany.TabIndex = 5;
            this.labelCompany.Text = "«Мегадрайв»";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(23, 5);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(86, 120);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transport2BindingSource
            // 
            this.transport2BindingSource.DataMember = "transport2";
            this.transport2BindingSource.DataSource = this.dataSet;
            // 
            // transport2TableAdapter
            // 
            this.transport2TableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(163, 72);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 26);
            this.textBoxSearch.TabIndex = 6;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSearch.Location = new System.Drawing.Point(157, 22);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(77, 50);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Поиск";
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Items.AddRange(new object[] {
            "Все",
            "Доступные для бронирования",
            "Недоступные"});
            this.comboBoxTransport.Location = new System.Drawing.Point(400, 70);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTransport.TabIndex = 8;
            // 
            // panelInfo2
            // 
            this.panelInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo2.Controls.Add(this.labelPlace);
            this.panelInfo2.Controls.Add(this.labelColor);
            this.panelInfo2.Controls.Add(this.labelPrice);
            this.panelInfo2.Controls.Add(this.labelDateMake);
            this.panelInfo2.Controls.Add(this.labelPlace2);
            this.panelInfo2.Controls.Add(this.labelColor2);
            this.panelInfo2.Controls.Add(this.labelPrice2);
            this.panelInfo2.Controls.Add(this.labelDateMake2);
            this.panelInfo2.Location = new System.Drawing.Point(275, 5);
            this.panelInfo2.Name = "panelInfo2";
            this.panelInfo2.Size = new System.Drawing.Size(432, 128);
            this.panelInfo2.TabIndex = 0;
            // 
            // labelDateMake2
            // 
            this.labelDateMake2.AutoSize = true;
            this.labelDateMake2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateMake2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDateMake2.Location = new System.Drawing.Point(3, 0);
            this.labelDateMake2.Name = "labelDateMake2";
            this.labelDateMake2.Size = new System.Drawing.Size(144, 35);
            this.labelDateMake2.TabIndex = 0;
            this.labelDateMake2.Text = "Дата производства:";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice2.Location = new System.Drawing.Point(3, 29);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(138, 35);
            this.labelPrice2.TabIndex = 1;
            this.labelPrice2.Text = "Стоимость аренды:";
            // 
            // labelColor2
            // 
            this.labelColor2.AutoSize = true;
            this.labelColor2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelColor2.Location = new System.Drawing.Point(3, 58);
            this.labelColor2.Name = "labelColor2";
            this.labelColor2.Size = new System.Drawing.Size(51, 35);
            this.labelColor2.TabIndex = 2;
            this.labelColor2.Text = "Цвет:";
            // 
            // labelPlace2
            // 
            this.labelPlace2.AutoSize = true;
            this.labelPlace2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlace2.Location = new System.Drawing.Point(3, 85);
            this.labelPlace2.Name = "labelPlace2";
            this.labelPlace2.Size = new System.Drawing.Size(105, 35);
            this.labelPlace2.TabIndex = 3;
            this.labelPlace2.Text = "Расположение:";
            // 
            // labelDateMake
            // 
            this.labelDateMake.AutoSize = true;
            this.labelDateMake.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateMake.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDateMake.Location = new System.Drawing.Point(180, -1);
            this.labelDateMake.Name = "labelDateMake";
            this.labelDateMake.Size = new System.Drawing.Size(19, 35);
            this.labelDateMake.TabIndex = 4;
            this.labelDateMake.Text = "1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Location = new System.Drawing.Point(180, 28);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(21, 35);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "2";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelColor.Location = new System.Drawing.Point(180, 55);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(21, 35);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "3";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlace.Location = new System.Drawing.Point(180, 83);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(23, 35);
            this.labelPlace.TabIndex = 7;
            this.labelPlace.Text = "4";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonAdd.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(600, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataSet_transport
            // 
            this.dataSet_transport.DataSetName = "DataSet_transport";
            this.dataSet_transport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataMember = "transport";
            this.transportBindingSource.DataSource = this.dataSet_transport;
            // 
            // transportTableAdapter
            // 
            this.transportTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportidDataGridViewTextBoxColumn,
            this.transporttypeidDataGridViewTextBoxColumn,
            this.transporttypeDataGridViewTextBoxColumn,
            this.transportcolorDataGridViewTextBoxColumn,
            this.transportmodelDataGridViewTextBoxColumn,
            this.transportnumberDataGridViewTextBoxColumn,
            this.transportenabledDataGridViewCheckBoxColumn,
            this.currentpointlocationnumberDataGridViewTextBoxColumn,
            this.currentpointlocationaddressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.datemakeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // transportidDataGridViewTextBoxColumn
            // 
            this.transportidDataGridViewTextBoxColumn.DataPropertyName = "transport_id";
            this.transportidDataGridViewTextBoxColumn.HeaderText = "transport_id";
            this.transportidDataGridViewTextBoxColumn.Name = "transportidDataGridViewTextBoxColumn";
            // 
            // transporttypeidDataGridViewTextBoxColumn
            // 
            this.transporttypeidDataGridViewTextBoxColumn.DataPropertyName = "transport_type_id";
            this.transporttypeidDataGridViewTextBoxColumn.HeaderText = "transport_type_id";
            this.transporttypeidDataGridViewTextBoxColumn.Name = "transporttypeidDataGridViewTextBoxColumn";
            // 
            // transporttypeDataGridViewTextBoxColumn
            // 
            this.transporttypeDataGridViewTextBoxColumn.DataPropertyName = "transport_type";
            this.transporttypeDataGridViewTextBoxColumn.HeaderText = "transport_type";
            this.transporttypeDataGridViewTextBoxColumn.Name = "transporttypeDataGridViewTextBoxColumn";
            // 
            // transportcolorDataGridViewTextBoxColumn
            // 
            this.transportcolorDataGridViewTextBoxColumn.DataPropertyName = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.HeaderText = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.Name = "transportcolorDataGridViewTextBoxColumn";
            // 
            // transportmodelDataGridViewTextBoxColumn
            // 
            this.transportmodelDataGridViewTextBoxColumn.DataPropertyName = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.HeaderText = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.Name = "transportmodelDataGridViewTextBoxColumn";
            // 
            // transportnumberDataGridViewTextBoxColumn
            // 
            this.transportnumberDataGridViewTextBoxColumn.DataPropertyName = "transport_number";
            this.transportnumberDataGridViewTextBoxColumn.HeaderText = "transport_number";
            this.transportnumberDataGridViewTextBoxColumn.Name = "transportnumberDataGridViewTextBoxColumn";
            // 
            // transportenabledDataGridViewCheckBoxColumn
            // 
            this.transportenabledDataGridViewCheckBoxColumn.DataPropertyName = "transport_enabled";
            this.transportenabledDataGridViewCheckBoxColumn.HeaderText = "transport_enabled";
            this.transportenabledDataGridViewCheckBoxColumn.Name = "transportenabledDataGridViewCheckBoxColumn";
            // 
            // currentpointlocationnumberDataGridViewTextBoxColumn
            // 
            this.currentpointlocationnumberDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.HeaderText = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.Name = "currentpointlocationnumberDataGridViewTextBoxColumn";
            // 
            // currentpointlocationaddressDataGridViewTextBoxColumn
            // 
            this.currentpointlocationaddressDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.HeaderText = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.Name = "currentpointlocationaddressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // datemakeDataGridViewTextBoxColumn
            // 
            this.datemakeDataGridViewTextBoxColumn.DataPropertyName = "date_make";
            this.datemakeDataGridViewTextBoxColumn.HeaderText = "date_make";
            this.datemakeDataGridViewTextBoxColumn.Name = "datemakeDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource1
            // 
            this.transportBindingSource1.DataMember = "transport";
            this.transportBindingSource1.DataSource = this.dataSet1;
            // 
            // transportTableAdapter1
            // 
            this.transportTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource2
            // 
            this.transportBindingSource2.DataMember = "transport";
            this.transportBindingSource2.DataSource = this.dataSet2;
            // 
            // transportTableAdapter2
            // 
            this.transportTableAdapter2.ClearBeforeFill = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonBack.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(740, 64);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 39);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Transport_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCompany);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Transport_List";
            this.Text = "Список транспортов";
            this.Load += new System.EventHandler(this.Transport_List_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport2BindingSource)).EndInit();
            this.panelInfo2.ResumeLayout(false);
            this.panelInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource transport2BindingSource;
        private DataSetTableAdapters.transport2TableAdapter transport2TableAdapter;
        private System.Windows.Forms.Panel panelInfo2;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDateMake;
        private System.Windows.Forms.Label labelPlace2;
        private System.Windows.Forms.Label labelColor2;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Label labelDateMake2;
        private System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private DataSet_transport dataSet_transport;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private DataSet_transportTableAdapters.transportTableAdapter transportTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporttypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transportenabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemakeDataGridViewTextBoxColumn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transportBindingSource1;
        private DataSet1TableAdapters.transportTableAdapter transportTableAdapter1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource transportBindingSource2;
        private DataSet2TableAdapters.transportTableAdapter transportTableAdapter2;
        private System.Windows.Forms.Button buttonBack;
    }
}