using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
	public class FoodService : IFoodService
	{
		public event Action OnChange;
		public int Food { get; set; } = 1000;

		public void EatFood(int amount)
		{
			Food -= amount;
			FoodChanged();
		}
		public void AddFood(int amount)
		{
			Food += amount;
			FoodChanged();
		}

		void FoodChanged() => OnChange.Invoke();
	}
}
