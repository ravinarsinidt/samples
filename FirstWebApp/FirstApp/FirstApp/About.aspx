<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FirstApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div style="background-color:bisque">
            <h2 id="title"><%: Title %>.</h2>
            <h3>Your application description page.</h3>
            <p>Use this area to provide additional information.</p>
            <label id="lblUserName">User Name : </label>
            <input type="text" id="idtxtUserName" name="txtUserName" />
            <br />
            <label id="lblPassword">Password : </label>
            <input type="text" id="idtxtPassword" name="txtPassword" />
            <button value="MyValue" type="submit" id="idbtnSubmit" name="btnSubmit">Submit</button>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </div>
    </main>
</asp:Content>
