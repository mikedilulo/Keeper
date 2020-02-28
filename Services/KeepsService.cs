using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class KeepsService
  {
    private readonly KeepsRepository _repo;
    public KeepsService(KeepsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Keep> Get()
    {
      return _repo.Get();
    }

    internal object GetPrivateKeeps(string userId)
    {
      throw new NotImplementedException();
    }
    public Keep Create(Keep newKeep)
    {
      newKeep.Id = _repo.Create(newKeep);
      return newKeep;
    }

    internal object CreatePrivateKeep(Keep newPrivateKeep, string userId)
    {
      throw new NotImplementedException();
    }

    internal object EditKeepById(Keep editedKeep)
    {
      throw new NotImplementedException();
    }

    internal object DeleteKeepById(string userId, int id)
    {
      throw new NotImplementedException();
    }
  }
}