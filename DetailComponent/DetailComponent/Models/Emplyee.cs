namespace DetailComponent.Models
{
    public class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }

        public void LoadRecords()
        {
            // load some records for the employee
        }
    }
}
