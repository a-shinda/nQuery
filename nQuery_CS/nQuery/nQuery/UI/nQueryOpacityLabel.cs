using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using nQueryLib.nQueryUtil;

namespace nQueryLib.UI
{
    public partial class nQueryOpacityLabel : System.Windows.Forms.Label, InQueryOpacity
    {
        public nQueryOpacityLabel()
        {
            // 適用されていない場合は SupportsTransparentBackColor を true にする
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
            // 背面のコントロールを描画しない Or 背景色が不透明なので背面のコントロールを描画する必要なし
            if (this.BackColor.A == 255)
            {
                base.OnPaintBackground(pevent);
                return;
            }

            // 背面のコントロールを描画
            DrawingUtil.DrawParentWithBackControl(this, pevent);

            // 背景を描画
            DrawingUtil.DrawBackground(this, pevent);
        }

        #region InQueryOpacity メンバ

        public void CallInvokePaintBackground(Control ctrl, PaintEventArgs p)
        {
            this.InvokePaintBackground(ctrl, p);
        }

        public void CallInvokePaint(Control ctrl, PaintEventArgs p)
        {
            this.InvokePaint(ctrl, p);
        }

        #endregion
    }

}
