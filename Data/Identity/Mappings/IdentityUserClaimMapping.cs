﻿using FluentNHibernate.Mapping;
using HumanManagement.Data.Identity.Entities;

namespace HumanManagement.Data.Identity.Mappings
{
    public class IdentityUserClaimMapping : ClassMap<WebUserClaim>
    {

        public IdentityUserClaimMapping()
        {
            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Increment();

            Map(x => x.UserId)
                .Column("user_id")
                .Not.Nullable();

            Map(x => x.ClaimType)
                .Column("claim_type");

            Map(x => x.ClaimValue)
                .Column("claim_value");

            Table("aspnet_user_claims");
        }

    }
}
