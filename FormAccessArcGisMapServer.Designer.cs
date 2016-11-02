namespace AccessArcGisMapServer
{
    partial class FormAccessAgsMapServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccessAgsMapServer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcConnectServices = new System.Windows.Forms.TabControl();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lvAgsSvrObjs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConnectServices = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSOAPServices = new System.Windows.Forms.TextBox();
            this.tpREST = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestUrl = new System.Windows.Forms.TextBox();
            this.btnRestLayer = new System.Windows.Forms.Button();
            this.tpWMS = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWMSUrl = new System.Windows.Forms.TextBox();
            this.btnConnectWMSLayer = new System.Windows.Forms.Button();
            this.tpWMTS = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWMTSUrl = new System.Windows.Forms.TextBox();
            this.btnWMTSLayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcConnectServices.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.tpREST.SuspendLayout();
            this.tpWMS.SuspendLayout();
            this.tpWMTS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcConnectServices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 257);
            this.panel2.TabIndex = 4;
            // 
            // tcConnectServices
            // 
            this.tcConnectServices.Controls.Add(this.tpServices);
            this.tcConnectServices.Controls.Add(this.tpREST);
            this.tcConnectServices.Controls.Add(this.tpWMS);
            this.tcConnectServices.Controls.Add(this.tpWMTS);
            this.tcConnectServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConnectServices.Location = new System.Drawing.Point(0, 0);
            this.tcConnectServices.Name = "tcConnectServices";
            this.tcConnectServices.SelectedIndex = 0;
            this.tcConnectServices.Size = new System.Drawing.Size(938, 257);
            this.tcConnectServices.TabIndex = 7;
            // 
            // tpServices
            // 
            this.tpServices.Controls.Add(this.label1);
            this.tpServices.Controls.Add(this.lvAgsSvrObjs);
            this.tpServices.Controls.Add(this.btnConnectServices);
            this.tpServices.Controls.Add(this.btnConnect);
            this.tpServices.Controls.Add(this.txtSOAPServices);
            this.tpServices.Location = new System.Drawing.Point(4, 22);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(930, 231);
            this.tpServices.TabIndex = 0;
            this.tpServices.Text = "Services";
            this.tpServices.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "URL(http://servername:port/arcgis/services 或 http://servername:port/arcgis/rest/s" +
    "ervices)";
            // 
            // lvAgsSvrObjs
            // 
            this.lvAgsSvrObjs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAgsSvrObjs.GridLines = true;
            this.lvAgsSvrObjs.HideSelection = false;
            this.lvAgsSvrObjs.Location = new System.Drawing.Point(8, 50);
            this.lvAgsSvrObjs.Name = "lvAgsSvrObjs";
            this.lvAgsSvrObjs.Size = new System.Drawing.Size(252, 165);
            this.lvAgsSvrObjs.TabIndex = 9;
            this.lvAgsSvrObjs.UseCompatibleStateImageBehavior = false;
            this.lvAgsSvrObjs.View = System.Windows.Forms.View.Details;
            this.lvAgsSvrObjs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSOAPAgsSvrObjs_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "服务名称";
            this.columnHeader1.Width = 160;
            // 
            // btnConnectServices
            // 
            this.btnConnectServices.Location = new System.Drawing.Point(600, 21);
            this.btnConnectServices.Name = "btnConnectServices";
            this.btnConnectServices.Size = new System.Drawing.Size(75, 23);
            this.btnConnectServices.TabIndex = 8;
            this.btnConnectServices.Text = "连接";
            this.btnConnectServices.UseVisualStyleBackColor = true;
            this.btnConnectServices.Click += new System.EventHandler(this.btnConnectServices_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(266, 192);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "访问";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSOAPServices
            // 
            this.txtSOAPServices.Location = new System.Drawing.Point(8, 23);
            this.txtSOAPServices.Name = "txtSOAPServices";
            this.txtSOAPServices.Size = new System.Drawing.Size(586, 21);
            this.txtSOAPServices.TabIndex = 6;
            // 
            // tpREST
            // 
            this.tpREST.Controls.Add(this.label2);
            this.tpREST.Controls.Add(this.txtRestUrl);
            this.tpREST.Controls.Add(this.btnRestLayer);
            this.tpREST.Location = new System.Drawing.Point(4, 22);
            this.tpREST.Name = "tpREST";
            this.tpREST.Padding = new System.Windows.Forms.Padding(3);
            this.tpREST.Size = new System.Drawing.Size(930, 231);
            this.tpREST.TabIndex = 1;
            this.tpREST.Text = "REST";
            this.tpREST.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL(http://servername:port/arcgis/rest/services/servicename/MapServer)";
            // 
            // txtRestUrl
            // 
            this.txtRestUrl.Location = new System.Drawing.Point(8, 26);
            this.txtRestUrl.Name = "txtRestUrl";
            this.txtRestUrl.Size = new System.Drawing.Size(586, 21);
            this.txtRestUrl.TabIndex = 8;
            // 
            // btnRestLayer
            // 
            this.btnRestLayer.Location = new System.Drawing.Point(600, 24);
            this.btnRestLayer.Name = "btnRestLayer";
            this.btnRestLayer.Size = new System.Drawing.Size(100, 23);
            this.btnRestLayer.TabIndex = 7;
            this.btnRestLayer.Text = "Add RestLayer";
            this.btnRestLayer.UseVisualStyleBackColor = true;
            this.btnRestLayer.Click += new System.EventHandler(this.btnRestLayer_Click);
            // 
            // tpWMS
            // 
            this.tpWMS.Controls.Add(this.label3);
            this.tpWMS.Controls.Add(this.txtWMSUrl);
            this.tpWMS.Controls.Add(this.btnConnectWMSLayer);
            this.tpWMS.Location = new System.Drawing.Point(4, 22);
            this.tpWMS.Name = "tpWMS";
            this.tpWMS.Padding = new System.Windows.Forms.Padding(3);
            this.tpWMS.Size = new System.Drawing.Size(930, 231);
            this.tpWMS.TabIndex = 2;
            this.tpWMS.Text = "WMS";
            this.tpWMS.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "URL(http://servername:port/arcgis/rest/services/servicename/MapServer/WMSServer?)" +
    "";
            // 
            // txtWMSUrl
            // 
            this.txtWMSUrl.Location = new System.Drawing.Point(10, 26);
            this.txtWMSUrl.Name = "txtWMSUrl";
            this.txtWMSUrl.Size = new System.Drawing.Size(586, 21);
            this.txtWMSUrl.TabIndex = 11;
            // 
            // btnConnectWMSLayer
            // 
            this.btnConnectWMSLayer.Location = new System.Drawing.Point(600, 24);
            this.btnConnectWMSLayer.Name = "btnConnectWMSLayer";
            this.btnConnectWMSLayer.Size = new System.Drawing.Size(100, 23);
            this.btnConnectWMSLayer.TabIndex = 10;
            this.btnConnectWMSLayer.Text = "Add WMSLayer";
            this.btnConnectWMSLayer.UseVisualStyleBackColor = true;
            this.btnConnectWMSLayer.Click += new System.EventHandler(this.btnConnectWMSLayer_Click);
            // 
            // tpWMTS
            // 
            this.tpWMTS.Controls.Add(this.label4);
            this.tpWMTS.Controls.Add(this.txtWMTSUrl);
            this.tpWMTS.Controls.Add(this.btnWMTSLayer);
            this.tpWMTS.Location = new System.Drawing.Point(4, 22);
            this.tpWMTS.Name = "tpWMTS";
            this.tpWMTS.Padding = new System.Windows.Forms.Padding(3);
            this.tpWMTS.Size = new System.Drawing.Size(930, 231);
            this.tpWMTS.TabIndex = 3;
            this.tpWMTS.Text = "WMTS";
            this.tpWMTS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "URL(http://servername:port/arcgis/rest/services/servicename/MapServer/WMTS)";
            // 
            // txtWMTSUrl
            // 
            this.txtWMTSUrl.Location = new System.Drawing.Point(8, 28);
            this.txtWMTSUrl.Name = "txtWMTSUrl";
            this.txtWMTSUrl.Size = new System.Drawing.Size(586, 21);
            this.txtWMTSUrl.TabIndex = 14;
            // 
            // btnWMTSLayer
            // 
            this.btnWMTSLayer.Location = new System.Drawing.Point(600, 28);
            this.btnWMTSLayer.Name = "btnWMTSLayer";
            this.btnWMTSLayer.Size = new System.Drawing.Size(104, 23);
            this.btnWMTSLayer.TabIndex = 13;
            this.btnWMTSLayer.Text = "Add WMTSLayer";
            this.btnWMTSLayer.UseVisualStyleBackColor = true;
            this.btnWMTSLayer.Click += new System.EventHandler(this.btnWMTSLayer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.axLicenseControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 384);
            this.panel1.TabIndex = 5;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(496, 202);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.axTOCControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 384);
            this.panel3.TabIndex = 4;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(200, 384);
            this.axTOCControl1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.axMapControl1);
            this.panel4.Controls.Add(this.axToolbarControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 384);
            this.panel4.TabIndex = 5;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(738, 28);
            this.axToolbarControl1.TabIndex = 4;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 28);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(738, 356);
            this.axMapControl1.TabIndex = 5;
            // 
            // FormAccessAgsMapServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormAccessAgsMapServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试访问ArcGis地图服务";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tcConnectServices.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            this.tpServices.PerformLayout();
            this.tpREST.ResumeLayout(false);
            this.tpREST.PerformLayout();
            this.tpWMS.ResumeLayout(false);
            this.tpWMS.PerformLayout();
            this.tpWMTS.ResumeLayout(false);
            this.tpWMTS.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.TabControl tcConnectServices;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAgsSvrObjs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnConnectServices;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSOAPServices;
        private System.Windows.Forms.TabPage tpREST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestUrl;
        private System.Windows.Forms.Button btnRestLayer;
        private System.Windows.Forms.TabPage tpWMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWMSUrl;
        private System.Windows.Forms.Button btnConnectWMSLayer;
        private System.Windows.Forms.TabPage tpWMTS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWMTSUrl;
        private System.Windows.Forms.Button btnWMTSLayer;
        private System.Windows.Forms.Panel panel4;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Panel panel3;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
    }
}

