using Qualtrics.Api.Models;
using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IGroupService
    {
        ListGroupsResponse ListGroups(string divisionId = null, int? offset = null);
        SimpleIdResponse CreateGroup(CreateGroupRequest createGroupRequest);
        GetGroupResponse GetGroup(string groupId);
        BaseResponse UpdateGroup(UpdateGroupRequest updateGroupRequest);
        BaseResponse DeleteGroup(string groupId);
        BaseResponse AddUserToGroup(string userId, string groupId);
        BaseResponse RemoveUserFromGroup(string userId, string groupId);
    }
}
