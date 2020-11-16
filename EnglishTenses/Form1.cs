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

        private void SetContentInForm(Bitmap image, string title)
        {
            pictureBox1.Image = image;
            label1.Text = title;
        }
    }
}
