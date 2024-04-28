using Application.DTOs;
using Application.Interfaces.User;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet]
    public async Task<ActionResult<List<UserDto>>> GetAllUsers()
    {
        return Ok(await _userService.GetAllUsersAsync());
    }

    [HttpGet("{userId}")]
    public async Task<ActionResult<UserDto>> GetUserById(string userId)
    {
        return Ok(await _userService.GetUserByIdAsync(userId));
    }

    [HttpDelete("{userId}")]
    public ActionResult DeleteUser(string userId)
    {
        _userService.DeleteUserAsync(userId);
        return NoContent();
    }

    [HttpGet("{userId}/roles")]
    public async Task<ActionResult<List<string>>> GetUserRolesAsync(string userId)
    {
        var roles = await _userService.GetUserRoles(userId);
        return Ok(roles);
    }

    [HttpPost("{userId}/roles")]
    public ActionResult AssignRoleToUser(string userId, [FromBody] string roleId)
    {
        _userService.UpdateUserRole(userId, roleId);
        return CreatedAtAction(nameof(GetUserRolesAsync), new { userId = userId }, roleId);
    }
}
