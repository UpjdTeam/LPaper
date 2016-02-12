using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Infragistics.Win.UltraWinGrid;

namespace BCGM
{
    public partial class BaseColumnManager : Form
    {
        public BaseColumnManager()
        {
            InitializeComponent();
        }

        private void BiWareHouseManager_Load(object sender, EventArgs e)
        {
            columnSetingTableAdapter.Connection.ConnectionString = WmsLogin.WmsConstring;
            this.columnSetingTableAdapter.Fill(this.baseDs.ColumnSeting);
            
            GetDepart();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = WmsLogin.WmsConstring;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }


        private void biEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControlEnable();
        }

        private void biDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(@"确认删除吗？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (uGridDepart.ActiveRow != null && uGridDepart.ActiveRow.Index > -1)
            {
                uGridDepart.ActiveRow.Delete(false);
            }
        }

        private void biGiveup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(@"确认放弃此次修改？", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GetDepart();
            SetControlDisable();
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!baseDs.HasChanges())
            {
                MessageBox.Show(@"无任何修改");
                return;

            }
            uGridDepart.UpdateData();
            columnSetingTableAdapter.Update(baseDs.ColumnSeting);
            MessageBox.Show(@"保存成功");
            SetControlDisable();
        }
        
        /// <summary>
        /// 禁用所有输入框和保存按钮
        /// </summary>
        private void SetControlDisable()
        {
            biSave.Enabled = false;//在不可编辑下保存按钮不可用
            biGiveup.Enabled = false;//在不可编辑下取消按钮不可用
            biEdit.Enabled = true;//在不可编辑下修改按钮可用
            biDelete.Enabled = true;
            
        }

        /// <summary>
        /// 启用所有新增和更新控件时使用的输入和保存按钮
        /// </summary>
        private void SetControlEnable()
        {
            biSave.Enabled = true;//在可编辑下保存按钮可用
            biGiveup.Enabled = true;//在可编辑下取消按钮可用
            
            biEdit.Enabled = false;//在可编辑下修改按钮不可用
            biDelete.Enabled = false;
        }

        private void GetDepart()
        {
            columnSetingTableAdapter.Connection.ConnectionString = WmsLogin.WmsConstring;
            columnSetingTableAdapter.Fill(baseDs.ColumnSeting);
        }


        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
