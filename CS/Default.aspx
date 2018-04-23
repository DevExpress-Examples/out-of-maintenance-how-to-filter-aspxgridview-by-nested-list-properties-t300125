<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="T300125" %>


<%@ Register Assembly="DevExpress.Web.v15.2" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="grid" runat="server" ClientInstanceName="grid" Width="100%" KeyFieldName="Name">
            <Settings ShowFilterBar="Visible" />
            <SettingsDetail ShowDetailRow="true" />
            <SettingsFilterControl AllowHierarchicalColumns="true" ViewMode="VisualAndText" ShowAllDataSourceColumns="true"></SettingsFilterControl>
            <Columns>
                <dx:GridViewDataTextColumn FieldName="Name"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Location"></dx:GridViewDataTextColumn>
            </Columns>
            <Templates>
                <DetailRow>
                    <dx:ASPxGridView ID="detailGrid" runat="server" KeyFieldName="FirstName"
                        Width="100%" OnBeforePerformDataSelect="detailGrid_BeforePerformDataSelect">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="FirstName" />
                            <dx:GridViewDataTextColumn FieldName="LastName" />
                            <dx:GridViewDataTextColumn FieldName="Age" />
                            <dx:GridViewDataTextColumn FieldName="Position" />
                        </Columns>
                    </dx:ASPxGridView>
                </DetailRow>
            </Templates>
        </dx:ASPxGridView>
    </form>
</body>
</html>
