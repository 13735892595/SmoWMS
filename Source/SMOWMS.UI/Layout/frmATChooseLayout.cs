using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmATChooseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((frmAssTemplateChoose)this.Form).updateCheckBox();
        }

        private void plRow_Press(object sender, EventArgs e)
        {
            CheckBox1.Checked = !CheckBox1.Checked;
        }
    }
}