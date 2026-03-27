using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            string url = txtURL.Text;

            foreach (var item in clbTests.CheckedItems)
            {
                string testName = item.ToString();
                lstLog.Items.Add($"Running {testName}...");

                bool result = false;

                switch (testName)
                {
                    case "Login Test":
                        result = await Task.Run(() => SeleniumTests.TestLogin(url));
                        break;
                    case "Add To Cart Test":
                        result = await Task.Run(() => SeleniumTests.TestAddToCart(url));
                        break;
                }

                lstLog.Items.Add($"{testName}: {(result ? "PASS" : "FAIL")}");
            }
        }
    }
}
