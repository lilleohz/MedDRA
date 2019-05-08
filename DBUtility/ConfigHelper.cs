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
            string strdb = "";
            DBConn dc = GetDBConfig(ConfigFile);
            strdb = "Server=" + dc.Server;
            strdb += ";Port=" + dc.Port;
            strdb += ";Database=" + dc.Database;
            strdb += ";UID=" + dc.UID;
            strdb += ";PWD=" + dc.PWD;

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
            if (!File.Exists(ConfigFile))
                WriteDBConfig(ConfigFile, "", "", "", "", "");

            XmlDocument xd = new XmlDocument();
            try
            {
                xd.Load(ConfigFile);
            }
            catch (Exception)
            {
                WriteDBConfig(ConfigFile, "", "", "", "", "");
                xd.Load(ConfigFile);
            }
            XmlNode rootxn = xd.SelectSingleNode("MedMDRSearch");
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
                        //return dc;
                        break;
                }
            }
            return dc;
        }

        /// <summary>
        /// 把数据库配置写入XML文件中
        /// </summary>
        /// <param name="ConfigFile">配置文件名称</param>
        /// <param name="server">服务器地址</param>
        /// <param name="port">服务器端口号</param>
        /// <param name="database">数据集名称</param>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>保存成功返回true</returns>
        public static bool WriteDBConfig(string ConfigFile,string server,string port,string database,string uid,string pwd)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode header = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(header);
            //创建一级节点
            XmlElement rootNode = xmlDoc.CreateElement("MedMDRSearch");
            XmlElement xn = xmlDoc.CreateElement("DBConnection");
            xn.SetAttribute("Server", DESEncrypt.Encrypt(server));
            xn.SetAttribute("Port", DESEncrypt.Encrypt(port));
            xn.SetAttribute("Database", DESEncrypt.Encrypt(database));
            xn.SetAttribute("UID", DESEncrypt.Encrypt(uid));
            xn.SetAttribute("PWD", DESEncrypt.Encrypt(pwd));
            
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
