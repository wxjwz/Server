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
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class ServerRuleSelectCriteria : EntitySelectCriteria
    {
        public ServerRuleSelectCriteria()
        : base("ServerRule")
        {}
        public ServerRuleSelectCriteria(ServerRuleSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ServerRuleSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="RuleName")]
        public ISearchCondition<String> RuleName
        {
            get
            {
              if (!SubCriteria.ContainsKey("RuleName"))
              {
                 SubCriteria["RuleName"] = new SearchCondition<String>("RuleName");
              }
              return (ISearchCondition<String>)SubCriteria["RuleName"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="ServerPartitionGUID")]
        public ISearchCondition<ServerEntityKey> ServerPartitionKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerPartitionKey"))
              {
                 SubCriteria["ServerPartitionKey"] = new SearchCondition<ServerEntityKey>("ServerPartitionKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["ServerPartitionKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="ServerRuleTypeEnum")]
        public ISearchCondition<ServerRuleTypeEnum> ServerRuleTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerRuleTypeEnum"))
              {
                 SubCriteria["ServerRuleTypeEnum"] = new SearchCondition<ServerRuleTypeEnum>("ServerRuleTypeEnum");
              }
              return (ISearchCondition<ServerRuleTypeEnum>)SubCriteria["ServerRuleTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="ServerRuleApplyTimeEnum")]
        public ISearchCondition<ServerRuleApplyTimeEnum> ServerRuleApplyTimeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerRuleApplyTimeEnum"))
              {
                 SubCriteria["ServerRuleApplyTimeEnum"] = new SearchCondition<ServerRuleApplyTimeEnum>("ServerRuleApplyTimeEnum");
              }
              return (ISearchCondition<ServerRuleApplyTimeEnum>)SubCriteria["ServerRuleApplyTimeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="Enabled")]
        public ISearchCondition<Boolean> Enabled
        {
            get
            {
              if (!SubCriteria.ContainsKey("Enabled"))
              {
                 SubCriteria["Enabled"] = new SearchCondition<Boolean>("Enabled");
              }
              return (ISearchCondition<Boolean>)SubCriteria["Enabled"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="DefaultRule")]
        public ISearchCondition<Boolean> DefaultRule
        {
            get
            {
              if (!SubCriteria.ContainsKey("DefaultRule"))
              {
                 SubCriteria["DefaultRule"] = new SearchCondition<Boolean>("DefaultRule");
              }
              return (ISearchCondition<Boolean>)SubCriteria["DefaultRule"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="ExemptRule")]
        public ISearchCondition<Boolean> ExemptRule
        {
            get
            {
              if (!SubCriteria.ContainsKey("ExemptRule"))
              {
                 SubCriteria["ExemptRule"] = new SearchCondition<Boolean>("ExemptRule");
              }
              return (ISearchCondition<Boolean>)SubCriteria["ExemptRule"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerRule", ColumnName="RuleXml")]
        public ISearchCondition<XmlDocument> RuleXml
        {
            get
            {
              if (!SubCriteria.ContainsKey("RuleXml"))
              {
                 SubCriteria["RuleXml"] = new SearchCondition<XmlDocument>("RuleXml");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["RuleXml"];
            } 
        }
    }
}
