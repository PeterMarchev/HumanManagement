using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class CompanyMapping : ClassMap<Company>
    {
        public CompanyMapping()
        {
            Table("Company");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable();

            Map(x => x.CIN)
                .Column("cin")
                .Not.Nullable();

            HasMany(x => x.Departments)
                .KeyColumn("company_id")
                .Inverse()
                .Fetch.Select();
        }
    }
}
