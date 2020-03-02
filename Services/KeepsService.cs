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

    internal IEnumerable<Keep> GetPrivateKeeps(string userId)
    {
      return _repo.GetPrivateKeeps(userId);
    }
    internal IEnumerable<Keep> GetPublicKeeps(string userId)
    {
      return _repo.GetPublicKeeps(userId);
    }
    internal Keep GetPublicKeepById(int id)
    {
      var foundKeep = _repo.GetPublicKeepById(id);
      if (foundKeep == null) { throw new Exception("Invalid Id: Public Keep Cannot Be Found"); }
      return foundKeep;
    }
    internal Keep GetPrivateKeepById(int id)
    {
      var foundPrivateKeep = _repo.GetPrivateKeepById(id);
      if (foundPrivateKeep == null) { throw new Exception("Invalid Id: Private Keep Cannot Be Found"); }
      return foundPrivateKeep;
    }
    public Keep Create(Keep newKeep)
    {
      newKeep.Id = _repo.Create(newKeep);
      return newKeep;
    }

    internal Keep EditPublicKeepById(Keep editedPublicKeep)
    {
      Keep publicKeepExists = _repo.GetPublicKeepById(editedPublicKeep.Id);
      if (publicKeepExists == null) { throw new Exception("Invalid Id: Cannot Edit Public Keep"); }
      _repo.EditPublicKeepById(editedPublicKeep);
      return editedPublicKeep;
    }

    internal object EditPrivateKeepById(Keep editedPrivateKeep)
    {
      Keep privateKeepExists = _repo.GetPrivateKeepById(editedPrivateKeep.Id);
      if (privateKeepExists == null) { throw new Exception("Invalid Id: Cannot Edit Private Keep"); }
      _repo.EditPrivateKeepById(editedPrivateKeep);
      return editedPrivateKeep;
    }

    //TODO Delete methods hard delete data / need to switch to soft delete
    internal object DeletePublicKeepById(string userId, int id)
    {
      var publicKeepExistsToDelete = _repo.GetPublicKeepById(id);
      if (publicKeepExistsToDelete == null) { throw new Exception("Invalid Id: Cannot Delete This Public Keep"); }
      if (publicKeepExistsToDelete.UserId != userId) { throw new Exception("Your Request Is Invalid: You Cannot Delete This Public Keep"); }
      _repo.DeletePublicKeepByid(id);
      return "Successfully Deleted Public Keep";
    }

    internal object DeletePrivateKeepById(string userId, int id)
    {
      var privateKeepExistsToDelete = _repo.GetPrivateKeepById(id);
      if (privateKeepExistsToDelete == null) { throw new Exception("Invalid Id: Cannot Delete This Public Keep"); }
      if (privateKeepExistsToDelete.UserId != userId) { throw new Exception("Your Request Is Invalid: You Cannot Delete This Private Keep"); }
      _repo.DeletePrivateKeepByid(id);
      return "Successfully Deleted Private Keep";
    }
  }
}