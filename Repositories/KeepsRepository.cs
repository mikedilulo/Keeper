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

    internal object GetKeepById(int id)
    {
      throw new NotImplementedException();
    }

    internal int Create(Keep KeepData)
    {
      throw new NotImplementedException();
    }

    internal void EditKeepById(Keep editedKeep)
    {
      throw new NotImplementedException();
    }

    internal void DeleteKeepById(int id)
    {
      throw new NotImplementedException();
    }
  }
}