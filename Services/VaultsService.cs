using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultsService
  {
    private readonly VaultsRepository _vrepo;
    public VaultsService(VaultsRepository vrepo)
    {
      _vrepo = vrepo;
    }

  }
}