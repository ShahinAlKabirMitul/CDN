using AutoMapper;
using CDN.DTOs;
using CDN.Entities;
using CDN.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CDN.Controllers;
[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UsersController(IUserRepository userRepository,IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers(int pageNumber = 1, int pageSize = 5)
    {
        var users = _userRepository.GetUsers()
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        var userDto = _mapper.Map<List<UserDto>>(users);
        return Ok( userDto);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
      var data=  await _userRepository.GetUserById(id);
      if (data == null)
      {
          return NotFound();
      }
      var userDto = _mapper.Map<UserDto>(data);
      return Ok(userDto);
    } 

    [HttpPost]
    public async Task<IActionResult> CreateUser(UserDto userDto)
    { 
        var user = _mapper.Map<User>(userDto);
       var result = await _userRepository.AddUser(user);
       if (!result)
       {
           return BadRequest("Problem saving data");
       }
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, UserUpdateDto userDto)
    {
        
       var userFromDb = await _userRepository.GetUserById(id);
       if (userFromDb == null)
       {
           return NotFound();
       }
       var user = _mapper.Map<User>(userDto);
       var result= await _userRepository.UpdateUser(user);
       if (result)
       {
           return Ok();
       }
       return BadRequest("Problem saving data");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
       var result= await _userRepository.DeleteUser(id);
       if (!result)
       {
           return BadRequest("Could not delete DB");
       }
        return Ok();
    }
}
