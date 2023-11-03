using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<User, RegisterDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap();

        CreateMap<Appointment, AppointmentCreateDto>().ReverseMap();
        CreateMap<Appointment, AppointmentUpdateDto>().ReverseMap();
        CreateMap<Appointment, AppointmentInfoDto>().ReverseMap();

        CreateMap<Polyclinic, PolyclinicCreateDto>().ReverseMap();
        CreateMap<Polyclinic, PolyclinicUpdateDto>().ReverseMap();
        CreateMap<Polyclinic, PolyclinicInfoDto>().ReverseMap();

        CreateMap<PolyclinicDoctor, PolyclinicDoctorCreateDto>().ReverseMap();
        CreateMap<PolyclinicDoctor, PolyclinicDoctorUpdateDto>().ReverseMap();
        CreateMap<PolyclinicDoctor, PolyclinicDoctorInfoDto>().ReverseMap();
    }
}