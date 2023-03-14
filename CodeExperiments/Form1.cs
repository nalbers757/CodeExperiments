using MyClasses;

namespace CodeExperiments
{
    public partial class frmMain : Form
    {
        #region consructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void btnCustomAttribute_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;

            List<string> results = CA_Example.RunMe();
            foreach (var item in results)
            {
                txtResults.Text += $"{item}, ";
            }
        }
        #endregion

        private void btnGenericMath_Click(object sender, EventArgs e)
        {
            txtResults.Text = GenericMath.RunMe().ToString();
        }

        private void btnStringInterpolation_Click(object sender, EventArgs e)
        {
            txtResults.Text = StringInterpolation.RunMe().ToString();
        }

        private void btnListPatterns_Click(object sender, EventArgs e)
        {
            txtResults.Text = ListPatterns.RunMe();
        }

        private void btnRawStringLiteral_Click(object sender, EventArgs e)
        {
            txtResults.Text = RawStringLiterals.RunMe();
        }

        private void btnAutoDefaultStruct_Click(object sender, EventArgs e)
        {
            txtResults.Text = AutoDefaultStruct.RunMe();
        }

        private void btnPatternMatching_Click(object sender, EventArgs e)
        {
            txtResults.Text = MultiplePropertyMatching.RunMe();
        }

        private void btnExtendNameOfScope_Click(object sender, EventArgs e)
        {
            txtResults.Text = ExtendNameOfScope.RunMe();
        }

        private void btnRequiredMembers_Click(object sender, EventArgs e)
        {
            txtResults.Text = RequiredMembers.RunMe();
        }

        private void btnFileAccessModifier_Click(object sender, EventArgs e)
        {
            txtResults.Text = FileAcessModifier1.RunMe();
        }
    }
}