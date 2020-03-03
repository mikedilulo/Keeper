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
      throw new NotImplementedException();
    }

    internal object DeleteVaultById(string userId, int id)
    {
      throw new NotImplementedException();
    }
  }
}