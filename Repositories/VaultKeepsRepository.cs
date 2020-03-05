using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;

namespace Keepr.Repositories
{
  public class VaultKeepsRepository
  {
    private readonly IDbConnection _db;
    public VaultKeepsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Keep> GetKeepsByVaultId(int vaultId, string userId)
    {
      throw new NotImplementedException();
    }
    internal VaultKeep Find(int keepId, int vaultId)
    {
      throw new NotImplementedException();
    }

    internal int CreateVaultKeep(VaultKeep vaultKeepData)
    {
      throw new NotImplementedException();
    }

    internal void DeleteVaultKeepByVaultId(int keepId, int vaultId, string userId)
    {
      throw new NotImplementedException();
    }

  }
}