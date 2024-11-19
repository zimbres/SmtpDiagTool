namespace SmtpDiagTool;

public partial class MainWindow : Form
{
    private LogWindow _logWindow;
    private readonly SendMailService _sendMailService = new();

    public MainWindow()
    {
        InitializeComponent();

        srvReqAuthCheckBox.CheckedChanged += SrvReqAuthCheckBox;
        username.Enabled = false;
        password.Enabled = false;
    }

    private void SourceCodeLink(object sender, LinkLabelLinkClickedEventArgs e)
    {
        string url = sourceCode.Tag.ToString();
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }

    private void ExitButton(object sender, EventArgs e)
    {
        Close();
    }

    private void TestSmtpButton(object sender, EventArgs e)
    {
        var result = _sendMailService.SendMail(
            smtpServerAddress.Text,
            int.Parse(smtpServerPort.Text),
            username.Text,
            password.Text,
            from.Text,
            to.Text,
            subject.Text,
            body.Text,
            enableSsl: false);

        if (_logWindow == null || _logWindow.IsDisposed)
        {
            _logWindow = new LogWindow();
        }

        _logWindow.UpdateLogs(result);

        if (!_logWindow.Visible)
        {
            _logWindow.Show();
        }

    }

    private void SrvReqAuthCheckBox(object sender, EventArgs e)
    {
        bool isChecked = srvReqAuthCheckBox.Checked;
        username.Enabled = isChecked;
        password.Enabled = isChecked;
    }
}
