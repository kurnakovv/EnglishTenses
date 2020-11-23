using EnglishTenses.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Simple

        #region SimpleTable

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.MySimpleTable,
                             "Simple (простое настоящее)");
        }

        #endregion

        #region FuturePresentPastTable

        private void futureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.FeatureSimple,
                             "Future simple (будующее простое)");
        }

        private void presentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PresentSimple,
                             "Present simple (настоящее простое)");
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PastSimple,
                             "Past simple (прошедшее простое)");
        }

        #endregion

        #region Future ?+-

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrativeFeatureSimple,
                             "Interrogative future simple (Вопросительное будующее простое)");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositiveFeatureSimple,
                             "Positive future simple (Утвердительное будующее простое)");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativeFeatureSimple,
                             "Negative future simple (Отрицательное будующее простое)");
        }

        #endregion

        #region Present ?+-

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrativePresentSimple,
                             "Interrogative present simple (Вопросительное настоящее простое)");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositivePresentSimple,
                             "Positive present simple (Утвердительное настоящее простое)");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativePresentSimple,
                             "Negative present simple (Отрицательное настоящее простое)");
        }

        #endregion

        #region Past ?+-

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrgativePastSimple,
                             "Interrogative present simple (Вопросительное прошедшее простое)");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositivePastSimple,
                             "Positive past simple (Утвердительное прошедшее простое)");
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativePastSimple,
                             "Negative past simple (Отрицательное прошедшее простое)");
        }

        #endregion

        #endregion

        #region Continuous

        #region ContinuousTable

        private void continiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.MyContinuousTable,
                             "Continuous (Длительное)");
        }

        #endregion

        #region FuturePresentPastTable

        private void futureToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.FutureContinuous,
                             "Future continuous (Будующее длительное)");
        }

        private void perfectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PresentContinuous,
                             "Present continuous (Настоящее длительное)");
        }

        private void pastToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PastContinuous,
                             "Past continuous (Прошедшее длительное)");
        }

        #endregion

        #region Future ?+-

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrotiveFeatureContinuous,
                             "Interrogative future continuous (Вопросительное будующее длительное)");
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositiveFutureContinuous,
                             "Positive future continuous (Утвердительное будующее длительное)");
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativeFutureContinuous,
                             "Negative future continuous (Отрицательное будующее длительное)");
        }

        #endregion

        #region Present ?+-

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrotivePresentContinuous,
                             "Interrogative present continuous (Вопросительное настоящее длительное)");
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositivePresentContinuous,
                             "Positive present continuous (Утвердительное настоящее длительное)");
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativePresentContinuous,
                             "Negative present continuous (Отрицательное настоящее длительное)");
        }

        #endregion

        #region Past ?+-

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.InterrotivePastContinuous,
                             "Interrogative past continuous (Вопросительное прошедшее длительное)");
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.PositivePastContinuous,
                             "Positive past continuous (Утвердительное прошедшее длительное)");
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            SetContentInForm(Resources.NegativePastContinuous,
                             "Negative past continuous (Отрицательное прошедшее длительное)");
        }

        #endregion

        #endregion

        private void SetContentInForm(Bitmap image, string title)
        {
            pictureBox1.Image = image;
            label1.Text = title;
        }        
    }
}
