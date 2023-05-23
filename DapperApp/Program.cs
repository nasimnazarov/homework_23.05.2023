var studentService = new StudentService();
// Show();
// void Show()
// {
//     var students = studentService.GetStudents();
//     System.Console.WriteLine("Id-----------name--------------lastname-----------");
//     foreach (var student in students)
//     {
//         Console.WriteLine($"{student.id}-----------{student.name}--------------{student.last} {student.salary}");
//     }
// }


System.Console.WriteLine(studentService.Update("Rasul", 4));