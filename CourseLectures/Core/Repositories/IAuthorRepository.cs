using CourseLectures.Core.Domain;

namespace CourseLectures.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}