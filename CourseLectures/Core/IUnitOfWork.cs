using System;
using CourseLectures.Core.Repositories;

namespace CourseLectures.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}