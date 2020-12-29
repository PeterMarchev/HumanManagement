using FluentNHibernate.Mapping;

namespace Data.Mappings
{
    public class AttendanceMapping : ClassMap<Attendance>
    {
        public AttendanceMapping()
        {
            Table("Attendance");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.GuidComb();

            Map(x => x.Date)
                .Column("date")
                .Not.Nullable();

            Map(x => x.ClockIn)
                .Column("clock_in")
                .CustomType("TimeAsTimeSpan")
                .Not.Nullable();

            Map(x => x.ClockOut)
                .Column("clock_out")
                .CustomType("TimeAsTimeSpan")
                .Nullable();

            Map(x => x.EmployeeId)
                .Column("employee_id")
                .Not.Nullable();

            References(x => x.Employee)
                .Column("employee_id")
                .Not.Nullable()
                .ReadOnly();
        }
    }
}
    
