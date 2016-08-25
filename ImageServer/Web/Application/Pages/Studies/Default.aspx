<%--  License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

--%>

<%@ Page Language="C#" MasterPageFile="~/GlobalMasterPage.master" AutoEventWireup="true"
    EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="ClearCanvas.ImageServer.Web.Application.Pages.Studies.Default" %>

<%@ Register src="StudyDetails/Controls/DeleteStudyConfirmDialog.ascx" tagname="DeleteStudyConfirmDialog" tagprefix="localAsp" %>
<%@ Register src="StudyDetails/Controls/AddAuthorityGroupsDialog.ascx" tagname="AddAuthorityGroupsDialog" tagprefix="localAsp" %>
<%@ Register src="SearchPanel.ascx" TagName="SearchPanel" TagPrefix="localAsp" %>

<asp:Content runat="server" ID="MainContentTitle" ContentPlaceHolderID="MainContentTitlePlaceHolder">
    <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Titles,Studies%>" /></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">    
    <asp:UpdatePanel ID="PageContent" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <ccAsp:ServerPartitionSelector runat="server" id="ServerPartitionSelector" visible="true" />
        <localAsp:SearchPanel runat="server" id="SearchPanel" visible="true" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="DialogsPlaceHolder" runat="server">
    <localAsp:DeleteStudyConfirmDialog id="DeleteStudyConfirmDialog" runat="server" />
    <localAsp:AddAuthorityGroupsDialog id="AddAuthorityGroupsDialog" runat="server" />
</asp:Content>
