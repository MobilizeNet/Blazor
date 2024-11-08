# Salmon King Seafood Reference App (SKS) Webmap for Blazor C#

![SKSWinForms](./SKSPhotos/SKSBlazor.png)

# About the App

Salmon King Seafood (SKS) is a reference App created to show some of the migration capabilities of the [WebMap for Blazor](https://www.mobilize.net/webmap-csharp-blazor) conversion tool from [Growth Acceleration Partners](https://www.mobilize.net)

This repo contains the migrated SKS Windows Form Version.

# Buiding the App

If you want to build this project on your development machine, just check that you match the following requirements:

* [SQLite3 ODBC Driver](http://www.ch-werner.de/sqliteodbc/) (download sqliteodbc.exe and sqliteodbc_w64.exe)
* [.Net Framework 4.7](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks?cid=getdotnetsdk) 
* [.Net SDK 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) 
* [Telerik UI for Blazor 6.2.0>](https://www.telerik.com/try/ui-for-blazor)

You can clone the repository to your machine. From the command line, just run:
```
git clone https://github.com/MobilizeNet/SKSBlazor.git
```

Or you can download the code by clicking on Download ZIP

Once you have downloaded the code, look for SKS_Blazor.sln and open that file.
When the solution is open, the first thing you need to do is restore packages.
One easy way to do it is to right-click on your solution node. 

Select the `Manage Nuget Packages for Solution...` and select that option. From there, you can make sure that all nugets are restored.

Once all the nugets have been restored, just rebuild and run. 

# Migrated Screens

Below you can see some of the migrated screens.

Add Stock Order (frmOrderReception):

![frmOrderReception](./SKSPhotos/AddStockOrder.PNG)

Suppliers (frmProviders):

![frmProviders](./SKSPhotos/Suppliers.PNG)

Customers (frmCustomers):

![frmCustomers](./SKSPhotos/Customers.PNG)

Inventory Update (frmAddStockManual):

![frmAddStockManual](./SKSPhotos/InventoryUpdate.PNG)

Add Stock to Inventory (frmActionOrderReception):

![frmActionOrderReception](./SKSPhotos/AddStockToInventory.PNG)

Create Invoice (frmRequestAproval):

![frmRequestAproval](./SKSPhotos/CreateInvoice.PNG)

Search (frmSearch):

![frmSearch](./SKSPhotos/Search.PNG)

# Some Features used by this migration

## DataGridViewFlex to Blazor.DataGridViewFlex

Maps `UpgradeHelpers.Gui.DataGridViewFlex` to a our own helper class implementation of `DataGridViewFlex`

| Class	|Maps To|
| -- | --|
|UpgradeHelpers.Gui.DataGridViewFlex	|Gap.Blazor.DataGridViewFlex|

```csharp
private void Form1_Load(Object eventSender, EventArgs eventArgs)
{
	UpgradeHelpers.Gui.DataGridViewFlex ctl;
    ctl = new UpgradeHelpers.Gui.DataGridViewFlex();
	ctl.BorderStyle = System.Windows.Forms.BorderStyle.None;
    ctl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
}
```

```csharp
private void Form1_Load(Object eventSender, EventArgs eventArgs)
{
	Gap.Blazor.DataGridViewFlex ctl;
    ctl = new Gap.Blazor.DataGridViewFlex();
    ctl.BorderStyle = Gap.Blazor.BorderStyle.None;
	ctl.SelectionMode = Gap.Blazor.DataGridViewSelectionMode.CellSelect;
}
```

## System.Windows.Forms components to Gap.Blazor.Form components

Convert `System.Windows.Forms` classes to `Gap.Blazor`. 

Some of the classes that are supported are:

|Class	|Maps To|
|--|--|
|System.Windows.Forms.StatusStrip	|Gap.Blazor.StatusStrip |
|System.Windows.Forms.ToolStrip	    |Gap.Blazor.ToolStrip   |
|System.Windows.Forms.ImageList	    |Gap.Blazor.ImageList   |
|System.Windows.Forms.ComboBox  	|Gap.Blazor.ComboBox    |
|System.Windows.Forms.ListView	    |Gap.Blazor.ListView    |
|System.Windows.Forms.PictureBox	|Gap.Blazor.PictureBox  |