using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static RegExWordSearch.DictListHelper;
using static Utils.SqliteSingleton;

namespace RegExWordSearch
{
    public partial class FormMain : Form
    {
        public static SqliteSingleton sqliteInstance = SqliteSingleton.GetInstance(DictListHelper.DbFileFolder,DictListHelper.DbFileName);
        public FormMain()
        {
            InitializeComponent();
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar.Equals((char)13))
            {
                string text = comboBoxRegex.Text;
                if (!comboBoxRegex.Items.Contains(text))
                    comboBoxRegex.Items.Add(comboBoxRegex.Text);

                //TODO: 在词典搜索匹配text的所有词
                Regex rg = new Regex(text);
                List<string> wordList = new List<string>();
                List<string> diNames2Search = DictListHelper.GetDictsInfo(FormMain.sqliteInstance).Where(i=>i.IsChecked ==1).Select(di=>di.DictName).ToList();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //检查数据库文件夹、数据库文件、数据库表是否存在
            //SqliteHelper.GetDbFileStatus();
            if (sqliteInstance.GetDbFileStatus() != DbStatus.DbIsOk)
            {
                MessageBox.Show("词典不存在，请首先导入词典！",
                    "数据库错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnDictManage.Enabled = false;
                btnShowWordsIndex.Enabled = false;
                return;
            }

            //若库中有词典文件存在，且在搜索组被勾选，则列出被选中词典的词
            //TODO: 按需列出，当拉滚动条时，再从数据库获取新的。单词按照搜索组勾选顺序当一个词典全部显示完毕后再显示后面的词典。

            
        }

        private void BtnImportDict2Db_ClickAsync(object sender, EventArgs e)
        {
            FormImportDict formId = new FormImportDict();
            if (DialogResult.OK == formId.ShowDialog())
            {
                toolStripStatusLabel1.Text = "完成词典文件导入任务。";
                btnDictManage.Enabled = true;
                btnShowWordsIndex.Enabled = true;
            }
        }

        /// <summary>
        /// 选中一个单词。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxWordsIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "选中单词："+listBoxWordsIndex.SelectedValue;
        }

        /// <summary>
        /// 打开词典管理窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDictManage_Click(object sender, EventArgs e)
        {
            FormDictManage formDm = new FormDictManage();
            formDm.ShowDialog();
        }
    }
}
