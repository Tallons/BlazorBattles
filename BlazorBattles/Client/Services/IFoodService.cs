using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
	public interface IFoodService
	{
		event Action OnChange;
		int Food { get; set; }
		void EatFood(int amount);
		void AddFood(int amount);

		Task GetFood();
	}
}
