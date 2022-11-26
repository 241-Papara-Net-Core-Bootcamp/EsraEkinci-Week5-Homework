using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Domain.Entities;
using RepositoryPattern.Domain.DTOs;
using RepositoryPattern.Services.Services.Abstracts;
using System.Collections.Generic;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //private readonly ICourseService _courseService;
        private readonly IDapperService _dapperService;
        private readonly IMapper _mapper;

        public CourseController( IDapperService dapperService , IMapper mapper)
        {
            //_courseService = courseService;
            _mapper = mapper;
            _dapperService = dapperService;
        }

        [HttpPost("Add")]
        public IActionResult Post(CourseDto course)
        {
            _dapperService.AddAsync(_mapper.Map<Course>(course));
            return Ok(course);
           

            //mappedCourse.CreatedDate = DateTime.Now;
            //mappedCourse.CreatedBy = "Admin";

            //var courseDto = new Course
            //{
            //    //CourseAdress = course.CourseAdress,
            //    //CourseName = course.CourseName,
            //    //CourseType = course.CourseType,
            //    //TrainerEmail = course.TrainerEmail,
            //    //TrainerName = course.TrainerName,

            //    //CreatedBy = "Admin",
            //    //CreatedDate = System.DateTime.Now,
            //    //IsDeleted = false,
            //    //LastModifiedDate = System.DateTime.Now

            //};

        }

        [HttpGet("GetAllCourses")]
        public IActionResult GetAllAsync()
        {
            var CourseList = _dapperService.GetAllAsync();
            var courseMap = _mapper.Map<List<CourseDto>>(CourseList);
            return Ok(courseMap);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var course = _dapperService.GetByIdAsync(id);
            var courseDto = _mapper.Map<CourseDto>(course);

            //if (course.Any())
                return Ok(courseDto);
            //return BadRequest("There is no course with this id! Ensure enter a valid id.");
        }

        [HttpPut("Update")]
        public IActionResult Update(int id, CourseDto course)
        {

             _dapperService.Update(id,course);
            return Ok("Success! The data is updated.");
            //_dapperService.UpdateAsync(_mapper.Map<Course>(course));
            //return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {          
            
            _dapperService.DeleteAsync(id);
            return Ok($"Success! The data that has {id} number is deleted.");
        }

    }

}


