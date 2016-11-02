using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using ESRI.ArcGIS.GISClient;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;

namespace AccessArcGisMapServer
{
    class LoadMapServices
    {
        private static Bitmap getMapTileImg(ITiledMapServer2 pTileMapServer2, string mapName, 
            int l, int r, int c, string format)
        {
            int f = 0;
            switch (format)
            {
                case "PNG":
                    f = 0;
                    break;
                case "PNG24":
                    f = 1;
                    break;
                case "PNG32":
                    f = 2;
                    break;
                case "JPEG":
                    f = 3;
                    break;
                default:
                    f = 0;
                    break;
            }

            byte[] imgTile;
            try
            {
                imgTile = pTileMapServer2.GetMapTileEx(mapName, l, r, c, f);
                MemoryStream ms = new MemoryStream(imgTile);
                Bitmap bmp = new Bitmap(ms);

                return bmp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object LoadMapServer(string url, string agsSvrObjNameStr)
        {
            IPropertySet propSet = new PropertySetClass();
            propSet.SetProperty("url", url);

            IAGSServerConnection agsConn = null;

            try
            {
                IAGSServerConnectionFactory agsConnFact = new AGSServerConnectionFactoryClass();
                agsConn = agsConnFact.Open(propSet, 0);
                if (agsConn == null)
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }            

            IAGSServerObjectName agsSvrObjName = null;
            IAGSServerObjectName tempSvrObjName = null;
            IAGSEnumServerObjectName agsSvrObjNames = agsConn.ServerObjectNames;
            if (agsSvrObjNames == null)
            {
                return null;
            }
            else
            {
                agsSvrObjNames.Reset();
                tempSvrObjName = agsSvrObjNames.Next();
                while (tempSvrObjName != null)
                {
                    string sName = tempSvrObjName.Name;
                    string sType = tempSvrObjName.Type;
                    if (sName.ToUpper() == agsSvrObjNameStr.ToUpper()
                        && sType.ToUpper() == "MAPSERVER")
                    {
                        agsSvrObjName = tempSvrObjName;
                        break;
                    }

                    tempSvrObjName = agsSvrObjNames.Next();
                }
            }

            if (agsSvrObjName != null)
            {
                object mapSvrIntf = (agsSvrObjName as IName).Open();
                if (mapSvrIntf != null)
                {
                    if (mapSvrIntf is IMapServer)
                    {
                        IMapServer mapServer = mapSvrIntf as IMapServer;
                        string defaultMapName = mapServer.DefaultMapName;

                        IMapServerLayer mapServerLayer = new MapServerLayerClass();
                        mapServerLayer.ServerConnect(agsSvrObjName, defaultMapName);

                        return mapServerLayer as ILayer;
                    }
                    else
                    if (mapSvrIntf is ITiledMapServer2)
                    {
                        IMapServer ms = mapSvrIntf as IMapServer;
                        

                        ITiledMapServer2 tiledMapServer = mapSvrIntf as ITiledMapServer2;

                        ITileCacheInfo cacheInfo = tiledMapServer.GetTileCacheInfo("Layers");
                        if (cacheInfo != null)
                        {
                            int count = cacheInfo.LODInfos.Count;
                            ILODInfo lodInfo = cacheInfo.LODInfos.get_Element(0);

                            return getMapTileImg(tiledMapServer, "Layers", lodInfo.LevelID, 1, 1, "PNG");
                        }
                        

                        return null;
                    }
                    else
                    {
                        IMapServer mapServer = mapSvrIntf as IMapServer;
                        string defaultMapName = mapServer.DefaultMapName;

                        IMapServerLayer mapServerLayer = new MapServerLayerClass();
                        mapServerLayer.ServerConnect(agsSvrObjName, defaultMapName);

                        return mapServerLayer as ILayer;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static string GetServices(string url, out IAGSEnumServerObjectName agsSvrObjNames)
        {
            string retMsg = string.Empty;

            IPropertySet propSet = new PropertySetClass();
            propSet.SetProperty("url", url);

            IAGSServerConnection agsConn = null;

            try
            {
                IAGSServerConnectionFactory agsConnFact = new AGSServerConnectionFactoryClass();
                agsConn = agsConnFact.Open(propSet, 0);
                if (agsConn == null)
                {
                    retMsg = "打开服务器连接失败";
                }
            }
            catch (Exception ex)
            {
                retMsg = "打开服务器连接失败：" + ex.Message;
            }
            agsSvrObjNames = agsConn.ServerObjectNames;
            if (agsSvrObjNames == null)
            {
                retMsg = "连接服务器成功，但是获取服务列表失败";
            }

            return retMsg;
        }

        public static object GetServerLayer(IAGSServerObjectName agsSvrObjName, out string msg)
        {
            msg = string.Empty;
            try
            {
                object mapSvrIntf = (agsSvrObjName as IName).Open();
                if (mapSvrIntf != null)
                {
                    if (mapSvrIntf is IMapServer)
                    {
                        IMapServer mapServer = mapSvrIntf as IMapServer;
                        string defaultMapName = mapServer.DefaultMapName;

                        IMapServerLayer mapServerLayer = new MapServerLayerClass();
                        mapServerLayer.ServerConnect(agsSvrObjName, defaultMapName);

                        return mapServerLayer as ILayer;
                    }
                    else
                    /*
                    if (mapSvrIntf is ITiledMapServer2)
                    {
                        IMapServer ms = mapSvrIntf as IMapServer;


                        ITiledMapServer2 tiledMapServer = mapSvrIntf as ITiledMapServer2;

                        ITileCacheInfo cacheInfo = tiledMapServer.GetTileCacheInfo("Layers");
                        if (cacheInfo != null)
                        {
                            int count = cacheInfo.LODInfos.Count;
                            ILODInfo lodInfo = cacheInfo.LODInfos.get_Element(0);

                            return getMapTileImg(tiledMapServer, "Layers", lodInfo.LevelID, 1, 1, "PNG");
                        }


                        return null;
                    }
                    else
                     * */
                    {
                        IMapServer mapServer = mapSvrIntf as IMapServer;
                        string defaultMapName = mapServer.DefaultMapName;

                        IMapServerLayer mapServerLayer = new MapServerLayerClass();
                        mapServerLayer.ServerConnect(agsSvrObjName, defaultMapName);

                        return mapServerLayer as ILayer;
                    }
                }
                else
                {
                    msg = "打开地图服务对象失败";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msg = "获取地图服务对象失败：\r\n" + ex.Message;
                return null;
            }
        }

        public static IMapServerRESTLayer ConnectMapServerRESTLayer(string restLayerUrl)
        {
            IMapServerRESTLayer layer = new MapServerRESTLayerClass();
            layer.Connect(restLayerUrl);

            return layer;
        }

        public static ILayer ConnectWMSMapLayer(string wmsLayerUrl)
        {
            try
            {
                ILayer retLayer = new GroupLayerClass();
                retLayer.Name = "WMS Group Layer";

                IPropertySet propSet = new PropertySetClass();
                propSet.SetProperty("URL", wmsLayerUrl);

                IWMSConnectionName wmscn;
                //wscn = new WMSConnectionNameClass();
                //wscn.ConnectionProperties = propSet;

                IWMSConnectionFactory wmscf = new WMSConnectionFactoryClass();
                IWMSConnection wmsc = wmscf.Open(propSet, 0, null);
                wmscn = wmsc.FullName as IWMSConnectionName;

                ILayerFactory layerFactory = new EngineWMSMapLayerFactoryClass();

                if (layerFactory.get_CanCreate(wmscn))
                {
                    ILayer layer;
                    IEnumLayer layers = layerFactory.Create(wmscn);
                    if (layers != null)
                    {
                        layers.Reset();
                        layer = layers.Next();
                        while (layer != null)
                        {
                            if (layer is IWMSMapLayer)
                            {
                                (retLayer as IGroupLayer).Add(layer);
                            }
                            layer = layers.Next();
                        }
                    }

                }

                return retLayer;
            }
            catch (Exception e)
            {
                MessageBox.Show("连接WMS服务失败：" + e);
                return null;
            }
            
        }

        public static ILayer ConnectWMTSLayer(string wmtsLayerUrl)
        {
            try
            {
                IPropertySet propSet = new PropertySetClass();
                propSet.SetProperty("URL", wmtsLayerUrl);

                IWMTSConnectionFactory wmtscf = new WMTSConnectionFactoryClass();
                IWMTSConnection wmtsc = wmtscf.Open(propSet, 0, null);

                IWMTSLayer wmtsLayer = new WMTSLayerClass();
                if (wmtsLayer.Connect(wmtsc.FullName))
                {
                    return wmtsLayer as ILayer;
                } else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("连接WMTS服务失败：" + e);
                return null;
            }
        }
    }
}
