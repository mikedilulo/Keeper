using System;
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

    internal object GetVaultsByUserId()
    {
      throw new NotImplementedException();
    }

    internal object GetVaultById(int id)
    {
      throw new NotImplementedException();
    }

    internal object CreateVault(Vault newVault)
    {
      throw new NotImplementedException();
    }

    internal object EditVaultById(Vault newEditedVault)
    {
      throw new NotImplementedException();
    }

    internal object DeleteVaultById(string userId, int id)
    {
      throw new NotImplementedException();
    }
  }
}