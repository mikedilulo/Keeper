using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Keepr.Models;

namespace Keepr.Repositories
{
  public class VaultsRepository
  {
    private readonly IDbConnection _db;
    public VaultsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Vault> GetVaultsByUserId(string userId)
    {
      string sql = "SELECT * FROM keeps WHERE userId = @UserId;";
      return _db.Query<Vault>(sql, userId);
    }

    internal Vault GetVaultById(int id)
    {
      string sql = "SELECT * FROM keeps WHERE id = @id";
      return _db.QueryFirstOrDefault<Vault>(sql, new { id });
    }

    internal int CreateVault(Vault newVault)
    {
      string sql = @"
      INSERT INTO vaults
      (userId, name, description, img, createdBy, timeStamp)
      VALUES
      (@UserId, @Name, @Description, @Img, @CreatedBy, @TimeStamp);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newVault);
      newVault.Id = id;
      return id;
    }

    internal void EditVaultById(Vault newEditedVault)
    {
      throw new NotImplementedException();
    }

    internal void DeleteVaultById(int id)
    {
      throw new NotImplementedException();
    }
  }
}