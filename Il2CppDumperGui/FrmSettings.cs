﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il2CppDumperGui
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cbAutoSetDir.Checked = Properties.Settings.Default.AutoSetDir;
            cbExtBin.Checked = Properties.Settings.Default.extBin;
            clbScripts.SetItemChecked(0, Properties.Settings.Default.ghidra);
            clbScripts.SetItemChecked(1, Properties.Settings.Default.ghidra_with_struct);
            clbScripts.SetItemChecked(2, Properties.Settings.Default.ida);
            clbScripts.SetItemChecked(3, Properties.Settings.Default.ida_py3);
            clbScripts.SetItemChecked(4, Properties.Settings.Default.ida_with_struct);
            clbScripts.SetItemChecked(5, Properties.Settings.Default.ida_with_struct_py3);
        }
        private void Save()
        {
            Properties.Settings.Default.AutoSetDir = cbAutoSetDir.Checked;
            Properties.Settings.Default.extBin = cbExtBin.Checked;

            Properties.Settings.Default.ghidra = clbScripts.GetItemChecked(0);
            Properties.Settings.Default.ghidra_with_struct = clbScripts.GetItemChecked(1);
            Properties.Settings.Default.ida = clbScripts.GetItemChecked(2);
            Properties.Settings.Default.ida_py3 = clbScripts.GetItemChecked(3);
            Properties.Settings.Default.ida_with_struct = clbScripts.GetItemChecked(4);
            Properties.Settings.Default.ida_with_struct_py3= clbScripts.GetItemChecked(5);

            Properties.Settings.Default.Save();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Close();
            Save();
        }

        
    }
}
