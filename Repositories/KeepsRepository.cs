using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Dapper;

namespace Keepr.Repositories
{
  public class KeepsRepository
  {
    private readonly IDbConnection _db;

    public KeepsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Keep> Get()
    {
      string sql = "SELECT * FROM Keeps WHERE isPrivate = 0;";
      return _db.Query<Keep>(sql);
    }

    internal Keep GetKeepById(int id)
    {
      string sql = "SELECT * FROM keeps WHERE id = @id";
      return _db.QueryFirstOrDefault<Keep>(sql, new { id });
    }

    internal int Create(Keep KeepData)
    {
      string sql = @"
      INSERT INTO keeps
      (userId, name, description, img, isPrivate, views, shares, keeps, createdBy, timeStamp)
      VALUES
      (@UserId, @Name, @Description, @Img, @IsPrivate, @Views, @Shares, @Keeps, @CreatedBy, @TimeStamp);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, KeepData);
      KeepData.Id = id;
      return id;
    }

    internal void EditKeepById(Keep editedKeep)
    {
      string sql = @"
      UPDATE keeps
      SET
      name = @Name,
      description = @Description,
      img = @Img,
      isPrivate = @IsPrivate,
      views = @Views,
      shares = @Shares,
      keeps = @Keeps,
      createdBy = @CreatedBy,
      timeStamp = @TimeStamp
      WHERE (id = @id AND userId = @UserId";
      _db.Execute(sql, editedKeep);
    }

    internal void DeleteKeepById(int id)
    {
      string sql = "DELETE FROM keeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}