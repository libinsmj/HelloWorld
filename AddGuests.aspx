<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddGuests.aspx.cs" Inherits="GreenInitiative.AddGuests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-8 mb-4">
          <h3>Add Guests</h3>
         <div class="control-group form-group">
              <div class="controls">
                <label>Title:</label>
                <asp:DropDownList ID="drptitle" class="form-control" required data-validation-required-message="Please enter your password." runat="server" TextMode="Password"></asp:DropDownList>
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Guest Name:</label>
                  <asp:TextBox ID="txtname" class="form-control" required data-validation-required-message="Please enter your name." runat="server"></asp:TextBox>
                <p class="help-block"></p>
              </div>
            </div>
               <div class="control-group form-group">
              <div class="controls">
                <label>Designation:</label>
                  <asp:TextBox ID="txtdes" class="form-control" required data-validation-required-message="Please enter your name." runat="server"></asp:TextBox>
                <p class="help-block"></p>
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Organisation:</label>
                 <asp:TextBox ID="txtorg" class="form-control" required data-validation-required-message="Please enter your name." runat="server"></asp:TextBox>
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Mobile No:</label>
                <asp:TextBox ID="txtmob" class="form-control"  runat="server"></asp:TextBox>
              </div>
            </div>
       <div class="control-group form-group">
              <div class="controls">
                <label>Email:</label>
                <asp:TextBox ID="txtemail" class="form-control" runat="server"></asp:TextBox>
              </div>
            </div> 
               <div class="control-group form-group">
              <div class="controls">
                <label>Profile Link:</label>
                <asp:TextBox ID="txtprof" class="form-control" required data-validation-required-message="Please enter your profile." runat="server"></asp:TextBox>
              </div>
            </div>
           
               <div class="control-group form-group">
              <div class="controls">
                <label>Photo:</label>
                  <asp:FileUpload ID="filephoto" lass="form-control" required runat="server" />              
              </div>
            </div>
            <div id="success"></div>
            <!-- For success/fail messages -->
         <asp:Button ID="btnsub" class="btn btn-primary" runat="server"  Text="Register" OnClick="btnsub_Click"  />
          <%--  <button type="submit" class="btn btn-primary" id="sendMessageButton">Send Message</button>--%>
       
        </div>

      </div>
</asp:Content>
