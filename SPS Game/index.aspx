<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SPS_Game.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    


        Scissors, Paper, Stone Game!<br />
        <br />
        Rules: You have to select either &#39;Scissors&#39;, &#39;Paper&#39; or &#39;Stone&#39;. Click on the respective buttons. Upon clicking, the computer will make it&#39;s choice and you will find out<br />
        whether or not you have won! Once the game has ended, click on the &#39;Restart&#39; button to play again.<br />
        <br />
        Scissors &gt; Paper<br />
        Paper &gt; Stone<br />
        Stone &gt; Scissors<br />
        <br />
        <br />
        Your Pick:<br />
        <asp:Button ID="btn_Scs" runat="server" OnClick="btn_Scs_Click" Text="Scissors" />
&nbsp;<asp:Button ID="btn_Paper" runat="server" OnClick="btn_Paper_Click" Text="Paper" />
&nbsp;<asp:Button ID="btn_Stone" runat="server" OnClick="btn_Stone_Click" Text="Stone" />
        <br />
        <br />
        <br />
        Computer&#39;s Pick:<br />
        <asp:Label ID="lbl_ComputerPick" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        Result:
        <asp:Label ID="lbl_Result" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_Restart" runat="server" OnClick="btn_Restart_Click" Text="Restart" />
    


    </div>
    </form>
</body>
</html>
