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

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class StudyHistory: ServerEntity
    {
        #region Constructors
        public StudyHistory():base("StudyHistory")
        {}
        public StudyHistory(
             DateTime _insertTime_
            ,ServerEntityKey _studyStorageKey_
            ,StudyHistoryTypeEnum _studyHistoryTypeEnum_
            ,XmlDocument _studyData_
            ,XmlDocument _changeDescription_
            ,ServerEntityKey _destStudyStorageKey_
            ):base("StudyHistory")
        {
            InsertTime = _insertTime_;
            StudyStorageKey = _studyStorageKey_;
            StudyHistoryTypeEnum = _studyHistoryTypeEnum_;
            StudyData = _studyData_;
            ChangeDescription = _changeDescription_;
            DestStudyStorageKey = _destStudyStorageKey_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyHistoryTypeEnum")]
        public StudyHistoryTypeEnum StudyHistoryTypeEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyData")]
        public XmlDocument StudyData
        { get { return _StudyData; } set { _StudyData = value; } }
        [NonSerialized]
        private XmlDocument _StudyData;
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="ChangeDescription")]
        public XmlDocument ChangeDescription
        { get { return _ChangeDescription; } set { _ChangeDescription = value; } }
        [NonSerialized]
        private XmlDocument _ChangeDescription;
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="DestStudyStorageGUID")]
        public ServerEntityKey DestStudyStorageKey
        { get; set; }
        #endregion

        #region Static Methods
        static public StudyHistory Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public StudyHistory Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IStudyHistoryEntityBroker>();
            StudyHistory theObject = broker.Load(key);
            return theObject;
        }
        static public StudyHistory Insert(StudyHistory entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                StudyHistory newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public StudyHistory Insert(IUpdateContext update, StudyHistory entity)
        {
            var broker = update.GetBroker<IStudyHistoryEntityBroker>();
            var updateColumns = new StudyHistoryUpdateColumns();
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.StudyStorageKey = entity.StudyStorageKey;
            updateColumns.StudyHistoryTypeEnum = entity.StudyHistoryTypeEnum;
            updateColumns.StudyData = entity.StudyData;
            updateColumns.ChangeDescription = entity.ChangeDescription;
            updateColumns.DestStudyStorageKey = entity.DestStudyStorageKey;
            StudyHistory newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
