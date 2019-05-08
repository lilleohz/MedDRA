using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using System.Xml;

namespace MedDRASearch.DBUtility
{
    public class ConfigHelper
    {
        public ConfigHelper()
        { }

        /// <summary>
        /// 读取配置文件组织成连接字串
        /// </summary>
        /// <param name="ConfigFile">需要读取的配置文件</param>
        /// <returns>数据库连接字符串</returns>
        public static string ReadDBConnectString(string ConfigFile)
        {
            string strdb;
            DBConn dc = GetDBConfig(ConfigFile);
            strdb = $"Server={dc.Server};Port={dc.Port};Database={dc.Database};UID={dc.UID};PWD={dc.PWD}";

            return strdb;
        }

        /// <summary>
        /// 读取配置文件,返回数据库配置
        /// </summary>
        /// <param name="ConfigFile">需要读取的配置文件</param>
        /// <returns>数据库配置结构</returns>
        public static DBConn GetDBConfig(string ConfigFile)
        {
            DBConn dc = new DBConn();
            //判断配置文件是否存在
            if (!File.Exists(ConfigFile))
                WriteDBConfig(ConfigFile, dc);

            XmlDocument xd = new XmlDocument();
            //载入配置文件，如果载入失败，重新初始化配置文件
            try
            {
                xd.Load(ConfigFile);
            }
            catch (Exception)
            {
                WriteDBConfig(ConfigFile, dc);
                xd.Load(ConfigFile);
            }
            XmlNode rootxn = xd.SelectSingleNode("MedDRASearch");
            XmlNodeList xnl = rootxn.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                switch (xe.Name)
                {
                    case "DBConnection":
                        dc.Server = DESEncrypt.Decrypt(xe.GetAttribute("Server").ToString());
                        dc.Port = DESEncrypt.Decrypt(xe.GetAttribute("Port").ToString());
                        dc.Database = DESEncrypt.Decrypt(xe.GetAttribute("Database").ToString());
                        dc.UID = DESEncrypt.Decrypt(xe.GetAttribute("UID").ToString());
                        dc.PWD = DESEncrypt.Decrypt(xe.GetAttribute("PWD").ToString());
                        break;
                }
            }
            return dc;
        }

        /// <summary>
        /// 把数据库配置写入XML文件中
        /// </summary>
        /// <param name="ConfigFile">配置文件名称</param>
        /// <param name="dbconn">数据库连接信息对象</param>
        /// <returns>保存成功返回true</returns>
        public static bool WriteDBConfig(string ConfigFile,DBConn dbconn)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode header = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(header);
            //创建一级节点
            XmlElement rootNode = xmlDoc.CreateElement("MedDRASearch");
            XmlElement xn = xmlDoc.CreateElement("DBConnection");
            xn.SetAttribute("Server", DESEncrypt.Encrypt(dbconn.Server));
            xn.SetAttribute("Port", DESEncrypt.Encrypt(dbconn.Port));
            xn.SetAttribute("Database", DESEncrypt.Encrypt(dbconn.Database));
            xn.SetAttribute("UID", DESEncrypt.Encrypt(dbconn.UID));
            xn.SetAttribute("PWD", DESEncrypt.Encrypt(dbconn.PWD));
            
            rootNode.AppendChild(xn);
            xmlDoc.AppendChild(rootNode);

            xmlDoc.Save(ConfigFile);

            return true;
        }

        /// <summary>
        /// 数据库配置模型
        /// </summary>
        [Serializable]
        public class DBConn
        {
            private string _server;
            private string _port="3306";
            private string _database;
            private string _uid;
            private string _pwd;

            /// <summary>
            /// 服务器地址
            /// </summary>
            public string Server
            {
                set { _server = value; }
                get { return _server; }
            }

            /// <summary>
            /// 服务器端口号
            /// </summary>
            public string Port
            {
                set { _port = value; }
                get { return _port; }
            }

            /// <summary>
            /// 数据库名称
            /// </summary>
            public string Database
            {
                set { _database = value; }
                get { return _database; }
            }

            /// <summary>
            /// 用户名
            /// </summary>
            public string UID
            {
                set { _uid = value; }
                get { return _uid; }
            }

            /// <summary>
            /// 用户密码
            /// </summary>
            public string PWD
            {
                set { _pwd = value; }
                get { return _pwd; }
            }
        }
    }
}
