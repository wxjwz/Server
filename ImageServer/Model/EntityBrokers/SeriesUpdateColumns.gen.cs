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

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.ImageServer.Enterprise;

   public partial class SeriesUpdateColumns : EntityUpdateColumns
   {
       public SeriesUpdateColumns()
       : base("Series")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        {
            set { SubParameters["ServerPartitionKey"] = new EntityUpdateColumn<ServerEntityKey>("ServerPartitionKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="StudyGUID")]
        public ServerEntityKey StudyKey
        {
            set { SubParameters["StudyKey"] = new EntityUpdateColumn<ServerEntityKey>("StudyKey", value); }
        }
       [DicomField(DicomTags.SeriesInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesInstanceUid")]
        public String SeriesInstanceUid
        {
            set { SubParameters["SeriesInstanceUid"] = new EntityUpdateColumn<String>("SeriesInstanceUid", value); }
        }
       [DicomField(DicomTags.Modality, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="Modality")]
        public String Modality
        {
            set { SubParameters["Modality"] = new EntityUpdateColumn<String>("Modality", value); }
        }
       [DicomField(DicomTags.NumberOfSeriesRelatedInstances, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="NumberOfSeriesRelatedInstances")]
        public Int32 NumberOfSeriesRelatedInstances
        {
            set { SubParameters["NumberOfSeriesRelatedInstances"] = new EntityUpdateColumn<Int32>("NumberOfSeriesRelatedInstances", value); }
        }
       [DicomField(DicomTags.PerformedProcedureStepStartDate, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="PerformedProcedureStepStartDate")]
        public String PerformedProcedureStepStartDate
        {
            set { SubParameters["PerformedProcedureStepStartDate"] = new EntityUpdateColumn<String>("PerformedProcedureStepStartDate", value); }
        }
       [DicomField(DicomTags.PerformedProcedureStepStartTime, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="PerformedProcedureStepStartTime")]
        public String PerformedProcedureStepStartTime
        {
            set { SubParameters["PerformedProcedureStepStartTime"] = new EntityUpdateColumn<String>("PerformedProcedureStepStartTime", value); }
        }
       [DicomField(DicomTags.SourceApplicationEntityTitle, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SourceApplicationEntityTitle")]
        public String SourceApplicationEntityTitle
        {
            set { SubParameters["SourceApplicationEntityTitle"] = new EntityUpdateColumn<String>("SourceApplicationEntityTitle", value); }
        }
       [DicomField(DicomTags.SeriesNumber, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesNumber")]
        public String SeriesNumber
        {
            set { SubParameters["SeriesNumber"] = new EntityUpdateColumn<String>("SeriesNumber", value); }
        }
       [DicomField(DicomTags.SeriesDescription, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Series", ColumnName="SeriesDescription")]
        public String SeriesDescription
        {
            set { SubParameters["SeriesDescription"] = new EntityUpdateColumn<String>("SeriesDescription", value); }
        }
    }
}
