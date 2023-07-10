using Business.Interfaces;
using Configurations;
using Entities.Entities;
using System.Net.Http.Json;

namespace Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly IDomainService _domainService;
        private HttpClient _httpClient;

        public CategoryManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService=domainService;
            _httpClient=httpClient;
        }

        public async Task<Category> Add(Category category)
        {
            var response = await _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() +"/api/category/add", category);
            return await response.Content.ReadFromJsonAsync<Category>();
        }

        public void Delete(Category category)
        {
            _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() +"/api/category/delete", category);
        }

        public async Task<List<Category>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain() +"/api/category/getall");
            return response;
        }

        public async Task<Category> GetById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Category>(_domainService.Domain() +"/api/category/getbyid/"+id);
            return response;
        }

        public async Task<List<Category>> Paging(int skip, int take)
        {
            var response = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain() +"/api/category/paging/"+skip+"/"+take);
            return response;
        }

        public async Task<Category> Update(Category category)
        {
            var response = await _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() +"/api/category/update", category);
            return await response.Content.ReadFromJsonAsync<Category>();
        }
    }
}
