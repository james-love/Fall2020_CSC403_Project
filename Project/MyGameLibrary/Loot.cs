using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class Loot : Character {
    public PictureBox Icon { get; set; }
    public event Action<Loot> LootHandler;

    public Loot(Vector2 initPos, Collider collider, PictureBox pic, Action<Loot> OnLooted) : base(initPos, collider) {
      Icon = pic;
      LootHandler += OnLooted;
    }

    public void OnLooted()
    {
      LootHandler(this);
    }
  }
}
