using Npgsql;
using Dapper;
public class StudentService
{
    string connectionString = "Server = localhost; Port=5432; Database=Data;User Id = postgres; Password=12345";
    public StudentService()
    {
        
    }

    public List<StudentDto> GetStudents()
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            var sql = "select * from students";
            var result = conn.Query<StudentDto>(sql);
            return result.ToList() ;
        }
    }

    public int Update(string name, int id)
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            var sql = $"update students set name = '{name}' where id = {id}";
            var result = conn.Execute(sql);
            return result;
        }
    }
    
}