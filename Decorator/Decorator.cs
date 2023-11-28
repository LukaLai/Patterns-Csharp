using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CafeAuLait : ICafe
{
  private readonly ICafe cafe;

  public CafeAuLait(ICafe cafeinter)
  {
    cafe = cafeinter ?? throw new ArgumentNullException("cafe", "not null");
  }
  public int GetPrix()
  {
    return cafe.GetPrix() + 1;
  }

  public string GetDescription()
  {
    return String.Concat(cafe.GetDescription(), ", lait");
  }
}

class CafeFroid : ICafe
{
  private readonly ICafe cafe;

  public CafeFroid(ICafe cafeinter)
  {
    cafe = cafeinter ?? throw new ArgumentNullException("cafe", "not null");
  }
  public int GetPrix()
  {
    return cafe.GetPrix() + 1;
  }

  public string GetDescription()
  {
    return String.Concat(cafe.GetDescription(), ", froid");
  }
}

class CafeVanille : ICafe
{
  private readonly ICafe cafe;

  public CafeVanille(ICafe cafeinter)
  {
    cafe = cafeinter ?? throw new ArgumentNullException("cafe", "not null");
  }
  public int GetCost()
  {
    return cafe.GetPrix() + 1;
  }

  public string GetDescription()
  {
    return String.Concat(cafe.GetDescription(), ", Vanille");
  }
}

}
