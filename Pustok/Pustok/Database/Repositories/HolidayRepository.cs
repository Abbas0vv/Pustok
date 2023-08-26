using Pustok.Core.Entities;

namespace Pustok.Database.Repositories;

public class HolidayRepository
{
    private readonly List<Holiday> _holidays = new List<Holiday>();

    public HolidayRepository()
    {
        _holidays.Add(new Holiday(1, "5 Terre", "description"));
        _holidays.Add(new Holiday(2, "Yevlax", "description"));
        _holidays.Add(new Holiday(3, "Agdam", "description"));
        _holidays.Add(new Holiday(4, "Qusar", "description"));
        _holidays.Add(new Holiday(5, "Quba", "description"));
    }

    public List<Holiday> GetAll()
    {
        return _holidays;
    }
}
