﻿using AutoMapper;
using PoohAPI.Infrastructure.UserDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using WordPressPCL;
using WordPressPCL.Models;

namespace PoohAPI.Infrastructure.UserDB.Repositories
{
    public class UserRepository : IUserRepository
    {
        private WordPressClient _client { get; set; }
        private IMapper _mapper;

        public UserRepository(IMapper mapper)
        {
            CreateClientAsync();
            _mapper = mapper;
        }

        public async Task<IEnumerable<WPUser>> GetAllUsersAsync()
        {
            CreateClientAsync();
            var list = await _client.Users.GetAll();
            return _mapper.Map<IEnumerable<WPUser>>(list);
        }

        public async Task<WPUser> GetUserByIdAsync(int id)
        {
            CreateClientAsync();
            var user = await _client.Users.GetByID(id);
            return _mapper.Map<WPUser>(user);
        }

        private async void CreateClientAsync()
        {
            _client = new WordPressClient("http://dev.hbo-stagemarkt.nl/wp-json/");
            //_client.AuthMethod = AuthMethod.Basic;
            //await _client.RequestJWToken("", "");
        }
    }
}
