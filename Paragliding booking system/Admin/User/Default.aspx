<%@ Page Title="User Management" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Paragliding_booking_system.Admin.User.Default" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content" ContentPlaceHolderID="Content" runat="server">
    <div id="addUser" class="controls">
        <div class="form-group">
            <label for="username">Username:</label>
            <input type="text" class="form-control" id="username" placeholder="Enter username.">
        </div>
        <div class="form-inline">
            <div class="form-group">
                <label for="firstName">First Name:</label>
                <input type="text" class="form-control" id="firstName" placeholder="Enter first name.">
            </div>
            <div class="form-group">
                <label for="middleName">Middle Name:</label>
                <input type="text" class="form-control" id="middleName" placeholder="Enter middle name.">
            </div>
            <div class="form-group">
                <label for="lastName">Last Name:</label>
                <input type="text" class="form-control" id="lastName" placeholder="Enter last name.">
            </div>
        </div>
        <div class="form-group">
            <label for="email">Email:</label>
            <input type="email" class="form-control" id="email" placeholder="Enter email address.">
        </div>
        <div class="form-group">
            <label for="phone">Phone Number:</label>
            <input type="text" class="form-control" id="phone" placeholder="Enter phone number.">
        </div>
        <div class="form-group">
            <label for="address">Address:</label>
            <input type="text" class="form-control" id="address" placeholder="Enter your address.">
        </div>
        <div class="form-group">
            <label for="userRole">User role:</label>
            <select id="userRole" class="form-control">
                <option value="0">Select User Role</option>
                <option value="1">Admin</option>
                <option value="2">User</option>
            </select>
        </div>
        <div class="form-group">
            <button type="button" class="btn btn-success"><span class="glyphicon glyphicon-floppy-disk" aria-hidden="true"></span> Save</button>
            <button type="button" class="btn btn-danger"><span class="glyphicon glyphicon-remove" aria-hidden="true"></span> Cancel</button>
        </div>
    </div>
</asp:Content>
