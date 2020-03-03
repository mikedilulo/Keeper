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
      string sql = "SELECT * FROM vaults WHERE userId = @UserId;";
      return _db.Query<Vault>(sql, userId);
    }

    internal Vault GetVaultById(int id)
    {
      string sql = "SELECT * FROM vaults WHERE id = @id";
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
      string sql = @"
      UPDATE vaults
      SET
      name = @Name,
      description = @Description,
      img = @Img,
      createdBy = @CreatedBy,
      timeStamp = @TimeStamp
      WHERE (id = @id AND userId = @UserId)";
      _db.Execute(sql, newEditedVault);
    }

    internal void DeleteVaultById(int id)
    {
      string sql = "DELETE FROM vaults WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}