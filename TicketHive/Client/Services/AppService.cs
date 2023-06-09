using Newtonsoft.Json;
using System.Net.Http.Json;
using TicketHive.Shared.Models;

namespace TicketHive.Client.Services
{
	public class AppService : IAppService
	{
		private readonly HttpClient httpClient;
		public AppService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		// =========== EventModel Calls ==========


		public async Task<List<EventModel>?> GetEventsAsync()
		{
			var result = await httpClient.GetFromJsonAsync<List<EventModel>>("api/events");

			if (result != null)
			{
				return result;
			}
			return null;
		}

		public async Task<EventModel?> GetEventByIdAsync(int id)
		{
			var result = await httpClient.GetFromJsonAsync<EventModel>($"api/events/{id}");

			if (result != null)
			{
				return result;
			}
			return null;
		}

		public async Task PostEventAsync(EventModel model)
		{
			await httpClient.PostAsJsonAsync("api/events", model);
		}
		public async Task PutEventAsync(int id, EventModel model)
		{
			await httpClient.PutAsJsonAsync($"api/events/{id}", model);
		}
		public async Task DeleteEventAsync(int id)
		{
			await httpClient.DeleteAsync($"api/events/{id}");
		}

		// =========== UserModel Calls ===========

		/// <summary>
		/// Retrieves a list of user models asynchronously from the API.
		/// </summary>
		public async Task<List<UserModel>?> GetUsersAsync()
		{
			var result = await httpClient.GetFromJsonAsync<List<UserModel>>("api/users");

			if (result != null)
			{
				return result;
			}
			return null;
		}

		/// <summary>
		/// Retrieves a user model asynchronously by username from the API.
		/// </summary>
		public async Task<UserModel?> GetUserByUsernameAsync(string UserName)
		{
			var result = await httpClient.GetFromJsonAsync<UserModel>($"api/users/{UserName}");

			if (result != null)
			{
				return result;
			}
			return null;
		}
		/// <summary>
		/// Retrieves a user model asynchronously by username from the API, including associated events.
		/// </summary>
		public async Task<UserModel?> GetUserByUsernameIncludeEventsAsync(string UserName)
		{
			var result = await httpClient.GetFromJsonAsync<UserModel>($"api/users/{UserName}/include");

			if (result != null)
			{
				return result;
			}
			return null;
		}
		/// <summary>
		/// Updates a user asynchronously by ID with the provided user model via HTTP PUT request to the API.
		/// </summary>
		public async Task<string?> PutUserAsync(int id, UserModel model)
		{
			var response = await httpClient.PutAsJsonAsync($"api/users/{id}", model);
			if (response.IsSuccessStatusCode)
			{
				var result = await response.Content.ReadAsStringAsync();
				return result;
			}
			return null;
		}

		// ========== ApplicationUser Calls ============

		/// <summary>
		/// Retrieves the country of a user by username asynchronously via HTTP GET request to the API.
		/// </summary>
		public async Task<string?> GetUserCountryByUsernameAsync(string AppUsername)
		{
			var response = await httpClient.GetAsync($"api/appusers/{AppUsername}");
			var json = await response.Content.ReadAsStringAsync();

			if (json != null)
			{
				return json;
			}
			return null;
		}

		/// <summary>
		/// Updates the country of an app user by username asynchronously with the provided country string
		/// via HTTP PUT request to the API.
		/// </summary>
		public async Task<string?> PutAppUserCountryAsync(string AppUsername, string Country)
		{
			List<string> words = new();
			words.Add(Country);
			var jsonList = JsonConvert.SerializeObject(words);
			var result = await httpClient.PutAsJsonAsync($"api/appusers/{AppUsername}", jsonList);
			if (result.IsSuccessStatusCode)
			{
				var response = await result.Content.ReadAsStringAsync();
				if (response != null)
				{
					return response;
				}
			}
			words.Clear();
			return null;
		}

		/// <summary>
		/// Updates the password of an app user by username asynchronously with the provided current and new password
		/// via HTTP PUT request to the API.
		/// </summary>
		public async Task<string?> PutAppUserAsync(string AppUsername, string currentPassword, string newPassword)
		{
			List<string> words = new();
			words.Add(currentPassword);
			words.Add(newPassword);
			var jsonList = JsonConvert.SerializeObject(words);
			var result = await httpClient.PutAsJsonAsync($"api/appusers/{AppUsername}", jsonList);
			if (result.IsSuccessStatusCode)
			{
				var response = await result.Content.ReadAsStringAsync();
				if (response != null)
				{
					return response;
				}
			}
			words.Clear();
			return await result.Content.ReadAsStringAsync();
		}
	}
}