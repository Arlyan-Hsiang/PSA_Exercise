<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exercise2.aspx.cs" Inherits="Exercise2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise2</title>
    <style type="text/css"> 
          #GridView2{
              table-layout = fixed;
              width:200px;
          }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select Employers:
        <asp:DropDownList ID="DropDownList1" runat="server"  DataTextField="estab_name" DataValueField="estab_name" AutoPostBack="True" OnselectedIndexChanged="updateGridView" DataSourceID="SqlDataSource1">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [estab_name] FROM [Employer_Master]">
        </asp:SqlDataSource>
    </div>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
