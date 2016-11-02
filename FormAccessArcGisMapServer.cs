using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.GISClient;

namespace AccessArcGisMapServer
{
    public partial class FormAccessAgsMapServer : Form
    {
        public FormAccessAgsMapServer()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
            axTOCControl1.SetBuddyControl(axMapControl1);
            axToolbarControl1.SetBuddyControl(axMapControl1);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (lvAgsSvrObjs.SelectedItems.Count != 1
                || lvAgsSvrObjs.SelectedItems[0].Tag == null
                || !(lvAgsSvrObjs.SelectedItems[0].Tag is IAGSServerObjectName))
            {
                return;
            }

            toolStripStatusLabel1.Text = "正在连接地图服务...";
            Application.DoEvents();

            axMapControl1.Map.ClearLayers();

            string msg = string.Empty;
            object layer = LoadMapServices.GetServerLayer((IAGSServerObjectName)lvAgsSvrObjs.SelectedItems[0].Tag, out msg);

            if (layer != null)
            {
                toolStripStatusLabel1.Text = "正在加载地图服务...";
                Application.DoEvents();

                if (layer is ILayer)
                {
                    axMapControl1.AddLayer(layer as ILayer);
                }
                else
                    if (layer is Bitmap)
                    {
                        
                    }
                
                Application.DoEvents();
                
                toolStripStatusLabel1.Text = "加载完毕";
            }
            else
            {
                toolStripStatusLabel1.Text = "连接地图服务失败";
                if (msg != string.Empty)
                {
                    MessageBox.Show(msg);
                }
            }
        }

        private void lvSOAPAgsSvrObjs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnConnect.Enabled = lvAgsSvrObjs.SelectedItems.Count == 1;
        }

        private void btnConnectServices_Click(object sender, EventArgs e)
        {
            axMapControl1.Map.ClearLayers();
            lvAgsSvrObjs.Items.Clear();
            Application.DoEvents();
            string msg = string.Empty;
            try
            {
                toolStripStatusLabel1.Text = "正在连接地图服务器...";
                btnConnectServices.Enabled = false;
                Application.DoEvents();

                IAGSEnumServerObjectName agsSvrObjNames = null;
                msg = LoadMapServices.GetServices(txtSOAPServices.Text, out agsSvrObjNames);
                if (msg == string.Empty)
                {
                    agsSvrObjNames.Reset();
                    IAGSServerObjectName agsSvrObjName = agsSvrObjNames.Next();
                    while (agsSvrObjName != null)
                    {
                        string name = agsSvrObjName.Name;
                        string type = agsSvrObjName.Type;
                        if (type.ToUpper() == "MAPSERVER")
                        {
                            ListViewItem lvItem = lvAgsSvrObjs.Items.Add(name);
                            lvItem.Tag = agsSvrObjName;
                        }
                        agsSvrObjName = agsSvrObjNames.Next();
                    }
                    
                }
            }
            catch
            {

            }
            finally
            {
                if (msg != string.Empty)
                {
                    toolStripStatusLabel1.Text = msg;
                    Application.DoEvents();
                }
                else
                {
                    toolStripStatusLabel1.Text = "连接地图服务器成功";
                    Application.DoEvents();
                }
                btnConnectServices.Enabled = true;
            }
            
        }

        private void btnRestLayer_Click(object sender, EventArgs e)
        {
            axMapControl1.Map.ClearLayers();

            Application.DoEvents();
            IMapServerRESTLayer restLayer = LoadMapServices.ConnectMapServerRESTLayer(txtRestUrl.Text);

            axMapControl1.Map.AddLayer(restLayer as ILayer);
        }

        private void btnConnectWMSLayer_Click(object sender, EventArgs e)
        {
            ILayer layer = LoadMapServices.ConnectWMSMapLayer(txtWMSUrl.Text);
            axMapControl1.Map.ClearLayers();
            if (layer != null)
            {                
                axMapControl1.Map.AddLayer(layer);
            }            
        }

        private void btnWMTSLayer_Click(object sender, EventArgs e)
        {
            ILayer layer = LoadMapServices.ConnectWMTSLayer(txtWMTSUrl.Text);

            axMapControl1.Map.ClearLayers();
            if (layer != null)
            {
                axMapControl1.Map.AddLayer(layer);
            }            
        }
    }
}
