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
    internal Keep GetKeepById(int id)
    {
      var foundKeep = _repo.GetKeepById(id);
      if (foundKeep == null) { throw new Exception("Invalid: Specified Keep Id Cannot Be Found"); }
      return foundKeep;
    }
    internal IEnumerable<Keep> GetPrivateKeep(string userId)
    {
      return _repo.GetPrivateKeep(userId);
    }
    public Keep Create(Keep newKeep)
    {
      newKeep.Id = _repo.Create(newKeep);
      return newKeep;
    }


    internal Keep EditKeepById(Keep editedKeep)
    {
      Keep keepExists = _repo.GetKeepById(editedKeep.Id);
      if (keepExists == null) { throw new Exception("Invalid: Specified Keep Id Cannot Be Found To Edit"); }
      _repo.EditKeepById(editedKeep);
      return editedKeep;
    }


    internal object DeleteKeepById(string userId, int id)
    {
      var keepExistsToDelete = _repo.GetKeepById(id);
      if (keepExistsToDelete == null) { throw new Exception("Invalid: Specified Keep Id Cannot Be Found To Delete"); }
      if (keepExistsToDelete.UserId != userId) { throw new Exception("Invalid: You Do Not Have Permission To Delete This Keep"); }
      _repo.DeleteKeepById(id);
      return "Success: You Have Deleted The Keep";
    }
  }
}