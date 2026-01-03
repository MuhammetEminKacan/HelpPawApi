using HelpPawApi.Domain.Entities.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelpPawApi.Application.DTOs.Query.GetUsers
{
    public class GetUsersQueryResponse
    {
        public List<UserListDto> Users { get; set; }
        public bool IsSucces{ get; set; }
        public string? Message{ get; set; }

    }
    public class UserListDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }


}
