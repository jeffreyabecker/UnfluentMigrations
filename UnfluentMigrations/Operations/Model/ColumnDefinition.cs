#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>, Jeff Becker <jeffrey.a.becker@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Data;

namespace UnfluentMigrations.Operations.Model
{
    public class ColumnDefinition : IDecoratable
    {
        public ColumnDefinition()
        {

        }

        public SubObjectName Name { get; set; }


        public virtual IDbColumnType Type { get; set; }

        public virtual object DefaultValue { get; set; }
 


        public virtual bool? IsNullable { get; set; }


        public virtual string Description { get; set; }
        public virtual string CollationName { get; set; }
        public bool? Unicode { get; set; }
        public string ComputedColumnExpressionSql { get; set; }
        public string DefaultValueSql { get; set; }

        public Dictionary<string,object> Decorations { get; set; } = new Dictionary<string, object>();


        public static IDbColumnType InferType(DbType? explicitDbType, Type type, string storeType, int? size, int? precision)
        {
            return new BasicDbColumnType
            {
                ExplicitStoreType = storeType,
                UnderlyingType =
                    explicitDbType ?? (clrToDb.ContainsKey(type) ? (DbType?) clrToDb[type].UnderlyingType : null),
                Size = size,
                Precision = precision
            };

        }

        private static readonly Dictionary<Type, (DbType UnderlyingType, bool HasLength)> clrToDb = CreateMapping();

        private static Dictionary<Type, (DbType UnderlyingType, bool HasLength)> CreateMapping()
        {
            return new Dictionary<Type, (DbType UnderlyingType, bool HasLength)>
            {
                {typeof(byte), (DbType.Byte, false)},
                {typeof(sbyte), (DbType.SByte, false)},
                {typeof(short), (DbType.Int16, false)},
                {typeof(ushort), (DbType.UInt16, false)},
                {typeof(int), (DbType.Int32, false)},
                {typeof(uint), (DbType.UInt32, false)},
                {typeof(long), (DbType.Int64, false)},
                {typeof(ulong), (DbType.UInt64, false)},
                {typeof(float), (DbType.Single, false)},
                {typeof(double), (DbType.Double, false)},
                {typeof(decimal), (DbType.Decimal, false)},
                {typeof(bool), (DbType.Boolean, false)},
                {typeof(string), (DbType.String, false)},
                {typeof(char), (DbType.StringFixedLength, false)},
                {typeof(Guid), (DbType.Guid, false)},
                {typeof(DateTime), (DbType.DateTime, false)},
                {typeof(DateTimeOffset), (DbType.DateTimeOffset, false)},
                {typeof(byte[]), (DbType.Binary, false)},
                {typeof(byte?), (DbType.Byte, false)},
                {typeof(sbyte?), (DbType.SByte, false)},
                {typeof(short?), (DbType.Int16, false)},
                {typeof(ushort?), (DbType.UInt16, false)},
                {typeof(int?), (DbType.Int32, false)},
                {typeof(uint?), (DbType.UInt32, false)},
                {typeof(long?), (DbType.Int64, false)},
                {typeof(ulong?), (DbType.UInt64, false)},
                {typeof(float?), (DbType.Single, false)},
                {typeof(double?), (DbType.Double, false)},
                {typeof(decimal?), (DbType.Decimal, false)},
                {typeof(bool?), (DbType.Boolean, false)},
                {typeof(char?), (DbType.StringFixedLength, false)},
                {typeof(Guid?), (DbType.Guid, false)},
                {typeof(DateTime?), (DbType.DateTime, false)},
                {typeof(DateTimeOffset?), (DbType.DateTimeOffset, false)},
            };

        }
    }


}
