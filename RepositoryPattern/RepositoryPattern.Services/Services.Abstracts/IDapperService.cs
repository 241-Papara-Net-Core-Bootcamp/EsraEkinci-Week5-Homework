using Repository.Domain.Entities;
using RepositoryPattern.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Services.Services.Abstracts
{
    public interface IDapperService
    {
        Course GetByIdAsync(int id);
        List<Course> GetAllAsync();
        void AddAsync(Course course);
        Task Update(int id,CourseDto course);
        void DeleteAsync(int CourseId);
    }
}
