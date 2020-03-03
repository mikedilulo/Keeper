using System;
using System.Collections.Generic;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultsService
  {
    private readonly VaultsRepository _vrepo;
    public VaultsService(VaultsRepository vrepo)
    {
      _vrepo = vrepo;
    }

    internal IEnumerable<Vault> GetVaultsByUserId(string userId)
    {
      return _vrepo.GetVaultsByUserId(userId);
    }

    internal Vault GetVaultById(int id)
    {
      var foundVault = _vrepo.GetVaultById(id);
      if (foundVault == null) { throw new Exception("Invalid Id: Vault Cannot Be Found"); }
      return foundVault;
    }

    internal Vault CreateVault(Vault newVault)
    {
      newVault.Id = _vrepo.CreateVault(newVault);
      return newVault;
    }

    internal Vault EditVaultById(Vault newEditedVault)
    {
      Vault privateVaultExists = _vrepo.GetVaultById(newEditedVault.Id);
      if (privateVaultExists == null) { throw new Exception("Invalid Id: Cannot Edit Vault"); }
      _vrepo.EditVaultById(newEditedVault);
      return newEditedVault;
    }

    internal object DeleteVaultById(string userId, int id)
    {
      var privateVaultExistsToDelete = _vrepo.GetVaultById(id);
      if (privateVaultExistsToDelete == null) { throw new Exception("Invalid Id: Cannot Delete This Vault"); }
      if (privateVaultExistsToDelete.UserId != userId) { throw new Exception("Your Request Is Invalid: You Cannot Delete This Vault"); }
      _vrepo.DeleteVaultById(id);
      return "Successfully Deleted Vault";
    }
  }
}