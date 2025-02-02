using CopyLane.Core.Repositories.Interfaces;
using CopyLane.Core.Services.Interfaces;
using CopyLane.Server.Models.Enums;
using CopyLane.Server.Views.UserControls;

namespace CopyLane.Server
{
    public partial class MainForm : Form
    {
        private readonly IServerService _serverService;
        private readonly IClientRepository _clientRepository;

        public MainForm(IServerService serverService, IClientRepository clientRepository)
        {
            InitializeComponent();
            _serverService = serverService;
            _clientRepository = clientRepository;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await _clientRepository.GetData();

            ButtonTabHome.PerformClick();
            _serverService.Start("localhost", "5055");
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
