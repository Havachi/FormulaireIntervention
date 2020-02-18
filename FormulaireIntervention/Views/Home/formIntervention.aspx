<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formIntervention.aspx.cs" Inherits="FormulaireIntervention.Views.Home.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 71px">
    <form id="formIntervention" runat="server" class="form">
        <div>
            <asp:Label ID="lblMain" runat="server" Font-Size="X-Large" Text="Intervention"></asp:Label>
            <hr />
        </div>
        <br />
        <div>
            <asp:Label ID="lblIntervenant" runat="server" Font-Size="Medium" Text="Intervenant : "></asp:Label>
            <asp:DropDownList ID="ddlIntervenant" runat="server">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="lblTypeIntervention" runat="server" Font-Size="Medium" Text="Type d'intervention : "></asp:Label>
            <asp:DropDownList ID="ddlTypeIntervention" runat="server">
            </asp:DropDownList>
        </div>
        <br />
        <div>

            <input id="startTime" type="time" /></div>
    </form>
</body>
</html>
