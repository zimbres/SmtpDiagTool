namespace SmtpDiagTool;

public partial class LogWindow : Form
{
    public LogWindow()
    {
        InitializeComponent();
    }

    public void UpdateLogs(string logMessage)
    {
        logMessages.AppendText($"{logMessage}{Environment.NewLine}----------------------{Environment.NewLine}");
        logMessages.SelectionStart = logMessages.Text.Length;
        logMessages.ScrollToCaret();
    }

    private void ClearLogs(object sender, EventArgs e)
    {
        logMessages.Clear();
    }
}
