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
  }
}