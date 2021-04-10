using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class frmInsertText : Form
    {
        private Font _selectedFont;

        public Font SelectedFont
        {
            get { return _selectedFont; }
        }
        public string SelectedText
        {
            get { return txtToInsert.Text; }
        }

        public frmInsertText()
        {
            InitializeComponent();
            _selectedFont = txtToInsert.Font;
        }

        private void cmdCustomFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.Font = _selectedFont;
                fontDlg.FontMustExist = true;
                fontDlg.ShowEffects = false;
                fontDlg.ShowColor = false;
                fontDlg.ShowApply = false;
                fontDlg.ScriptsOnly = false;
                if (fontDlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedFont = fontDlg.Font;
                }
            }
        }


        private void txtToInsert_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {

        }
    }
}
