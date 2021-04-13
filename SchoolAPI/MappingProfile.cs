using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Organization, OrganizationDto>()
                .ForMember(c => c.FullAddress,
                    opt => opt.MapFrom(x => string.Join(' ', x.City, x.Country)));
            CreateMap<OrganizationForCreationDto, Organization>();
            CreateMap<OrganizationForUpdateDto, Organization>();

            CreateMap<User, UserDto>()
                .ForMember(c => c.UserName,
                    opt => opt.MapFrom(x => x.UserName));
            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();

            CreateMap<Section, SectionDto>()
                .ForMember(c => c.SectionName,
                    opt => opt.MapFrom(x => x.SectionName));
            CreateMap<SectionForCreationDto, Section>();
            CreateMap<SectionForUpdateDto, Section>();

            CreateMap<Course, CourseDto>()
                .ForMember(c => c.CourseName,
                    opt => opt.MapFrom(x => x.CourseName));
            CreateMap<CourseForCreationDto, Course>();
            CreateMap<CourseForUpdateDto, Course>();

            CreateMap<Assignment, AssignmentDto>()
                .ForMember(c => c.AssignmentName,
                    opt => opt.MapFrom(x => x.AssignmentName));
            CreateMap<AssignmentForCreationDto, Assignment>();
            CreateMap<AssignmentForUpdateDto, Assignment>();

        }
    }
}