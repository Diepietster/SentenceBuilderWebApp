using SentenceBuilderWebApp.APIManager.Interface;
using SentenceBuilderWebApp.Models;

namespace SentenceBuilderWebApp.APIManager.Service
{
    public class APICallService
    {
        private readonly IAPICallManager _api;

        public APICallService(IAPICallManager api)
        {
            _api = api;
        }

        public async Task<List<Sentence>> GetSentences()
        {
            return await _api.GetSentencesAsync();
        }

        public async Task<List<Words>> GetWordsByTypeAsync(int wordtypeId)
        {
            return await _api.GetAllWordsByType(wordtypeId);
        }

        public async Task<List<WordType>> GetWordTypesAsync()
        {
            return await _api.GetAllwordTypesAsync();
        }
    }
}
