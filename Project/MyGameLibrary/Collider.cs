using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Collider {
    private Rectangle rect;
    private Rectangle prevRect;
    public Collider(Rectangle rect) {
      this.rect = rect;
    }

    public void MovePosition(int x, int y) {
      rect.X = x;
      rect.Y = y;
    }
    public void Hide()
    {
      prevRect = rect;
      rect = Rectangle.Empty;
    }

    public void Show()
    {
      rect = prevRect;
    }

    public bool Intersects(Collider c) {
      return rect.IntersectsWith(c.rect);
    }
  }
}
