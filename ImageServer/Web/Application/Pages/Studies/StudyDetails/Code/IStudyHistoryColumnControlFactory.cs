#region License

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

#endregion

using System.Web.UI;
using ClearCanvas.ImageServer.Model;

namespace ClearCanvas.ImageServer.Web.Application.Pages.Studies.StudyDetails.Code
{
    /// <summary>
    /// Defines the interface of the class that returns the customize
    /// control to display information in different types of
    /// <see cref="StudyHistory"/> record.
    /// 
    /// </summary>
    internal interface IStudyHistoryColumnControlFactory
    {
        /// <summary>
        /// Returns the <see cref="Control"/> that displays the content of 
        /// the ChangeDescription column of the specified <see cref="StudyHistory"/> record.
        /// </summary>
        /// <param name="historyRecord"></param>
        /// <returns></returns>
        Control GetChangeDescColumnControl(Control parent, StudyHistory historyRecord);
    }
}