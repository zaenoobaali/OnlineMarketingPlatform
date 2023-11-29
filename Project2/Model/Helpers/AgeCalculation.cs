namespace Project2.Model.Helpers
{
    public static class AgeCalculation
    {
        public static int GetAge(DateTime dateofbirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateofbirth.Year * 100 + dateofbirth.Month) * 100 + dateofbirth.Day;

            return (a - b) / 10000;
        }
    }
}
