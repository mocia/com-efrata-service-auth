﻿using Com.Efrata.Service.Auth.Lib.Models;
using Com.Efrata.Service.Auth.Lib.ViewModels;

namespace Com.Efrata.Service.Auth.Lib.AutoMapperProfiles
{
    public class RoleProfile : BaseProfile
    {
        public RoleProfile() : base()
        {
            CreateMap<Permission, PermissionViewModel>()
                .ForPath(d => d.id, opt => opt.MapFrom(s => s.Id))
                .ForPath(d => d.permission, opt => opt.MapFrom(s => s.permission))
                .ForPath(d => d.roleId, opt => opt.MapFrom(s => s.RoleId))
                .ForPath(d => d.unit.Code, opt => opt.MapFrom(s => s.UnitCode))
                .ForPath(d => d.unit.Division.Name, opt => opt.MapFrom(s => s.Division))
                .ForPath(d => d.unit.Name, opt => opt.MapFrom(s => s.Unit))
                .ForPath(d => d.unit.Id, opt => opt.MapFrom(s => s.UnitId))
                .ForPath(d => d._createAgent, opt => opt.MapFrom(s => s.CreatedAgent))
                .ForPath(d => d._createdBy, opt => opt.MapFrom(s => s.CreatedBy))
                .ForPath(d => d._createdDate, opt => opt.MapFrom(s => s.CreatedUtc))
                .ReverseMap();

            CreateMap<Role, RoleViewModel>()
                .ForPath(d => d.code, opt => opt.MapFrom(s => s.Code))
                .ForPath(d => d.description, opt => opt.MapFrom(s => s.Description))
                .ForPath(d => d.name, opt => opt.MapFrom(s => s.Name))
                .ForPath(d => d.permissions, opt => opt.MapFrom(s => s.Permissions))
                .ReverseMap();
        }
    }
}
