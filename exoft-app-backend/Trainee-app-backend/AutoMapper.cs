using System;
using AutoMapper;
using Trainee_app_backend.Data.Entities;
using Trainee_app_backend.Data.DTOs;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<User, UserInfoDTO>();
            CreateMap<UserInfoDTO, User>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserCreateDTO>();
            CreateMap<UserUpdateDTO, User>();
            CreateMap<User, UserUpdateDTO>();
            CreateMap<AchievementUpdateDTO, Achievement>();
            CreateMap<AchievementCreateDTO, Achievement>();
        }
    }
}
