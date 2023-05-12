using SentenceBuilderWebApp.Models;

namespace SentenceBuilderWebApp.APIManager.Interface
{
    public interface IAPICallManager
    {
        Task<List<Sentence>> GetSentencesAsync();
        Task<List<Words>> GetAllWordsByType(int wordTypeId);
        Task<List<WordType>> GetAllwordTypesAsync();
    }
}
