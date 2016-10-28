<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" runat="server" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
     <center>
         <div id="topdiv"></div>
    <div id="tablediv">
   
        
        <form id="form1" runat="server">
    <div>
        
        <asp:Button CssClass="btn" ID="ButtonDeal" runat="server" Text="Deal" OnClick="ButtonDeal_Click" />
        <asp:Button CssClass="btn" ID="ButtonHit" runat="server" Text="Hit" OnClick="ButtonHit_Click" />
        <asp:Button CssClass="btn" ID="ButtonPass" runat="server"  Text="Pass" OnClick="ButtonPass_Click" />
        <asp:Button CssClass="btn" ID="ButtonEnd" runat="server" Text="End Game" OnClick="ButtonEnd_Click" />
        <br><br>
    </div>
            <asp:Image ID="ImageLeft" runat="server" />
            <asp:Image ID="ImageRight" runat="server" />
            <asp:Image ID="ImageThree" runat="server" />
            <asp:Image ID="ImageFour" runat="server" />
            <asp:Image ID="ImageFive" runat="server" />
            <asp:Image ID="ImageSix" runat="server" />
            <asp:Image ID="ImageSeven" runat="server" />
        <p>
        <asp:Label ID="LabelScore" runat="server"></asp:Label>
            

            <asp:Label ID="LabelResult" runat="server"></asp:Label>
            <br><br>
            <asp:Image ID="Image1" runat="server" />
            <asp:Image ID="Image2" runat="server" />
            <asp:Image ID="Image3" runat="server" />
            <asp:Image ID="Image4" runat="server" />
            <asp:Image ID="Image5" runat="server" />
            <asp:Image ID="Image6" runat="server" />
            <asp:Image ID="Image7" runat="server" />

        <asp:Label ID="LabelFinal" runat="server"></asp:Label>

        </p>
        <p>
            &nbsp;</p>
            <br><asp:HyperLink ID="HyperLink" runat="server" NavigateUrl="Default.aspx" Visible="False">Play Again</asp:HyperLink>
          </form>
      <asp:Label ID="LabelGAMEOVER" runat="server"></asp:Label>
    
        <p>
        &nbsp;</p>
        </div>
    </center>
</body>
</html>
