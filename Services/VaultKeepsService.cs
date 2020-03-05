using System;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultKeepsService
  {
    private readonly VaultKeepsRepository _vkrepo;
    public VaultKeepsService(VaultKeepsRepository vkrepo)
    {
      _vkrepo = vkrepo;
    }

    internal object GetKeepsByVaultId(int vaultId, string userId)
    {
      throw new NotImplementedException();
    }

    internal object CreateVaultKeep(VaultKeep vaultKeepData)
    {
      throw new NotImplementedException();
    }

    internal object DeleteKeepByVaultId(int keepId, int vaultId, string userId)
    {
      throw new NotImplementedException();
    }
  }
}