﻿using System.Linq;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Models;

namespace Odoo.Warehouse.SDK.Extensions
{
    public static class OddoModelExtensions
    {
        public static string TableName(this IOdooModel odooModel)
        {
            var tableName = odooModel.GetType()
                .CustomAttributes
                .First(attr => attr.AttributeType == typeof(OdooTableNameAttribute));
            return tableName.ConstructorArguments[0].Value.ToString();
        }
    }
}
