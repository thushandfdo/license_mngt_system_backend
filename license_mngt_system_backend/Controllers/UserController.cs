using license_mngt_system_backend.Exceptions;
using license_mngt_system_backend.Interfaces.Services;
using license_mngt_system_backend.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace license_mngt_system_backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    // GET: api/User/5
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        try
        {
            if (id <= 0)
            {
                throw new InvalidArgsException("Invalid ID provided");
            }
            
            var user = await _userService.GetUserById(id);
            return Ok(user);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (InvalidArgsException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    // GET: api/User
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        try
        {
            var users = await _userService.GetUsers();
            return Ok(users);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    // POST: api/User
    [HttpPost]
    public async Task<IActionResult> PostUser(User user)
    {
        try
        {
            await _userService.InsertUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, user);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    // PUT: api/User/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> PutUser(int id, User user)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID provided");
            }
            
            if (id != user.UserId)
            {
                return BadRequest("ID mismatch");
            }
            
            var updatedUser = await _userService.UpdateUser(user);
            return Ok(updatedUser);
        }
        catch (DbUpdateConcurrencyException) when (_userService.IsUserExists(id).Result)
        {
            return NotFound();
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }

    // DELETE: api/User/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID provided");
            }

            var deletedUser = await _userService.DeleteUser(id);
            return Ok(deletedUser);
        }
        catch (InvalidArgsException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(500);
        }
    }
}