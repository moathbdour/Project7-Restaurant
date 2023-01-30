<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="Project7.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="ids" HeaderText="Delete" Text="Delete" DataNavigateUrlFormatString="WebForm9.aspx?id={0}" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
