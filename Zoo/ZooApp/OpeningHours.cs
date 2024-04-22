using Zoo.Core.UseCases;
using Zoo.Core;

namespace ZooApp;

public partial class OpeningHours : Form
{
    private ZooContext _zoo;
    private readonly Hours _hours = new();

    public OpeningHours()
    {
        InitializeComponent();
    }

    private void btnChangeHours_Click(object sender, EventArgs e)
    {
        var handler = new ChangeOpeningHours(_zoo);
        handler.Handle(_hours);
    }

    private void timeStart_ValueChanged(object sender, EventArgs e)
    {
        var time = (sender as DateTimePicker).Value.TimeOfDay;
        _hours[DayOfWeek.Sunday] = TimeOnly.FromTimeSpan(time);
    }
}
