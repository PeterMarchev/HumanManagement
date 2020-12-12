using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    class LocationMapping : ClassMap<Location>
    {
        public LocationMapping()
        {
            Table("Location");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.AddressOne)
                .Column("address_line1")
                .Not.Nullable();

            Map(x => x.AddressTwo)
                .Column("address_line2")
                .Nullable();

            Map(x => x.Town)
                .Column("town")
                .Not.Nullable();

            References(x => x.Country)
                .Column("country_id")
                .ReadOnly()
                .Not.Nullable();

            Map(x => x.CountryId)
                .Column("country_id")
                .Not.Nullable();

        }
    }
}
