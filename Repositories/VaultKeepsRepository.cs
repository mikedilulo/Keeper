using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
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
      string sql = @"
      SELECT k.* FROM vaultkeeps vk
      INNER JOIN keeps k ON k.id = vk.keepId 
      WHERE (vk.vaultId = @vaultId AND vk.userId = @userId)";
      return _db.Query<Keep>(sql, new { vaultId, userId });
    }
    internal VaultKeep Find(int keepId, int vaultId)
    {
      string sql = @"
      SELECT * FROM vaultkeeps
      WHERE (keepId = @keepId AND vaultId = @vaultId)";
      return _db.QueryFirstOrDefault<VaultKeep>(sql, new { keepId, vaultId });
    }

    internal int CreateVaultKeep(VaultKeep vaultKeepData)
    {
      string sql = @"
      INSERT INTO vaultkeeps
      (keepId, vaultId, userId)
      VALUES
      (@keepId, @vaultId, @userId);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, vaultKeepData);
      vaultKeepData.Id = id;
      return id;
    }

    internal void DeleteVaultKeepByVaultId(int keepId, int vaultId, string userId)
    {
      string sql = "DELETE FROM vaultkeeps WHERE keepId = @keepId AND vaultId = @vaultId AND userId = @userId";
      _db.Execute(sql, new { keepId, vaultId, userId });
    }

  }
}