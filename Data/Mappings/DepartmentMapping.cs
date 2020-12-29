using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class DepartmentMapping : ClassMap<Department>
    {
        public DepartmentMapping()
        {
            Table("Department");
            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable();

            References(x => x.Location)
                .Column("location_id")
                .Not.Nullable()
                .Fetch.Join()
                .ReadOnly();

            References(x => x.Company)
                .Column("company_id")
                .Not.Nullable()
                .Fetch.Join()
                .ReadOnly();

            Map(x => x.LocationId)
                .Column("location_id")
                .Not.Nullable();

            Map(x => x.CompanyId)
                .Column("company_id")
                .Not.Nullable();

            HasOne(x => x.DepartmentManagers)
                .PropertyRef(x => x.Department);

            HasMany(x => x.Employees)
                .KeyColumn("department_id")
                .Inverse()
                .Fetch.Select();
        }
    }
}
