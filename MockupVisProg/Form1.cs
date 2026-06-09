using System;
using System.Drawing;
using System.Windows.Forms;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class Form1 : Form
    {
        // ── Nav panel hover colors ───────────────────────────────────
        private static readonly Color Nav1Normal = Color.FromArgb(91,  79,  207);
        private static readonly Color Nav1Hover  = Color.FromArgb(74,  62,  190);
        private static readonly Color Nav2Normal = Color.FromArgb(30,  30,  58);
        private static readonly Color Nav2Hover  = Color.FromArgb(46,  46,  74);
        private static readonly Color Nav3Normal = Color.FromArgb(30,  30,  58);
        private static readonly Color Nav3Hover  = Color.FromArgb(46,  46,  74);
        private static readonly Color Nav4Normal = Color.FromArgb(58,  21,  21);
        private static readonly Color Nav4Hover  = Color.FromArgb(74,  37,  37);

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new DarkMenuRenderer();
        }

        // ── Lifecycle ────────────────────────────────────────────────

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                new FormLogin().Show();
                this.Close();
                return;
            }

            RefreshWelcome();
        }

        private void RefreshWelcome()
        {
            lblWelcome.Text = "Halo, " + Session.CurrentUser.Username;
        }

        // ── Akun menu ────────────────────────────────────────────────

        private void tsmiRegistrasi_Click(object sender, EventArgs e)
        {
            using (var form = new FormRegister())
            {
                form.ShowDialog(this);
            }
            if (Session.IsLoggedIn) RefreshWelcome();
        }

        private void tsmiMasukAkun_Click(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                MessageBox.Show(
                    $"Anda sudah login sebagai {Session.CurrentUser.Username}.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new FormLogin())
            {
                form.ShowDialog(this);
            }
            if (Session.IsLoggedIn) RefreshWelcome();
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.Logout();
                new FormLogin().Show();
                this.Close();
            }
        }

        // ── Nav panel clicks ─────────────────────────────────────────

        private void panelNav1_Click(object sender, EventArgs e) => new FormTambah().Show();
        private void panelNav2_Click(object sender, EventArgs e) => new FormRiwayat().Show();
        private void panelNav3_Click(object sender, EventArgs e) => new FormLaporan().Show();
        private void panelNav4_Click(object sender, EventArgs e) => Application.Exit();

        // ── Nav panel hover ──────────────────────────────────────────

        private void panelNav1_MouseEnter(object sender, EventArgs e) => panelNav1.BackColor = Nav1Hover;
        private void panelNav1_MouseLeave(object sender, EventArgs e) => panelNav1.BackColor = Nav1Normal;
        private void panelNav2_MouseEnter(object sender, EventArgs e) => panelNav2.BackColor = Nav2Hover;
        private void panelNav2_MouseLeave(object sender, EventArgs e) => panelNav2.BackColor = Nav2Normal;
        private void panelNav3_MouseEnter(object sender, EventArgs e) => panelNav3.BackColor = Nav3Hover;
        private void panelNav3_MouseLeave(object sender, EventArgs e) => panelNav3.BackColor = Nav3Normal;
        private void panelNav4_MouseEnter(object sender, EventArgs e) => panelNav4.BackColor = Nav4Hover;
        private void panelNav4_MouseLeave(object sender, EventArgs e) => panelNav4.BackColor = Nav4Normal;

        // ── Dark MenuStrip renderer ──────────────────────────────────

        private sealed class DarkMenuRenderer : ToolStripProfessionalRenderer
        {
            public DarkMenuRenderer() : base(new DarkColorTable()) { }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                var rect  = new Rectangle(Point.Empty, e.Item.Size);
                var color = e.Item.Selected
                    ? Color.FromArgb(42, 42, 90)
                    : Color.FromArgb(26, 26, 62);

                e.Graphics.FillRectangle(new SolidBrush(color), rect);
            }

            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(Color.FromArgb(26, 26, 62)), e.AffectedBounds);
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = e.Item.Selected
                    ? Color.White
                    : e.Item.ForeColor;
                base.OnRenderItemText(e);
            }

            protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
            {
                int y = e.Item.Height / 2;
                e.Graphics.DrawLine(
                    new Pen(Color.FromArgb(50, 50, 85)),
                    4, y, e.Item.Width - 4, y);
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }

        private sealed class DarkColorTable : ProfessionalColorTable
        {
            private static readonly Color Base    = Color.FromArgb(26, 26, 62);
            private static readonly Color Hover   = Color.FromArgb(42, 42, 90);
            private static readonly Color Border  = Color.FromArgb(42, 42, 80);

            public override Color MenuItemSelected               => Hover;
            public override Color MenuItemBorder                 => Border;
            public override Color MenuBorder                     => Border;
            public override Color MenuItemSelectedGradientBegin  => Hover;
            public override Color MenuItemSelectedGradientEnd    => Hover;
            public override Color MenuItemPressedGradientBegin   => Hover;
            public override Color MenuItemPressedGradientEnd     => Hover;
            public override Color ToolStripDropDownBackground    => Base;
            public override Color ImageMarginGradientBegin       => Base;
            public override Color ImageMarginGradientMiddle      => Base;
            public override Color ImageMarginGradientEnd         => Base;
            public override Color ToolStripGradientBegin         => Base;
            public override Color ToolStripGradientMiddle        => Base;
            public override Color ToolStripGradientEnd           => Base;
            public override Color MenuStripGradientBegin         => Base;
            public override Color MenuStripGradientEnd           => Base;
        }
    }
}
