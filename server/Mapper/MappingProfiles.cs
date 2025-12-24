using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using server.Dtos.CardDto;
using server.Dtos.DeskDto;
using server.Dtos.NoteDto;
using server.Models;

namespace server.Profiles
{
    public class MappingProfiles: AutoMapper.Profile
    {
        public MappingProfiles()
        {
            CreateMap<Note,NoteReadDto>();
            CreateMap<NoteCreateDto, Note>();

            CreateMap<Card, CardReadDto>();

            CreateMap<Desk, DeskReadDto>();
            CreateMap<DeskCreateDto, Desk>();
        }
    }
}