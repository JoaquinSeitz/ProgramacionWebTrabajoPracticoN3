using System.Text.Json;
using Microsoft.JSInterop;

namespace ProgramacionWebTrabajoPracticoN3.Services // Cambia esto por el namespace real de tu frontend
{
    public class LocalStorageService
    {
        private readonly IJSRuntime _js;

        public LocalStorageService(IJSRuntime js) => _js = js;

        public async ValueTask SetItemAsync<T>(string key, T value)
            => await _js.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));

        public async ValueTask<T?> GetItemAsync<T>(string key)
        {
            var json = await _js.InvokeAsync<string>("localStorage.getItem", key);
            return json == null ? default : JsonSerializer.Deserialize<T>(json);
        }

        public async ValueTask RemoveItemAsync(string key)
            => await _js.InvokeVoidAsync("localStorage.removeItem", key);
    }
}