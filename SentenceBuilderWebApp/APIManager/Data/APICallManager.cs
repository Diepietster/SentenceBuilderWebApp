﻿using SentenceBuilderWebApp.Models.BaseResponse;
using SentenceBuilderWebApp.Models;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using SentenceBuilderWebApp.APIManager.Interface;
using SentenceBuilderWebApp.Pages;
using SentenceBuilderWebApp.Models.DTOModels;

namespace SentenceBuilderWebApp.APIManager.Data
{
    public class APICallManager: IAPICallManager
    {
        HttpClient _httpClient { get; }

        public APICallManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Sentence>> GetSentencesAsync()
        {
            try
            {
                List<Sentence> sentences = new List<Sentence>();
                var returnData = await _httpClient.GetFromJsonAsync<BaseResponse<List<Sentence>>>($"Sentence/GetAllSentences?api_key=295d8839-ce36-4606-a533-76a0250a5048");

                if (returnData.Success)
                {
                    sentences = returnData.Data;
                }

                return sentences;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Words>> GetAllWordsByType(int wordTypeId)
        {
            try
            {
                List<Words> words = new List<Words>();  
                var returnData = await _httpClient.GetFromJsonAsync<BaseResponse<List<Words>>>($"Words/GetAllWordsByType/{wordTypeId}?api_key=295d8839-ce36-4606-a533-76a0250a5048");

                if (returnData.Success)
                {
                    words = returnData.Data;
                }

                return words;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<WordType>> GetAllwordTypesAsync()
        {
            try
            {
                List<WordType> WordTypes = new List<WordType>();
                var returnData = await _httpClient.GetFromJsonAsync<BaseResponse<List<WordType>>>($"WordType/GetAllWordTypes?api_key=295d8839-ce36-4606-a533-76a0250a5048");

                if (returnData.Success)
                {
                    WordTypes = returnData.Data;
                }

                return WordTypes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BaseResponse> AddWord(WordDTOCreate word)
        {
            try
            {
                var addedSuccessfully = new BaseResponse();
                var returnData = await _httpClient.PostAsJsonAsync<WordDTOCreate>($"Words/AddWord?api_key=295d8839-ce36-4606-a533-76a0250a5048", word);

                if(returnData.IsSuccessStatusCode)
                {
                    addedSuccessfully.Success = true;
                    addedSuccessfully.Message = "Added Word Successfully!";
                }

                return addedSuccessfully;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<BaseResponse> AddSentence(string sentence)
        {
            try
            {
                var addedSuccessfully = new BaseResponse();
                SentenceDTOCreate newSentence = new SentenceDTOCreate
                {
                    SentenceDesc = sentence
                };

                var returnData = await _httpClient.PostAsJsonAsync<SentenceDTOCreate>($"Sentence/CreateSentence?api_key=295d8839-ce36-4606-a533-76a0250a5048", newSentence);

                if (returnData.IsSuccessStatusCode)
                {
                    addedSuccessfully.Success = true;
                    addedSuccessfully.Message = "Added Sentence Successfully!";
                }

                return addedSuccessfully;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
