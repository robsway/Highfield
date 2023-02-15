namespace Highfield.Extensions
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime birthday)
        {
            DateTime today = DateTime.Today;

            return (
                (today.Year - birthday.Year) * 372 +
                (today.Month - birthday.Month) * 31 +
                (today.Day - birthday.Day)) / 372;
        }
    }
}
