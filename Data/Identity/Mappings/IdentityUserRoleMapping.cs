﻿using FluentNHibernate.Mapping;
using HumanManagement.Data.Identity.Entities;
using System;

namespace HumanManagement.Data.Identity.Mappings
{
    public class IdentityUserRoleMapping : ClassMap<WebUserRole>
    {

        public IdentityUserRoleMapping()
        {
            CompositeId()
                .KeyProperty(x => x.UserId,
                prop => prop.ColumnName("user_id")
                        .Type(typeof(Guid)))
                .KeyProperty(x => x.RoleId,
                prop => prop.ColumnName("role_id")
                        .Type(typeof(Guid)));

            Table("aspnet_user_roles");
        }

    }
}
