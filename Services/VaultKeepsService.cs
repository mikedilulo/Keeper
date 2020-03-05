using System;
using System.Collections.Generic;
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

    internal IEnumerable<Keep> GetKeepsByVaultId(int vaultId, string userId)
    {
      return _vkrepo.GetKeepsByVaultId(vaultId, userId);
    }

    internal VaultKeep CreateVaultKeep(VaultKeep vaultKeepData)
    {
      VaultKeep exists = _vkrepo.Find(vaultKeepData.VaultId, vaultKeepData.KeepId);
      if (exists != null) { throw new Exception("Invalid: VaultKeep Relationship Already Exists"); }
      vaultKeepData.Id = _vkrepo.CreateVaultKeep(vaultKeepData);
      return vaultKeepData;
    }

    internal object DeleteVaultKeepByVaultId(int keepId, int vaultId, string userId)
    {
      VaultKeep exists = _vkrepo.Find(keepId, vaultId);
      if (exists == null) { throw new Exception("Invalid : There Is No VaultKeep To Delete"); }
      _vkrepo.DeleteVaultKeepByVaultId(keepId, vaultId, userId);
      return "Successfully Deleted Vault Keep";
    }
  }
}