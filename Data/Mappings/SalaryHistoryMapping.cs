using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    class SalaryHistoryMapping : ClassMap<SalaryHistory>
    {
        public SalaryHistoryMapping()
        {
            Table("salary_history");

            CompositeId()
               .KeyProperty(x => x.SalaryId, "salary_id");

            Map(x => x.Amount)
                .Column("amount")
                .Not.Nullable();

            Map(x => x.PeriodicityId)
                .Column("periodicity_id")
                .Not.Nullable();

            Map(x => x.EffectiveDate)
                .Column("set_on")
                .Not.Nullable();

            Map(x => x.ChangedOn)
                .Column("changed_on")
                .Not.Nullable();

        }
    }
}
