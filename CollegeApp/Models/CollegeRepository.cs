namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    StudentName = "Shubham",
                    Email = "shuv730@gmail.com",
                    Address = "5th cross holy street"
                },
                new Student
                {
                    Id = 2,
                    StudentName = "Abhi",
                    Email = "abhi30@gmail.com",
                    Address = "6th cross holy street"
                }
            };
       
    }
     
}
