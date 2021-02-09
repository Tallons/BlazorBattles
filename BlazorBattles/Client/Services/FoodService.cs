using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
	public class FoodService : IFoodService
	{
		private readonly HttpClient _http;
		public FoodService(HttpClient http)
		{
			_http = http;
		}
		public event Action OnChange;
		public int Food { get; set; } = 0;

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

		public async Task GetFood()
		{
			Food = await _http.GetFromJsonAsync<int>("api/User/GetFood");
			FoodChanged();
		}

		void FoodChanged() => OnChange.Invoke();
	}
}
