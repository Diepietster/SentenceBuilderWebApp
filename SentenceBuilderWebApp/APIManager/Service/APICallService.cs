using SentenceBuilderWebApp.APIManager.Interface;
using SentenceBuilderWebApp.Models;
using SentenceBuilderWebApp.Models.BaseResponse;
using SentenceBuilderWebApp.Models.DTOModels;

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

        public async Task<BaseResponse> AddWord(WordDTOCreate word)
        {
            return await _api.AddWord(word);
        }

        public async Task<BaseResponse> CreateSentene(string sentence)
        {
            return await _api.AddSentence(sentence);
        }
    }
}
