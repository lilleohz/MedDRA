using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedDRASearch
{
    public partial class frmMain : Form
    {
        private BLL.meddra bllMeddra = new BLL.meddra();
        private int mark = -1;

        public struct SearchExtent
        {
            public bool sSOC;
            public bool sHLGT;
            public bool sHLT;
            public bool sPT;
            public bool sLLT;
        }
        public class ResultModelNote
        {
            public string Level;
            public Model.meddra ModeleNote;
        }

        private SearchExtent mSE;
        private List<Model.meddra> mSOC, mHLGT, mHLT, mPT, mLLT;
        private TreeNode exactNode;
        private TreeNode containsNode;
        private string mSearchWord;
        private List<TreeNode> nodeList = new List<TreeNode>();     //记录所有的树节点
        public TreeNode node = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mSE.sSOC = true;
            mSE.sHLGT = true;
            mSE.sHLT = true;
            mSE.sPT = true;
            mSE.sLLT = true;

            iniData();
        }

        /// <summary>
        /// 初始化数据库连接，载入基础数据
        /// </summary>
        public void iniData()
        {
            DBUtility.DbHelperMySQL.connectionString = DBUtility.ConfigHelper.ReadDBConnectString(Application.StartupPath + "\\config.xml");
            if (DBUtility.DbHelperMySQL.ServerTest(DBUtility.DbHelperMySQL.connectionString))
            {
                btnSearch.Enabled = true;
                iniTreeview();
                iniMedDRAData();
            }else
            {
                btnSearch.Enabled = false;
                MessageBox.Show("服务器连接不上！", "MedDRASearch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 初始化右边的查询返回结果树结构
        /// </summary>
        private void iniTreeview()
        {
            tvResults.Nodes.Clear();
            exactNode = new TreeNode();
            exactNode.Text = "完全匹配";
            exactNode.Name = "exact";
            exactNode.ImageIndex = 6;
            exactNode.SelectedImageIndex = 6;
            exactNode.NodeFont = new Font("宋体", 9, FontStyle.Bold);
            ResultModelNote rmn1 = new ResultModelNote();
            rmn1.Level = "";
            exactNode.Tag = rmn1;
            tvResults.Nodes.Add(exactNode);

            containsNode = new TreeNode();
            containsNode.Text = "包含关键词";
            containsNode.Name = "contains";
            containsNode.ImageIndex = 6;
            containsNode.SelectedImageIndex = 6;
            containsNode.NodeFont = new Font("宋体", 9, FontStyle.Bold);

            ResultModelNote rmn2 = new ResultModelNote();
            rmn2.Level = "";
            containsNode.Tag = rmn2;
            tvResults.Nodes.Add(containsNode);
        }

        /// <summary>
        /// 初始化主目录树和查询范围列表,只载入SOCs数据
        /// </summary>
        public void iniMedDRAData()
        {
            tvMedDra.Nodes.Clear();
            lvSOC.Items.Clear();
            nodeList.Clear();

            List<Model.meddra> soclist = bllMeddra.GetModelList("1=1 group by soc_code");
            foreach (Model.meddra socmodel in soclist)
            {
                TreeNode tn = tvMedDra.Nodes.Add($"{socmodel.soc_name}({socmodel.soc_code})");
                tn.Name = socmodel.soc_code;
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;
                tn.Tag = "soc";
                nodeList.Add(tn);

                ListViewItem lvi = lvSOC.Items.Add(socmodel.soc_name);
                lvi.Tag = socmodel;
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            iniMedDRAData();
        }

        private TreeNode FindNodeByLevelCode(string level, string mcode)
        {
            for (int i = 0; i < nodeList.Count; i++)
            {
                if (nodeList[i].Name == mcode)
                {
                    if ((string)nodeList[i].Tag == level)
                        return nodeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// 在主目录树中定位具体的项,如果还未载入数据的载入此数据
        /// </summary>
        /// <param name="level">定位的层级</param>
        /// <param name="selectnode">需要选中的节点数据</param>
        private void LocationNode(string level, Model.meddra selectnode)
        {
            TreeNode soc_tn, hlgt_tn, hlt_tn, pt_tn, llt_tn;

            switch (level)
            {
                case "soc":
                    soc_tn = FindNodeByLevelCode("soc", selectnode.soc_code);
                    mainTreeLoad("soc", soc_tn.Name, soc_tn);
                    tvMedDra.SelectedNode = FindNodeByLevelCode("soc", selectnode.soc_code);
                    break;
                case "hlgt":
                    soc_tn = FindNodeByLevelCode("soc", selectnode.soc_code);
                    mainTreeLoad("soc", soc_tn.Name, soc_tn);
                    hlgt_tn = FindNodeByLevelCode("hlgt", selectnode.hlgt_code);
                    mainTreeLoad("hlgt", hlgt_tn.Name, hlgt_tn);
                    tvMedDra.SelectedNode = hlgt_tn;
                    break;
                case "hlt":
                    soc_tn = FindNodeByLevelCode("soc", selectnode.soc_code);
                    mainTreeLoad("soc", soc_tn.Name, soc_tn);
                    hlgt_tn = FindNodeByLevelCode("hlgt", selectnode.hlgt_code);
                    mainTreeLoad("hlgt", hlgt_tn.Name, hlgt_tn);
                    hlt_tn = FindNodeByLevelCode("hlt", selectnode.hlt_code);
                    mainTreeLoad("hlt", hlt_tn.Name, hlt_tn);
                    tvMedDra.SelectedNode = hlt_tn;
                    break;
                case "pt":
                    soc_tn = FindNodeByLevelCode("soc", selectnode.soc_code);
                    mainTreeLoad("soc", soc_tn.Name, soc_tn);
                    hlgt_tn = FindNodeByLevelCode("hlgt", selectnode.hlgt_code);
                    mainTreeLoad("hlgt", hlgt_tn.Name, hlgt_tn);
                    hlt_tn = FindNodeByLevelCode("hlt", selectnode.hlt_code);
                    mainTreeLoad("hlt", hlt_tn.Name, hlt_tn);
                    pt_tn = FindNodeByLevelCode("pt", selectnode.pt_code);
                    mainTreeLoad("pt", pt_tn.Name, pt_tn);
                    tvMedDra.SelectedNode = pt_tn;
                    break;
                case "llt":
                    soc_tn = FindNodeByLevelCode("soc", selectnode.soc_code);
                    mainTreeLoad("soc", soc_tn.Name, soc_tn);
                    hlgt_tn = FindNodeByLevelCode("hlgt", selectnode.hlgt_code);
                    mainTreeLoad("hlgt", hlgt_tn.Name, hlgt_tn);
                    hlt_tn = FindNodeByLevelCode("hlt", selectnode.hlt_code);
                    mainTreeLoad("hlt", hlt_tn.Name, hlt_tn);
                    pt_tn = FindNodeByLevelCode("pt", selectnode.pt_code);
                    mainTreeLoad("pt", pt_tn.Name, pt_tn);
                    llt_tn = FindNodeByLevelCode("llt", selectnode.llt_code);
                    mainTreeLoad("llt", llt_tn.Name, llt_tn);
                    tvMedDra.SelectedNode = llt_tn;
                    break;
            }
        }

        /// <summary>
        /// 按层级载入数据
        /// </summary>
        /// <param name="prelevel">需要载入的父级</param>
        /// <param name="nodecode">编码</param>
        /// <param name="pNode">载入的节点</param>
        private void mainTreeLoad(string prelevel, string nodecode, TreeNode pNode)
        {
            if (pNode.Nodes.Count > 0)
                return;

            switch (prelevel)
            {
                case "soc":
                    List<Model.meddra> hlgtlist = bllMeddra.GetModelList($"soc_code = '{pNode.Name}' group by hlgt_code");
                    foreach (Model.meddra hlgtmodel in hlgtlist)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = $"{hlgtmodel.hlgt_name}({hlgtmodel.hlgt_code})";
                        tn.Name = hlgtmodel.hlgt_code;
                        tn.ImageIndex = 1;
                        tn.SelectedImageIndex = 1;
                        tn.Tag = "hlgt";
                        pNode.Nodes.Add(tn);
                        nodeList.Add(tn);
                    }
                    break;
                case "hlgt":
                    List<Model.meddra> hltlist = bllMeddra.GetModelList($"hlgt_code = '{pNode.Name}' group by hlt_code");
                    foreach (Model.meddra hltmodel in hltlist)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = hltmodel.hlt_name + "(" + hltmodel.hlt_code + ")";
                        tn.Name = hltmodel.hlt_code;
                        tn.ImageIndex = 2;
                        tn.SelectedImageIndex = 2;
                        tn.Tag = "hlt";
                        pNode.Nodes.Add(tn);
                        nodeList.Add(tn);
                    }
                    break;
                case "hlt":
                    List<Model.meddra> ptlist = bllMeddra.GetModelList($"hlt_code = '{pNode.Name}' group by pt_code");
                    foreach (Model.meddra ptmodel in ptlist)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = ptmodel.pt_name + "(" + ptmodel.pt_code + ")";
                        tn.Name = ptmodel.pt_code;
                        tn.ImageIndex = 3;
                        tn.SelectedImageIndex = 3;
                        tn.Tag = "pt";
                        pNode.Nodes.Add(tn);
                        nodeList.Add(tn);
                    }
                    break;
                case "pt":
                    List<Model.meddra> lltlist = bllMeddra.GetModelList($"pt_code = '{pNode.Name}' group by llt_code");
                    foreach (Model.meddra lltmodel in lltlist)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = lltmodel.llt_name + "(" + lltmodel.llt_code + ")";
                        tn.Name = lltmodel.llt_code;
                        tn.ImageIndex = 4;
                        tn.SelectedImageIndex = 4;
                        tn.Tag = "llt";
                        pNode.Nodes.Add(tn);
                        nodeList.Add(tn);
                    }
                    break;
                case "llt":
                    break;
            }
            pNode.Expand();
        }


        private void tvMedDra_DoubleClick(object sender, EventArgs e)
        {
            if (tvMedDra.Nodes.Count > 0 && (int)tvMedDra.SelectedNode.Nodes.Count == 0)
            {
                mainTreeLoad((string)tvMedDra.SelectedNode.Tag, tvMedDra.SelectedNode.Name, tvMedDra.SelectedNode);
            }
            tvMedDra.SelectedNode.Expand();
        }

        private void tvMedDra_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvMedDra_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void SearchCode()
        {
            string strResults = "查询返回结果：";
            string strDetails = "内容：";
            int resultsCount = 0;
            mSearchWord = txtSearch.Text;
            mSearchWord = mSearchWord.Trim();
            if (mSearchWord.Length == 0)
            {
                MessageBox.Show("请输入搜索词再查询！", "MedDRA 数据查询", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //处理搜索SOCs范围
            string strSOCs = "";
            foreach (ListViewItem lvi in lvSOC.SelectedItems)
            {
                Model.meddra md = (Model.meddra)lvi.Tag;
                strSOCs = $"{strSOCs}or (soc_name = '{md.soc_name}') ";
            }

            if (strSOCs.Length > 0)
            {
                strSOCs = strSOCs.Substring(2);
                strSOCs = $" and ({strSOCs})";
            }

            //根据搜索设置查询不同级别的数据
            if (mSE.sSOC)
            {
                mSOC = bllMeddra.GetModelList($" soc_name like '%{mSearchWord}%'{strSOCs} group by soc_code");
                if (mSOC.Count > 0)
                    strDetails = $"{strDetails}SOC({mSOC.Count().ToString()}) ";
                resultsCount += mSOC.Count();
            }
            if (mSE.sHLGT)
            {
                mHLGT = bllMeddra.GetModelList($" hlgt_name like '%{mSearchWord}%'{strSOCs} group by hlgt_code");
                if (mHLGT.Count > 0)
                    strDetails = $"{strDetails}HLGT({mHLGT.Count().ToString()}) ";
                resultsCount += mHLGT.Count();
            }
            if (mSE.sHLT)
            {
                mHLT = bllMeddra.GetModelList($" hlt_name like '%{mSearchWord}%'{strSOCs} group by hlt_code");
                if (mHLT.Count > 0)
                    strDetails = string.Format("{0}HLT({1}) ", strDetails, mHLT.Count().ToString());
                resultsCount += mHLT.Count();
            }
            if (mSE.sPT)
            {
                mPT = bllMeddra.GetModelList($" pt_name like '%{mSearchWord}%'{strSOCs} group by pt_code");
                if (mPT.Count > 0)
                    strDetails = $"{strDetails}PT({mPT.Count().ToString()}) ";
                resultsCount += mPT.Count();
            }
            if (mSE.sLLT)
            {
                mLLT = bllMeddra.GetModelList($" llt_name like '%{mSearchWord}%'{strSOCs} group by llt_code");
                if (mLLT.Count > 0)
                    strDetails = $"{strDetails}LLT({mLLT.Count().ToString()}) ";
                resultsCount += mLLT.Count();
            }

            lblResults.Text = strResults + resultsCount.ToString();
            lblDetails.Text = strDetails;

            //把新的搜索关键词添加到显示框中，当这个词已经存在，把这个词置前到首条
            bool isExist = false;
            int itemIndex = 0;
            for (int i = 0; i < lbHistroy.Items.Count; i++)
            {
                if (lbHistroy.Items[i].ToString() == mSearchWord)
                {
                    isExist = true;
                    itemIndex = i;
                }
            }
            if (!isExist)
                lbHistroy.Items.Insert(0, mSearchWord);
            else
            {
                lbHistroy.Items.RemoveAt(itemIndex);
                lbHistroy.Items.Insert(0, mSearchWord);
            }

            //按当前选中的标签在树型框中显示查询结果
            iniTreeview();
            if (resultsCount > 0)
            {
                loadResultsData(tcResultOption.SelectedTab.Text);
                tcResultOption.Enabled = true;
                tvResults.Enabled = true;
            }
            else
            {
                tcResultOption.Enabled = false;
                tvResults.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCode();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            iniTreeview();
            tcResultOption.Enabled = false;
            tvResults.Enabled = false;
        }

        private void cbSOC_CheckedChanged(object sender, EventArgs e)
        {
            mSE.sSOC = cbSOC.Checked;
        }

        private void tcResultOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            iniTreeview();
            loadResultsData(tcResultOption.SelectedTab.Text);
        }

        private void loadResultsData(string datalevel)
        {
            int exactCount = 0;
            int containsCount = 0;
            switch (datalevel)
            {
                case "HLGT":
                    foreach (Model.meddra lhlgt in mHLGT)
                    {
                        TreeNode tnhlgt = new TreeNode();
                        tnhlgt.Text = lhlgt.hlgt_name + "(" + lhlgt.hlgt_code + ")";
                        tnhlgt.Name = lhlgt.hlgt_code;
                        tnhlgt.ImageIndex = 1;
                        tnhlgt.SelectedImageIndex = 1;
                        ResultModelNote hlgt_rmn = new ResultModelNote();
                        hlgt_rmn.Level = "hlgt";
                        hlgt_rmn.ModeleNote = lhlgt;
                        tnhlgt.Tag = hlgt_rmn;
                        TreeNode tnsoc = new TreeNode();
                        tnsoc.Text = lhlgt.soc_name + "(" + lhlgt.soc_code + ")";
                        tnsoc.Name = lhlgt.soc_code;
                        tnsoc.ImageIndex = 0;
                        tnsoc.SelectedImageIndex = 0;
                        ResultModelNote soc_rmn = new ResultModelNote();
                        soc_rmn.Level = "soc";
                        soc_rmn.ModeleNote = lhlgt;
                        tnsoc.Tag = soc_rmn;
                        if (lhlgt.hlgt_name == mSearchWord)
                        {
                            exactNode.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            exactCount++;
                        }
                        else
                        {
                            containsNode.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            containsCount++;
                        }
                    }
                    break;
                case "HLT":
                    foreach (Model.meddra lhlt in mHLT)
                    {
                        TreeNode tnhlt = new TreeNode();
                        tnhlt.Text = lhlt.hlt_name + "(" + lhlt.hlt_code + ")";
                        tnhlt.Name = lhlt.hlt_code;
                        tnhlt.ImageIndex = 2;
                        tnhlt.SelectedImageIndex = 2;
                        ResultModelNote hlt_rmn = new ResultModelNote();
                        hlt_rmn.Level = "hlt";
                        hlt_rmn.ModeleNote = lhlt;
                        tnhlt.Tag = hlt_rmn;
                        TreeNode tnhlgt = new TreeNode();
                        tnhlgt.Text = lhlt.hlgt_name + "(" + lhlt.hlgt_code + ")";
                        tnhlgt.Name = lhlt.hlgt_code;
                        tnhlgt.ImageIndex = 1;
                        tnhlgt.SelectedImageIndex = 1;
                        ResultModelNote hlgt_rmn = new ResultModelNote();
                        hlgt_rmn.Level = "hlgt";
                        hlgt_rmn.ModeleNote = lhlt;
                        tnhlgt.Tag = hlgt_rmn;
                        TreeNode tnsoc = new TreeNode();
                        tnsoc.Text = lhlt.soc_name + "(" + lhlt.soc_code + ")";
                        tnsoc.Name = lhlt.soc_code;
                        tnsoc.ImageIndex = 0;
                        tnsoc.SelectedImageIndex = 0;
                        ResultModelNote soc_rmn = new ResultModelNote();
                        soc_rmn.Level = "soc";
                        soc_rmn.ModeleNote = lhlt;
                        tnsoc.Tag = soc_rmn;
                        if (lhlt.hlt_name == mSearchWord)
                        {
                            exactNode.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            exactCount++;
                        }
                        else
                        {
                            containsNode.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            containsCount++;
                        }
                    }
                    break;
                case "PT":
                    foreach (Model.meddra lpt in mPT)
                    {
                        TreeNode tnpt = new TreeNode();
                        tnpt.Text = lpt.pt_name + "(" + lpt.pt_code + ")";
                        tnpt.Name = lpt.pt_code;
                        tnpt.ImageIndex = 3;
                        tnpt.SelectedImageIndex = 3;
                        ResultModelNote pt_rmn = new ResultModelNote();
                        pt_rmn.Level = "pt";
                        pt_rmn.ModeleNote = lpt;
                        tnpt.Tag = pt_rmn;
                        TreeNode tnhlt = new TreeNode();
                        tnhlt.Text = lpt.hlt_name + "(" + lpt.hlt_code + ")";
                        tnhlt.Name = lpt.hlgt_code;
                        tnhlt.ImageIndex = 2;
                        tnhlt.SelectedImageIndex = 2;
                        ResultModelNote hlt_rmn = new ResultModelNote();
                        hlt_rmn.Level = "hlt";
                        hlt_rmn.ModeleNote = lpt;
                        tnhlt.Tag = hlt_rmn;
                        TreeNode tnhlgt = new TreeNode();
                        tnhlgt.Text = lpt.hlgt_name + "(" + lpt.hlgt_code + ")";
                        tnhlgt.Name = lpt.hlgt_code;
                        tnhlgt.ImageIndex = 1;
                        tnhlgt.SelectedImageIndex = 1;
                        ResultModelNote hlgt_rmn = new ResultModelNote();
                        hlgt_rmn.Level = "hlgt";
                        hlgt_rmn.ModeleNote = lpt;
                        tnhlgt.Tag = hlgt_rmn;
                        TreeNode tnsoc = new TreeNode();
                        tnsoc.Text = lpt.soc_name + "(" + lpt.soc_code + ")";
                        tnsoc.Name = lpt.soc_code;
                        tnsoc.ImageIndex = 0;
                        tnsoc.SelectedImageIndex = 0;
                        ResultModelNote soc_rmn = new ResultModelNote();
                        soc_rmn.Level = "soc";
                        soc_rmn.ModeleNote = lpt;
                        tnsoc.Tag = soc_rmn;
                        if (lpt.pt_name == mSearchWord)
                        {
                            exactNode.Nodes.Add(tnpt);
                            tnpt.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            exactCount++;
                        }
                        else
                        {
                            containsNode.Nodes.Add(tnpt);
                            tnpt.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            containsCount++;
                        }
                    }
                    break;
                case "LLT":
                    foreach (Model.meddra lllt in mLLT)
                    {
                        TreeNode tnllt = new TreeNode();
                        tnllt.Text = lllt.llt_name + "(" + lllt.llt_code + ")";
                        tnllt.Name = lllt.llt_code;
                        tnllt.ImageIndex = 4;
                        tnllt.SelectedImageIndex = 4;
                        ResultModelNote llt_rmn = new ResultModelNote();
                        llt_rmn.Level = "llt";
                        llt_rmn.ModeleNote = lllt;
                        tnllt.Tag = llt_rmn;
                        TreeNode tnpt = new TreeNode();
                        tnpt.Text = lllt.pt_name + "(" + lllt.pt_code + ")";
                        tnpt.Name = lllt.pt_code;
                        tnpt.ImageIndex = 3;
                        tnpt.SelectedImageIndex = 3;
                        ResultModelNote pt_rmn = new ResultModelNote();
                        pt_rmn.Level = "pt";
                        pt_rmn.ModeleNote = lllt;
                        tnpt.Tag = pt_rmn;
                        TreeNode tnhlt = new TreeNode();
                        tnhlt.Text = lllt.hlt_name + "(" + lllt.hlt_code + ")";
                        tnhlt.Name = lllt.hlgt_code;
                        tnhlt.ImageIndex = 2;
                        tnhlt.SelectedImageIndex = 2;
                        ResultModelNote hlt_rmn = new ResultModelNote();
                        hlt_rmn.Level = "hlt";
                        hlt_rmn.ModeleNote = lllt;
                        tnhlt.Tag = hlt_rmn;
                        TreeNode tnhlgt = new TreeNode();
                        tnhlgt.Text = lllt.hlgt_name + "(" + lllt.hlgt_code + ")";
                        tnhlgt.Name = lllt.hlgt_code;
                        tnhlgt.ImageIndex = 1;
                        tnhlgt.SelectedImageIndex = 1;
                        ResultModelNote hlgt_rmn = new ResultModelNote();
                        hlgt_rmn.Level = "hlgt";
                        hlgt_rmn.ModeleNote = lllt;
                        tnhlgt.Tag = hlgt_rmn;
                        TreeNode tnsoc = new TreeNode();
                        tnsoc.Text = lllt.soc_name + "(" + lllt.soc_code + ")";
                        tnsoc.Name = lllt.soc_code;
                        tnsoc.ImageIndex = 0;
                        tnsoc.SelectedImageIndex = 0;
                        ResultModelNote soc_rmn = new ResultModelNote();
                        soc_rmn.Level = "soc";
                        soc_rmn.ModeleNote = lllt;
                        tnsoc.Tag = soc_rmn;
                        if (lllt.llt_name == mSearchWord)
                        {
                            exactNode.Nodes.Add(tnllt);
                            tnllt.Nodes.Add(tnpt);
                            tnpt.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            exactCount++;
                        }
                        else
                        {
                            containsNode.Nodes.Add(tnllt);
                            tnllt.Nodes.Add(tnpt);
                            tnpt.Nodes.Add(tnhlt);
                            tnhlt.Nodes.Add(tnhlgt);
                            tnhlgt.Nodes.Add(tnsoc);
                            containsCount++;
                        }
                    }
                    break;
            }
            exactNode.Text = exactNode.Text + " - " + exactCount.ToString();
            containsNode.Text = containsNode.Text + " - " + containsCount.ToString();
            exactNode.ExpandAll();
        }

        private void lbHistroy_DoubleClick(object sender, EventArgs e)
        {
            if (lbHistroy.SelectedItems.Count > 0)
            {
                txtSearch.Text = lbHistroy.SelectedItem.ToString();
                SearchCode();
            }
        }

        private void tvResults_DoubleClick(object sender, EventArgs e)
        {
            ResultModelNote rmn = (ResultModelNote)tvResults.SelectedNode.Tag;
            LocationNode(rmn.Level, rmn.ModeleNote);
            tvResults.SelectedNode.Expand();
            tvMedDra.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tvResults_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            if (tvResults.SelectedNode == null)
                return;

            TreeNode tn = tvResults.SelectedNode;
            ResultModelNote rmn = new ResultModelNote();
            rmn = (ResultModelNote)tn.Tag;
            if (rmn.Level == "")
                return;

            if ((e.X >= tn.Bounds.X) && (e.X <= tn.Bounds.Right) && (e.Y >= tn.Bounds.Y) && (e.Y <= tn.Bounds.Bottom))
                menuPop.Show(tvResults, e.X, e.Y);
        }

        private void mnuLocation_Click(object sender, EventArgs e)
        {
            ResultModelNote rmn = (ResultModelNote)tvResults.SelectedNode.Tag;
            LocationNode(rmn.Level, rmn.ModeleNote);
            //tvResults.SelectedNode.Expand();
            tvMedDra.Focus();
        }

        private void tvResults_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = tvResults.GetNodeAt(e.X, e.Y);
                if (tn != null)
                {
                    tvResults.SelectedNode = tn;
                }
            }
        }

        private void mnuCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tvResults.SelectedNode.Text);
        }

        private void llbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lvi in lvSOC.SelectedItems)
            {
                lvi.Selected = false;
            }
        }

        private void lblConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfig fc = new frmConfig();
            if(fc.ShowDialog() == DialogResult.OK)
                iniData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmConfig fc = new frmConfig();
            if (fc.ShowDialog() == DialogResult.OK)
                iniData();
        }

        private void cbHGLT_CheckedChanged(object sender, EventArgs e)
        {
            mSE.sHLGT = cbHGLT.Checked;
        }

        private void cbHLT_CheckedChanged(object sender, EventArgs e)
        {
            mSE.sHLT = cbHLT.Checked;
        }

        private void cbPT_CheckedChanged(object sender, EventArgs e)
        {
            mSE.sPT = cbPT.Checked;
        }

        private void cbLLT_CheckedChanged(object sender, EventArgs e)
        {
            mSE.sLLT = cbLLT.Checked;
        }
    }
}

