using System;
using System.Collections.Generic;
using System.Security.Claims;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class VaultsController : ControllerBase
  {
    private readonly VaultsService _vs;
    public VaultsController(VaultsService vs)
    {
      _vs = vs;
    }
    [HttpGet("private")]
    [Authorize]
    public ActionResult<IEnumerable<Vault>> Get(string userId)
    {
      try
      {
        return Ok(_vs.GetVaultsByUserId(userId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("private/{id}")]
    [Authorize]
    public ActionResult<Vault> GetById(int id)
    {
      try
      {
        return Ok(_vs.GetVaultById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    [Authorize]
    public ActionResult<Vault> Create([FromBody] Vault newVault)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        newVault.UserId = userId;
        return Ok(_vs.CreateVault(newVault));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("private/{id}")]
    [Authorize]
    public ActionResult<Vault> Edit([FromBody] Vault newEditedVault, int id)
    {
      try
      {
        newEditedVault.Id = id;
        newEditedVault.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_vs.EditVaultById(newEditedVault));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("private/{id}")]
    [Authorize]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_vs.DeleteVaultById(userId, id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}