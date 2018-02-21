<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.Master" AutoEventWireup="true" CodeBehind="AddTree.aspx.cs" Inherits="GreenInitiative.AddTree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-8 mb-4">
          <h3>Tree Details</h3>
    
                <div class="control-group form-group">
              <div class="controls">
                <label>Tree Name</label>
                  <asp:TextBox ID="txttreename" CssClass="form-control" required  runat="server"></asp:TextBox>
                <p class="help-block"></p>
              </div>
            </div>
            <div class="control-group form-group">
              <div class="controls">
                <label>Tree Description</label>
                  <asp:TextBox ID="txtdes" CssClass="form-control" required TextMode="MultiLine" runat="server"></asp:TextBox>
                <p class="help-block"></p>
              </div>
            </div>
             
              <div class="control-group form-group">
              <div class="controls">
                <label>Location</label>
                  <asp:TextBox ID="txtloc" CssClass="form-control" required  runat="server"></asp:TextBox>
                <p class="help-block"></p>
              </div>
            </div>
            <%--   <div class="control-group form-group">
              <div class="controls">
                <label>Guest</label>
                  <asp:DropDownList ID="drpguest" CssClass="form-control" AppendDataBoundItems="true" required  runat="server"></asp:DropDownList>
                <p class="help-block"></p>
              </div>
            </div>--%>
           
             <div class="control-group form-group">
              <div class="controls">
                <label>Photo:</label>
                  <asp:FileUpload ID="filephoto" lass="form-control" required runat="server" />              
              </div>
            </div>
            <div id="success"></div>
            <!-- For success/fail messages -->
         <asp:Button ID="btntreesub" class="btn btn-primary" runat="server"  Text="Add Tree" OnClick="btntreesub_Click"   />
  
        
        </div>

      </div>
</asp:Content>
