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
      string sql = "SELECT * FROM keeps WHERE isPrivate = 0;";
      return _db.Query<Keep>(sql);
    }

    internal IEnumerable<Keep> GetPrivateKeeps(string userId)
    {
      string sql = "SELECT * FROM keeps WHERE isPrivate = 1;";
      return _db.Query<Keep>(sql, userId);
    }

    internal IEnumerable<Keep> GetAllKeepsByUserId(string userId)
    {
      string sql = "SELECT * FROM keeps WHERE userId = userId;";
      return _db.Query<Keep>(sql, userId);
    }

    internal Keep GetPublicKeepById(int id)
    {
      string sql = "SELECT * FROM keeps WHERE id = @Id";
      return _db.QueryFirstOrDefault<Keep>(sql, new { id });
    }

    internal Keep GetPrivateKeepById(int id)
    {
      string sql = "SELECT * FROM keeps WHERE id = @Id";
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

    internal void EditPublicKeepById(Keep editedPublicKeep)
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
      WHERE (id = @id AND userId = @UserId)";
      _db.Execute(sql, editedPublicKeep);
    }

    internal void EditPrivateKeepById(Keep editedPrivateKeep)
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
      timestamp = @TimeStamp
      WHERE (id = @id AND userId = @UserId)";
      _db.Execute(sql, editedPrivateKeep);
    }

    //TODO Delete methods hard delete data / need to switch to soft delete
    internal void DeletePublicKeepByid(int id)
    {
      string sql = "DELETE FROM keeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }

    internal void DeletePrivateKeepByid(int id)
    {
      string sql = "DELETE FROM keeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}