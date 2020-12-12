using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class EmergencyContactsMapping : ClassMap<EmergencyContacts>
    {
        public EmergencyContactsMapping()
        {
            Table("Emergency_contacts");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.EmployeeId)
              .Column("employee_id")
              .Not.Nullable();

            Map(x => x.FirstName)
                .Column("first_name")
                .Not.Nullable();

            Map(x => x.LastName)
                .Column("last_name")
                .Not.Nullable();

            Map(x => x.EmergPhone)
                .Column("emerg_phone")
                .Not.Nullable();

            Map(x => x.EmergAddress)
                .Column("emerg_address")
                .Not.Nullable();

            References(x => x.Employee)
                .Column("employee_id")
                .ReadOnly();
        }
    }
}
