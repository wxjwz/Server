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
    public partial class PartitionTransferSyntax: ServerEntity
    {
        #region Constructors
        public PartitionTransferSyntax():base("PartitionTransferSyntax")
        {}
        public PartitionTransferSyntax(
             ServerEntityKey _serverPartitionKey_
            ,ServerEntityKey _serverTransferSyntaxKey_
            ,Boolean _enabled_
            ):base("PartitionTransferSyntax")
        {
            ServerPartitionKey = _serverPartitionKey_;
            ServerTransferSyntaxKey = _serverTransferSyntaxKey_;
            Enabled = _enabled_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionTransferSyntax", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionTransferSyntax", ColumnName="ServerTransferSyntaxGUID")]
        public ServerEntityKey ServerTransferSyntaxKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionTransferSyntax", ColumnName="Enabled")]
        public Boolean Enabled
        { get; set; }
        #endregion

        #region Static Methods
        static public PartitionTransferSyntax Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public PartitionTransferSyntax Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IPartitionTransferSyntaxEntityBroker>();
            PartitionTransferSyntax theObject = broker.Load(key);
            return theObject;
        }
        static public PartitionTransferSyntax Insert(PartitionTransferSyntax entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                PartitionTransferSyntax newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public PartitionTransferSyntax Insert(IUpdateContext update, PartitionTransferSyntax entity)
        {
            var broker = update.GetBroker<IPartitionTransferSyntaxEntityBroker>();
            var updateColumns = new PartitionTransferSyntaxUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.ServerTransferSyntaxKey = entity.ServerTransferSyntaxKey;
            updateColumns.Enabled = entity.Enabled;
            PartitionTransferSyntax newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
