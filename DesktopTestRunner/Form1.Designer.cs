namespace DesktopTestRunner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.CheckedListBox clbTests;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lstLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtURL = new TextBox();
            clbTests = new CheckedListBox();
            btnRun = new Button();
            lstLog = new ListBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(360, 27);
            txtURL.TabIndex = 0;
            txtURL.Text = "https://www.saucedemo.com";
            // 
            // clbTests
            // 
            clbTests.FormattingEnabled = true;
            clbTests.Items.AddRange(new object[] { "Login Test", "Add To Cart Test" });
            clbTests.Location = new Point(12, 50);
            clbTests.Name = "clbTests";
            clbTests.Size = new Size(360, 48);
            clbTests.TabIndex = 1;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(12, 110);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(360, 30);
            btnRun.TabIndex = 2;
            btnRun.Text = "Run Tests";
            btnRun.Click += btnRun_Click;
            // 
            // lstLog
            // 
            lstLog.Location = new Point(12, 150);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(360, 164);
            lstLog.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(384, 350);
            Controls.Add(txtURL);
            Controls.Add(clbTests);
            Controls.Add(btnRun);
            Controls.Add(lstLog);
            Name = "Form1";
            Text = "Desktop Test Runner";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}