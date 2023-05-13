using SentenceBuilderWebApp.Models;
using SentenceBuilderWebApp.Models.BaseResponse;
using SentenceBuilderWebApp.Models.DTOModels;

namespace SentenceBuilderWebApp.APIManager.Interface
{
    public interface IAPICallManager
    {
        Task<List<Sentence>> GetSentencesAsync();
        Task<List<Words>> GetAllWordsByType(int wordTypeId);
        Task<List<WordType>> GetAllwordTypesAsync();
        Task<BaseResponse> AddWord(WordDTOCreate word);
        Task<BaseResponse> AddSentence(string sentence);
    }
}
