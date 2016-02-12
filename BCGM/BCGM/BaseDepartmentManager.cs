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
using System.Data.SqlClient;

namespace BCGM
{
    public partial class BaseDepartmentManager : Form
    {
        public BaseDepartmentManager()
        {
            InitializeComponent();
        }

        private void BiWareHouseManager_Load(object sender, EventArgs e)
        {
            
            GetDepart();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = WmsLogin.WmsConstring;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void biAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControlEnable();
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
                var cmd = new SqlCommand("SELECT * FROM buser where uDepartment=@uDepartment");
                cmd.Parameters.AddWithValue("@uDepartment", uGridDepart.ActiveRow.Cells["cDepCode"].Value);
                var wf = new WmsFunction(WmsLogin.WmsConstring);
                if (wf.BoolExistTable(cmd))
                {
                    MessageBox.Show(@"该部门已经被使用，不允许删除");
                    return;
                }

                uGridDepart.ActiveRow.Delete(false);
                biSave.Enabled = true;
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
            if (!dsBiManager.HasChanges())
            {
                MessageBox.Show(@"无任何修改");
                return;

            }
            uGridDepart.UpdateData();
            departmentTableAdapter.Update(dsBiManager.Department);
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
            biAddNew.Enabled = true;//在不可编辑下新增按钮可用
            biEdit.Enabled = true;//在不可编辑下修改按钮可用
            biDelete.Enabled = true;
            uGridDepart.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }

        /// <summary>
        /// 启用所有新增和更新控件时使用的输入和保存按钮
        /// </summary>
        private void SetControlEnable()
        {
            biSave.Enabled = true;//在可编辑下保存按钮可用
            biGiveup.Enabled = true;//在可编辑下取消按钮可用
            biAddNew.Enabled = false;//在可编辑下新增按钮不可用
            biEdit.Enabled = false;//在可编辑下修改按钮不可用
            biDelete.Enabled = false;
            uGridDepart.DisplayLayout.Override.AllowAddNew =
                AllowAddNew.TemplateOnBottom;
        }

        private void GetDepart()
        {
            departmentTableAdapter.Connection.ConnectionString = WmsLogin.WmsConstring;
            departmentTableAdapter.Fill(dsBiManager.Department);
        }

        private void uGridWareHouse_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
        {
            if (!e.Cell.Column.Key.Equals("cDepCode"))
                return;
            var cInvCode = e.NewValue.ToString();
            for (var i = 0; i < uGridDepart.Rows.Count; i++)
            {
                if (i == e.Cell.Row.Index)
                    return;
                if (!cInvCode.Equals(uGridDepart.Rows[i].Cells["cDepCode"].Value.ToString())) continue;
                MessageBox.Show(@"当前编码已经被使用");
                e.Cancel = true;
            }
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
