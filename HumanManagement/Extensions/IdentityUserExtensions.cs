using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanManagement.Extensions
{
    public static class IdentityUserExtensions
    {
        public static IdentityBuilder AddNHibernateStores(this IdentityBuilder builder)
        {
            var userStoreServiceType = typeof(IUserStore<>)
                    .MakeGenericType(builder.UserType);
            var userStoreImplType = typeof(UserStore<,>)
                .MakeGenericType(builder.UserType, builder.RoleType);

            builder.Services.AddScoped(userStoreServiceType, userStoreImplType);

            var roleStoreSvcType = typeof(IRoleStore<>)
                .MakeGenericType(builder.RoleType);
            var roleStoreImplType = typeof(RoleStore<>)
                .MakeGenericType(builder.RoleType);

            builder.Services.AddScoped(roleStoreSvcType, roleStoreImplType);

            return builder;
        }
    }
}
