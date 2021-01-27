using BlazorBattles.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
	public class UnitService : IUnitService
	{
		public IList<Unit> Units { get; } = new List<Unit>
		{
			new Unit {Id = 1, Title = "Warrior", Attack = 10, Defense = 10, FoodCost = 100 },
			new Unit {Id = 2, Title = "Ranger", Attack = 15, Defense = 5, FoodCost = 150 },
			new Unit {Id = 3, Title = "Wizard", Attack = 30, Defense = 0, FoodCost = 200 }
		};

		public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

		public void AddUnit(int unitId)
		{
			Unit unit = Units.First(u => u.Id == unitId);
			MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
			Console.WriteLine($"{unit.Title} was built");
			Console.WriteLine($"Your army size: {MyUnits.Count}");
		}
	}
}
