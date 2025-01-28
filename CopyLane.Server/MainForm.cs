using CopyLane.Server.Models.Enums;
using CopyLane.Server.Views.UserControls;
using CopyLane.SignalR;

namespace CopyLane.Server
{
    public partial class MainForm : Form
    {
        private SignalRServer _signalRServer { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _signalRServer = new SignalRServer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Run the server in a separate thread to avoid blocking UI
            _signalRServer.Start();
            ButtonTabHome.PerformClick();
        }

        private void AddUCControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelBody.Controls.Clear();
            PanelBody.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnTabClick(object sender, EventArgs e)
        {
            foreach (var panel in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                panel.BackColor = Color.Silver;
            }

            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case nameof(ButtonTabEnum.Home):
                    AddUCControls(new UC_Home());
                    PanelTabHome.BackColor = Color.MediumSeaGreen;
                    break;

                case nameof(ButtonTabEnum.Settings):
                    AddUCControls(new UC_Settings());
                    PanelTabSettings.BackColor = Color.MediumSeaGreen;
                    break;

                case nameof(ButtonTabEnum.Admin):
                    AddUCControls(new UC_Admin());
                    PanelTabAdmin.BackColor = Color.MediumSeaGreen;
                    break;
            }
        }
    }
}
