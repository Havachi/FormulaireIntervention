<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormulaireIntervention.Views.Home.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMain" runat="server" Font-Size="X-Large" Text="Intervention"></asp:Label>
            <hr />
        </div>
        <div>
            <asp:Label ID="lblIntervenant" runat="server" Font-Size="Medium" Text="Intervenant : "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="test">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="test" runat="server"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
