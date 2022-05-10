using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using DndApp.Models;

namespace DndApp.Services
{
    public class DndApiService
    {
        public IRestClient client;

        public DndApiService(string apiUrl)
        {
            client = new RestClient(apiUrl);
        }

       
        public ApiReferenceList ReturnListOfRaceDetails()
        {
            RestRequest request = new RestRequest("/api/races");
            IRestResponse<ApiReferenceList> response = client.Get<ApiReferenceList>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public List<ApiReference> DisplayRaceList()
        {
            ApiReferenceList returnedData = ReturnListOfRaceDetails();
            return returnedData.Results;
        }

        public Race GetRaceDetail(string url)
        {
            RestRequest request = new RestRequest(url);
            IRestResponse<Race> response = client.Get<Race>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        

        public ApiReferenceList ReturnListOfClassDetails()
        {
            RestRequest request = new RestRequest("/api/classes");
            IRestResponse<ApiReferenceList> response = client.Get<ApiReferenceList>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public List<ApiReference> DisplayClassList()
        {
            ApiReferenceList returnedData = ReturnListOfClassDetails();
            return returnedData.Results;
        }

        public Class GetClassDetail(string url)
        {
            RestRequest request = new RestRequest(url);
            IRestResponse<Class> response = client.Get<Class>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public List<Spell> DisplaySpellsByClassLevel()
        {
            return 
        }

        public ApiReferenceList ReturnListOfSpells()
        {
            RestRequest request = new RestRequest("/api/spells");
            IRestResponse<ApiReferenceList> response = client.Get<ApiReferenceList>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }
        public List<ApiReference> DisplaySpellList()
        {
            ApiReferenceList returnedData = ReturnListOfSpells();
            return returnedData.Results;
        }
        public Spell GetSpellDetail(string url)
        {
            RestRequest request = new RestRequest(url);
            IRestResponse<Spell> response = client.Get<Spell>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }
    }
}
