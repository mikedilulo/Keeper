using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class KeepsController : ControllerBase
  {
    private readonly KeepsService _ks;
    public KeepsController(KeepsService ks)
    {
      _ks = ks;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Keep>> Get()
    {
      try
      {
        return Ok(_ks.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      };
    }
    [HttpGet("private")]
    [Authorize]

    public ActionResult<IEnumerable<Keep>> GetPrivateKeepsByUserId(string userId)
    {
      try
      {
        var creatorId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.GetPrivateKeeps(userId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("public")]
    [Authorize]

    public ActionResult<IEnumerable<Keep>> GetPublicKeepsByUserId(string userId)
    {
      try
      {
        var creatorId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.GetPublicKeeps(userId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("public/{id}")]
    public ActionResult<Keep> GetPublicKeepById(int id)
    {
      try
      {
        return Ok(_ks.GetPublicKeepById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("private/{id}")]
    [Authorize]
    public ActionResult<Keep> GetPrivateKeepById(int id)
    {
      try
      {
        return Ok(_ks.GetPrivateKeepById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    [Authorize]
    public ActionResult<Keep> Post([FromBody] Keep newKeep)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        newKeep.UserId = userId;
        return Ok(_ks.Create(newKeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("public/{id}")]
    [Authorize]
    public ActionResult<Keep> Edit([FromBody] Keep editedPublicKeep, int id)
    {
      try
      {
        editedPublicKeep.Id = id;
        editedPublicKeep.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.EditPublicKeepById(editedPublicKeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("private/{id}")]
    [Authorize]
    public ActionResult<Keep> Edit([FromBody] Keep editedPrivateKeep, int id, string userId)
    {
      try
      {
        editedPrivateKeep.Id = id;
        editedPrivateKeep.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.EditPrivateKeepById(editedPrivateKeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //TODO Delete methods hard delete data / need to switch to soft delete

    [HttpDelete("public/{id}")]
    [Authorize]
    public ActionResult<String> DeletePublicKeep(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.DeletePublicKeepById(userId, id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("private/{id}")]
    [Authorize]
    public ActionResult<String> DeletePrivateKeep(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ks.DeletePrivateKeepById(userId, id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}