namespace SKS_Blazor.Components
{
	using Gap.Blazor;
	using SKS_Blazor.Components.Pages;
	public partial class frmMain : Form
	{
		public frmMain() : base()
		{
			this.View = typeof(FrmMainView);
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			InitializeComponent();

        }
		private void frmMain_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
		}

		private void MDIForm_Load()
		{
			frmOrderRequest.DefInstance.Show();
		}

		public async void mnuAbout_Click(Object eventSender, EventArgs eventArgs)
		{
            await frmAbout.DefInstance.ShowDialog();
        }

		public void mnuAddStockManually_Click(Object eventSender, EventArgs eventArgs)
		{
            frmAddStockManual.DefInstance.Show();
        }

		public void mnuAdjustStockManually_Click(Object eventSender, EventArgs eventArgs)
		{
            frmAdjustStockManual.DefInstance.Show();
        }

		public void mnuCreateOrderReception_Click(Object eventSender, EventArgs eventArgs)
		{
            frmOrderReception.DefInstance.Show();
        }

		public void mnuCreateOrderRequest_Click(Object eventSender, EventArgs eventArgs)
		{
            frmOrderRequest.DefInstance.Show();
        }

		public async void mnuCustomer_Click(Object eventSender, EventArgs eventArgs)
		{
            await frmCustomers.DefInstance.ShowDialog();
            frmCustomers.DefInstance.InitForm();
        }

		public void mnuExit_Click(Object eventSender, EventArgs eventArgs)
		{
            this.Close();
        }

		public void mnuOrderReceptionsApproval_Click(Object eventSender, EventArgs eventArgs)
		{
            frmReceptionApproval.DefInstance.Show();
        }

		public void mnuOrderRequestsApproval_Click(Object eventSender, EventArgs eventArgs)
		{
            frmRequestApproval.DefInstance.Show();
        }

		public async void mnuProducts_Click(Object eventSender, EventArgs eventArgs)
		{
            await frmProducts.DefInstance.ShowDialog();
        }

		public async void mnuProviders_Click(Object eventSender, EventArgs eventArgs)
		{
            await frmProviders.DefInstance.ShowDialog();
        }

		public void mnuSecurity_Click(Object eventSender, EventArgs eventArgs)
		{
            frmUsersManage.DefInstance.Show();
        }
	}
}
