using Terraria.ModLoader;
using Terraria.ID;

namespace KebabBrooooo.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SiniorHuevoHatDisguise : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}